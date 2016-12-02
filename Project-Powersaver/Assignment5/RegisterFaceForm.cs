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
        private bool StopFrameFlag = false;
        private bool isFaceDetected = false;

        private VideoCapture camera;
        private Mat currentFrame;
        private Rect faceROI;

        private Thread frameRunner;
        private Thread progressRunner;

        private Mat capturedFace = null;

        private int gcInterval = 5;

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

            Mat previousFrame = new Mat();
            var gcCount = 0;

            try
            {
                camera = new VideoCapture(0);
            }catch(Exception e)
            {
                MessageBox.Show("Can't execute it without camera");
                Close();
            }

            while (!StopFrameFlag && camera.IsOpened())
            {
                camera.Read(currentFrame);
                
                var haarCascade = new CascadeClassifier("haarcascade_frontalface_alt.xml");
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
            while (!StopFrameFlag)
            {
                Thread.Sleep(500);

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

                if(pb_registerface.Value == 100)
                {
                    StopFrameFlag = true;
                    RegisterFaceRoutine();
                    break;
                }

            }
        }

        private void RegisterFaceRoutine()
        {
            StopFrameFlag = true;
            capturedFace = currentFrame.SubMat(faceROI);
            var crff = new ConfirmRegisterFaceForm(capturedFace);

            if(DialogResult.Cancel == crff.ShowDialog())
            {
                if (crff.RegisterOK)
                {
                    Settings.Default.faceRegistered = crff.CapturedFace;
                    Settings.Default.Save();
                    Close();
                }else
                {
                    capturedFace = null;
                    Close();
                }
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            StopFrameFlag = true;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            camera.Dispose();
        }
 
    }
}
