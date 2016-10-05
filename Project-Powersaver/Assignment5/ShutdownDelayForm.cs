using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public ShutdownDelayForm()
        {
            InitializeComponent();

            pb_shutdowndelay.Value = 100;

            delay = new Timer();
            delay.Interval = 1000;
            delay.Tick += new EventHandler(DelayAction);
            delay.Start();
           
        }

        private void DelayAction(object sender, EventArgs e)
        {
            pb_shutdowndelay.Value = ((int)((float)delayCount / 15 * 100.0f));
            lbl_alert.Text = "Shutdown in " + delayCount.ToString() + " seconds";
            delayCount--;

            if (delayCount == 0)
            {
                shutdown = true;
                Close();
            }
        }

        private void Stop(object sender, EventArgs e)
        {
            delay.Stop();
            shutdown = false;
            Close(); 
        }

        private void ShutdownNow(object sender, EventArgs e)
        {
            delay.Stop();
            shutdown = true;
            Close();
        }
    }
}
