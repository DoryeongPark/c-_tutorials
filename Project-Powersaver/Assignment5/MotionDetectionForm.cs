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
using System.Threading;

using OpenCvSharp;

namespace Assignment5
{
    public partial class MotionDetectionForm : MetroForm
    {
        
        private Thread frameRunner;
        private VideoCapture camera;

        private Mat currentFrame;
        private Mat previousFrame;

        private bool stopFrameFlag = false;

        private int gcInterval = 5;
        private int gcCounter = 0;

        public MotionDetectionForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
                      
        }
        
        private void RunFrame()
        {
            CheckForIllegalCrossThreadCalls = false;

            camera = new VideoCapture(0);

            camera.FrameWidth = picb_motiondetection.Width;
            camera.FrameHeight = picb_motiondetection.Height;
            
            while (!stopFrameFlag)
            {
                camera.Read(currentFrame);
                picb_motiondetection.ImageIpl = currentFrame;
                
                if(gcCounter++ == gcInterval)
                {
                    GC.Collect();
                    gcCounter = 0;
                }

                Cv2.WaitKey(20);
                   
            }
        }

        private void OnShown(object sender, EventArgs e)
        {
            currentFrame = new Mat();
            frameRunner = new Thread(new ThreadStart(delegate () { RunFrame(); }));
            frameRunner.Start();
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
