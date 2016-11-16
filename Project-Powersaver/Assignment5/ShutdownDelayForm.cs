using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Assignment5
{
    public partial class ShutdownDelayForm : MetroForm
    {
        bool shutdown = false;
        Timer delay;
        int delayCount = 15;

        public bool Shutdown
        {
            get
            {
                return shutdown;
            }
            set
            {
                shutdown = value;
            }
        }

        /* Initialize timer */
        public ShutdownDelayForm()
        {
            InitializeComponent();

            pb_shutdowndelay.Value = 100;

            delay = new Timer();
            delay.Interval = 1000;
            delay.Tick += new EventHandler(DelayAction);
            delay.Start();
           
        }

        /* Reduce delay count */
        private void DelayAction(object sender, EventArgs e)
        {
            var progressValue = ((int)((float)delayCount / 15 * 100.0f));
            if (progressValue <= 0)
                progressValue = 0;
            pb_shutdowndelay.Value = progressValue;
            lbl_alert.Text = "Shutdown in " + delayCount.ToString() + " seconds";
            delayCount--;

            if (delayCount < 0)
            {
                shutdown = true;
                Close();
            }
        }

        /* Cancel shutdown */
        private void Stop(object sender, EventArgs e)
        {
            delay.Stop();
            shutdown = false;
            Close(); 
        }

        /* Execute shutdown now */
        private void ShutdownNow(object sender, EventArgs e)
        {
            delay.Stop();
            shutdown = true;
            Close();
        }
    }
}
