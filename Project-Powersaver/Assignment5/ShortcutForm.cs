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

namespace Powersaver
{
    public partial class ShortcutForm : MetroForm
    {
        private Keys? monitorOff = null;
        private Keys? shutdown = null;

        public Keys? MonitorOff
        {
            get
            {
                return monitorOff;
            }
            set
            {
                monitorOff = value;
            }
        }

        public Keys? Shutdown
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

        public ShortcutForm()
        {
            InitializeComponent();
        }

        public void GetShortcutKeys(Keys? monitorOff, Keys? shutdown)
        {
            this.monitorOff = monitorOff;
            this.shutdown = shutdown;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (monitorOff != null)
                tb_monitoroff.Text = monitorOff.Value.ToString();

            if (shutdown != null)
                tb_shutdown.Text = shutdown.Value.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if(tb_monitoroff.Focused == true)
                {
                    tb_monitoroff.Text = keyData.ToString();
                    monitorOff = keyData;
                    return true;
                }
                else if(tb_shutdown.Focused == true)
                {
                    tb_shutdown.Text = keyData.ToString();
                    shutdown = keyData;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
