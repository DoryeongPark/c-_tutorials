using System;
using System.Windows.Forms;
using VideoPlayerController;
using System.Threading;
using System.Diagnostics;
using MetroFramework;
using MetroFramework.Forms;

namespace Assignment2
{
    /*
     *  Members
     *  syncVolume      :   Background thread to apply current volume 
     *  syncBrightness  :   Background thread to apply current brightness 
     *  muteChecker     :   Background timer to apply current mute state 
     *  VOLUME_MAX      :   Max system volume value
     */
    public partial class Assignment2 : MetroForm
    {
        private Thread syncVolume;
        private Thread syncBrightness;
        private System.Windows.Forms.Timer muteChecker;
        private int VOLUME_MAX = 65535;

        public Assignment2()
        {
            InitializeComponent();
        }

        /*
         * Starts background thread for synchronizing with current state
         */
        private void OnLoad(object sender, EventArgs e)
        {
            syncVolume = new Thread(new ThreadStart(delegate () { SyncVolumeBackground(); }));
            syncVolume.Start();

            syncBrightness = new Thread(new ThreadStart(delegate () { SyncBrightnessBackground(); }));
            syncBrightness.Start();

            muteChecker = new System.Windows.Forms.Timer();
            muteChecker.Interval = 2000;
            muteChecker.Tick += new EventHandler(SyncMuteBackground);
            muteChecker.Start();

            rb_monitoroff.Checked = true;
        }

        /*
         * Stops all threads
         */
        private void OnDestroy(object sender, FormClosedEventArgs e)
        {
            if (syncVolume != null || syncVolume.IsAlive)
                syncVolume.Abort();

            if (syncBrightness != null || syncBrightness.IsAlive)
                syncBrightness.Abort();

            if (muteChecker != null || muteChecker.Enabled)
                muteChecker.Stop();
        }

        /*
         * Update value of application's trackbar with current volume on interval
         */
        private void SyncVolumeBackground()
        {
            CheckForIllegalCrossThreadCalls = false;

            for (;;)
            {
                float masterVolume = AudioManager.GetMasterVolume();
                lbl_volumevalue.Text = Convert.ToString((int)masterVolume);
                tb_volume.Value = (int)masterVolume;
                Thread.Sleep(500);
            }
        }

        /*
         * Update value of applications trackbar with current brightness on interval
         */
        private void SyncBrightnessBackground()
        {
            CheckForIllegalCrossThreadCalls = false;

            for (;;)
            {
                int brightness = Brightness.GetBrightness();
                lbl_brightnessvalue.Text = Convert.ToString(brightness);
                tb_brightness.Value = brightness;
                Thread.Sleep(500);
            }
        }

        /*
         *  Set current mute state for toggle 
         */
        private void SyncMuteBackground(object sender, EventArgs e)
        {
            toggle_mute.Checked = AudioManager.GetMasterVolumeMute();
        }

        /*
         * Change system volume with trackbar's value
         */
        private void VolumeScrollChanged(object sender, ScrollEventArgs e)
        {
            //AudioManager.SetMasterVolume(e.NewValue);
            Nircmd("setsysvolume " + Convert.ToString((int)(VOLUME_MAX * (e.NewValue / 100.0f))));
        }

        /*
         * Resume background volume thread
         */
        private void VolumeDragCompleted(object sender, DragEventArgs e)
        {
            syncVolume = new Thread(new ThreadStart(delegate () { SyncVolumeBackground(); }));
            syncVolume.Start();
        }

        /*
         * Stop background volume thread
         */ 
        private void VolumeDragStarted(object sender, DragEventArgs e)
        {
            if (syncVolume != null || syncVolume.IsAlive)
                syncVolume.Abort();
        }
        
        /*
         * Change system brightness with trackbar's value
         */
        private void BrightnessScrollChanged(object sender, ScrollEventArgs e)
        {
            //Brightness.SetBrightness((byte)e.NewValue);
            Nircmd("setbrightness " + Convert.ToString(e.NewValue));
        }

        /*
         * Resume background brightness thread
         */
        private void BrightnessDragCompleted(object sender, DragEventArgs e)
        {
            syncBrightness = new Thread(new ThreadStart(delegate () { SyncBrightnessBackground(); }));
            syncBrightness.Start();
        }

        /*
         * Stop background brightness thread
         */
        private void BrightnessDragStarted(object sender, DragEventArgs e)
        {
            if (syncBrightness != null || syncBrightness.IsAlive)
                syncBrightness.Abort();
        }

        /*
         *  Change system mute state
         */ 
        private void MuteToggled(object sender, EventArgs e)
        {
            //AudioManager.SetMasterVolumeMute(toggle_mute.Checked);
            string option = "";

            if (toggle_mute.Checked == true)
                option = "1";
            else
                option = "0";
                  
            Nircmd("mutesysvolume " + option);
        }

        /*
         * Execute nircmd as radio button checked
         */
        private void ExecuteButtonClicked(object sender, EventArgs e)
        {
            if (rb_monitoroff.Checked)
                Nircmd("monitor off");
            else if (rb_standbymode.Checked)
                Nircmd("standby");
            else if (rb_reboot.Checked)
                Nircmd("exitwin reboot");
            else if (rb_turnoff.Checked)
                Nircmd("exitwin poweroff");
        }
    
        /*
         * Execute nircmd program with argument
         */
        private void Nircmd(string args)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "nircmd.exe";
            p.StartInfo.Arguments = args;
            p.Start();
        }
    }
}

