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
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.InteropServices;

namespace Powersaver
{
    
    public partial class Powersaver : MetroForm
    {

        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MONITORPOWER = 0xF170;

        private const int MONITOR_ON = -1;
        private const int MONITOR_OFF = 2;
        private const int MONITOR_STANBY = 1;

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        private Thread timer;

        public Powersaver()
        {
            InitializeComponent();
        }

        private void Powersaver_Load(object sender, EventArgs e)
        {
       
        }

        private void MonitorPowerSaveButtonClicked(object sender, EventArgs e)
        {
            
            SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_STANBY);
        }

        private void MonitorOffButtonClicked(object sender, EventArgs e)
        {
            if (tb_min.Text == "" && tb_sec.Text == "")
                SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
            else
            {
                if (timer != null && timer.IsAlive == true)
                    timer.Abort();

                this.timer = new Thread(new ThreadStart(this.ExecuteTimer));
                timer.Start();
            }

        }
        private void SystemSuspendButtonClicked(object sender, MouseEventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, false, false);
        }
     
        private void SystemHibernateButtonClicked(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, false, false);
        }

        private void InputReservationTime(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void ExecuteTimer()
        {

            CheckForIllegalCrossThreadCalls = false;

            int min, sec, timer;

            if (tb_min.Text == "")
                min = 0;
            else
                min = int.Parse(tb_min.Text);

            if (tb_sec.Text == "")
                sec = 0;
            else
                sec = int.Parse(tb_sec.Text);
            
            timer = min * 60 + sec;
            float maxValue = timer;

            for (;;)
            {
            
                if (timer == 0)
                    break;

                float debug = (1.0f - (timer / maxValue));
                --timer;
                pb_reservation.Value = ((int)((1.0f - (timer / maxValue)) * 100.0f));
                Thread.Sleep(1000);

            }
        }

    }
}
