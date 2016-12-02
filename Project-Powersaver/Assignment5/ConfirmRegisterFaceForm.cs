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

using OpenCvSharp;

namespace Assignment5
{
    public partial class ConfirmRegisterFaceForm : MetroForm
    {
        private Mat capturedFace;

        private bool registerOK = false;

        public bool RegisterOK
        {
            get { return registerOK; }
            set { registerOK = value;  }
        }

        public Mat RegisteredFace
        {
            get { return capturedFace;  }
            set { capturedFace = value; }
        }
       
   
        public ConfirmRegisterFaceForm(Mat capturedFace)
        {
            InitializeComponent();
            Cv2.Resize(capturedFace, capturedFace, 
                new OpenCvSharp.Size(picb_confirmregister.Width, picb_confirmregister.Height), 
                0, 0, InterpolationFlags.Linear);
            
            this.capturedFace = capturedFace;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            picb_confirmregister.ImageIpl = capturedFace;
        }

        private void OnOKButtonClicked(object sender, EventArgs e)
        {
            registerOK = true;
            Close();
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            capturedFace = null; 
            Close();
        }
    }
}
