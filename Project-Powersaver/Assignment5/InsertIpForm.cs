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

        public string IP {
            get
            {
                return ip;
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
               
            Close();
            
        }

        private void CancelButtonClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}
