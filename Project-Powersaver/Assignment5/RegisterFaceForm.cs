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
using System.Threading;
using Assignment5.Properties;

namespace Assignment5
{
    public partial class RegisterFaceForm : MetroForm
    {
        private bool stopFrameFlag = false;
        private bool isFaceDetected = false;

        private VideoCapture camera;
        private Mat currentFrame;
        private Rect faceROI;

        private Thread frameRunner;
        private Thread progressRunner;

        private Mat registeredFace = null;

        private int gcInterval = 5;
        
        public Mat RegisteredFace
        {
            get { return registeredFace; }
        }

        public RegisterFaceForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            currentFrame = new Mat();
        }

        private void OnShown(object sender, EventArgs e)
        {
            progressRunner = new Thread(new ThreadStart(delegate () { RunProgress(); }));
            frameRunner = new Thread(new ThreadStart(delegate () { RunFrame(); }));
            progressRunner.Start();
            frameRunner.Start(); 
        }

        private void RunFrame()
        {
            CheckForIllegalCrossThreadCalls = false;

            var gcCount = 0;

            try
            {
                camera = new VideoCapture(0);
            }catch(Exception e)
            {
                MessageBox.Show("Can't execute it without camera");
                Close();
            }

            camera.FrameWidth = picb_registerface.Width;
            camera.FrameHeight = picb_registerface.Height;
            
            while (!stopFrameFlag && camera.IsOpened())
            {
                camera.Read(currentFrame);
                
                var haarCascade = new CascadeClassifier("haarcascade_frontalface_alt2.xml");
                faceROI = DetectFace(haarCascade);

                picb_registerface.ImageIpl = currentFrame;

                if (gcInterval == gcCount++)
                {
                    GC.Collect();
                    gcCount = 0;
                }

                Cv2.WaitKey(30);
            }
        }

        private Rect DetectFace(CascadeClassifier cascade)
        {
            Mat result;

            using (var src = currentFrame.Clone())
            using (var gray = new Mat())
            {
                result = src.Clone();

                if (src.Empty())
                    return new Rect(0, 0, 0, 0);
 
                Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);

                Rect[] faces = cascade.DetectMultiScale(
                    gray, 1.08, 2, HaarDetectionType.ScaleImage, new OpenCvSharp.Size(30, 30));

                if (faces.Length > 0)
                {
                    if(pb_registerface.Value != 100)
                        Cv2.Rectangle(currentFrame, faces[0], new Scalar(255, 0, 0), 3);

                    isFaceDetected = true;
                    return faces[0];
                        
                }else
                {
                    isFaceDetected = false;
                }
            }
            return new Rect(0, 0, 0, 0);          
        }

        private void RunProgress()
        {
            while (!stopFrameFlag)
            {
                Thread.Sleep(500);

                if (pb_registerface.Value == 100)
                {
                    stopFrameFlag = true;
                    RegisterFaceRoutine();
                    break;
                }

                if (!isFaceDetected)
                {
                    pb_registerface.Value = 0;                                            
                    lbl_progressrate.Text = "0%";
                }
                else
                {
                    pb_registerface.Value += 5;
                    lbl_progressrate.Text = pb_registerface.Value + "%";
                }

            }
        }

        private void RegisterFaceRoutine()
        {
            stopFrameFlag = true;

            faceROI.X -= 20;
            faceROI.Y -= 20;
            faceROI.Width += 40;
            faceROI.Height += 40;

            if (faceROI.X < 0)
                faceROI.X = 0;
            if (faceROI.Y < 0)
                faceROI.Y = 0;
            if (faceROI.X + faceROI.Width > currentFrame.Width)
                faceROI.Width = currentFrame.Width - faceROI.X - 1;
            if (faceROI.Y + faceROI.Height > currentFrame.Height)
                faceROI.Height = currentFrame.Height - faceROI.Y - 1;

            registeredFace = currentFrame.SubMat(faceROI);

            var crff = new ConfirmRegisterFaceForm(registeredFace);

            if(DialogResult.Cancel == crff.ShowDialog())
            {
                if (crff.RegisterOK)
                {
                    registeredFace = crff.RegisteredFace;
                    Close();
                }else
                {
                    registeredFace = null;
                    Close();
                }
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            stopFrameFlag = true;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            camera.Dispose();
        }
 
    }
}
