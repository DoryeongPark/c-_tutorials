using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class InsertIpForm : MetroForm
    {

        private string ip = null;
        private int portNum = 0;

        public string IP {
            get
            {
                return ip;
            }
        }

        public int PortNumber
        {
            get
            {
                return portNum;
            }
        }

        public InsertIpForm()
        {
            InitializeComponent();
        }

        private void OKButtonClicked(object sender, EventArgs e)
        {
            IPAddress ipForTest;
            ip = tb_ip.Text;

            if(IPAddress.TryParse(ip, out ipForTest) == false)
            {
                MessageBox.Show("Input correct IP");
                ip = null;
                return;
            }
                

            try
            {
                portNum = int.Parse(tb_port.Text);
            }catch(Exception exception)
            {
                MessageBox.Show("Input correct port number");
                return;
            }

            Close();
            
        }

        private void CancelButtonClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}
