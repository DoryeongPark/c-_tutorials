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
    public partial class RegisterIdForm : MetroForm
    {
        public RegisterIdForm()
        {
            InitializeComponent();
        }

        private string id;
        private bool isRegistered = false;

        public bool IsRegistered
        {
            get { return isRegistered; }
            set { value = isRegistered; }
        }

        public string Id
        {
            get{ return id; }
            set{ value = id; }
        }

        private void RegisterId(object sender, EventArgs e)
        {
            id = tb_registerid.Text;
            isRegistered = true;
            Close();
        }
    }
}
