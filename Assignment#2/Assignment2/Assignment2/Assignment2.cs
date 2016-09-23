using System;
using System.Windows.Forms;
using VideoPlayerController;
using System.Threading;
using System.Diagnostics;
using MetroFramework;
using MetroFramework.Forms;

namespace Assignment2
{
    public partial class Assignment2 : MetroForm
    {
        private Thread SyncVolume;
        private Thread SyncBrightness;
        private System.Windows.Forms.Timer MuteChecker;
        private const float VOLUME_MAX = 65535;

        public Assignment2()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            SyncVolume = new Thread(new ThreadStart(delegate () { SyncVolumeBackground(); }));
            SyncVolume.Start();

            SyncBrightness = new Thread(new ThreadStart(delegate () { SyncBrightnessBackground(); }));
            SyncBrightness.Start();

            MuteChecker = new System.Windows.Forms.Timer();
            MuteChecker.Interval = 2000;
            MuteChecker.Tick += new EventHandler(SyncMuteBackground);
            MuteChecker.Start();

            rb_monitoroff.Checked = true;
        }

        private void OnDestroy(object sender, FormClosedEventArgs e)
        {
            if (SyncVolume != null || SyncVolume.IsAlive)
                SyncVolume.Abort();

            if (SyncBrightness != null || SyncBrightness.IsAlive)
                SyncBrightness.Abort();

            if (MuteChecker != null || MuteChecker.Enabled)
                MuteChecker.Stop();
        }

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

        private void SyncMuteBackground(object sender, EventArgs e)
        {
            toggle_mute.Checked = AudioManager.GetMasterVolumeMute();
        }

        
        private void VolumeScrollChanged(object sender, ScrollEventArgs e)
        {
            //AudioManager.SetMasterVolume(e.NewValue);
            Nircmd("setsysvolume " + Convert.ToString((int)(VOLUME_MAX * (e.NewValue / 100.0f))));
        }

        private void VolumeDragCompleted(object sender, DragEventArgs e)
        {
            SyncVolume = new Thread(new ThreadStart(delegate () { SyncVolumeBackground(); }));
            SyncVolume.Start();
        }

        private void VolumeDragStarted(object sender, DragEventArgs e)
        {
            if (SyncVolume != null || SyncVolume.IsAlive)
                SyncVolume.Abort();
        }

        private void BrightnessScrollChanged(object sender, ScrollEventArgs e)
        {
            //Brightness.SetBrightness((byte)e.NewValue);
            Nircmd("setbrightness " + Convert.ToString(e.NewValue));
        }

        private void BrightnessDragCompleted(object sender, DragEventArgs e)
        {
            SyncBrightness = new Thread(new ThreadStart(delegate () { SyncBrightnessBackground(); }));
            SyncBrightness.Start();
        }

        private void BrightnessDragStarted(object sender, DragEventArgs e)
        {
            if (SyncBrightness != null || SyncBrightness.IsAlive)
                SyncBrightness.Abort();
        }

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

