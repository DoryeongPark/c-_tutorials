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

    /*
     *  MotionDetectionForm
     *  
     *  Author  :   Doryeong Park
     *  Date    :   13. 12. 2016
     *  Desc    :   Form detecting motion in capturing through differance between previoius frame
     *  
     *  
     *  variables
     *  
     *  frameRunner     :   Thread for capturing frame
     *  camera          :   Object which grabs frame of each time
     *  
     *  currentFrame    :   Current frame from camera object
     *  posterizedFrame :   8-level posterized frame
     *  previousFrame   :   Previous posterized frame
     *  resultFrame     :   Frame displayed as result of differance 
     *  
     *  userSensitivity :   Critical point determining motion
     *  
     *  stopFrameFlag   :   When form's closing, the flag stops all threads for capturing
     *  
     *  gcInterval      :   Counter of interval garbage collector calling
     */
    public partial class MotionDetectionForm : MetroForm
    {
        
        private Thread frameRunner;
        private VideoCapture camera;

        private Mat currentFrame;
        private Mat posterizedFrame;
        private Mat previousFrame;
        private Mat resultFrame;

        private int userSensitivity = 5000;     // min: 500 - default: 5000 - max: 9500

        private bool stopFrameFlag = false;

        private int gcInterval = 30;

        public MotionDetectionForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            lbl_motiondetection.Hide();
            lbl_sensitivity.Text = "50";               
        }
        
        /* Capturing routine */
        private void RunFrame()
        {
            CheckForIllegalCrossThreadCalls = false;

            var gcCounter = 0;
            camera = new VideoCapture(0);

            camera.FrameWidth = picb_motiondetection.Width;
            camera.FrameHeight = picb_motiondetection.Height;
            
            while (!stopFrameFlag)
            {
                camera.Read(currentFrame);
                Cv2.CvtColor(currentFrame, posterizedFrame, ColorConversionCodes.BGR2GRAY);
                EightLevelPosterizing();

                //Make differance between current frame and previous frame
                resultFrame = posterizedFrame - previousFrame;

                //Determine motion state of frame 
                lbl_motiondetection.Visible = DetermineMotionState();
                
                picb_motiondetection.ImageIpl = resultFrame;
                
                //Save current frame as previousFrame
                posterizedFrame.CopyTo(previousFrame);

                if (gcCounter++ == gcInterval)
                {
                    GC.Collect();
                    gcCounter = 0;
                }
    
                Cv2.WaitKey(20);
                   
            }
        }

        /* Classify 8 scopes and map various pixel values to 8 values */
        private void EightLevelPosterizing()
        {
            var indexer = posterizedFrame.GetGenericIndexer<byte>();

            for (int i = 0; i < posterizedFrame.Height; ++i)
                for (int j = 0; j < posterizedFrame.Width; ++j)
                {
                    var pixelVal = indexer[i, j];
                    if (0 <= pixelVal && pixelVal < 32)
                        indexer[i, j] = 0;
                    else if (32 <= pixelVal && pixelVal < 64)
                        indexer[i, j] = 32;
                    else if (64 <= pixelVal && pixelVal < 96)
                        indexer[i, j] = 64;
                    else if (96 <= pixelVal && pixelVal < 128)
                        indexer[i, j] = 96;
                    else if (128 <= pixelVal && pixelVal < 160)
                        indexer[i, j] = 128;
                    else if (160 <= pixelVal && pixelVal < 192)
                        indexer[i, j] = 160;
                    else if (224 <= pixelVal && pixelVal <= 255)
                        indexer[i, j] = 224;             
                }            
        }

        /* Determine whether motion's detected in result frame or not */
        private bool DetermineMotionState()
        {
            var indexer = resultFrame.GetGenericIndexer<byte>();
            var determiningPoint = 0;
            
            for(int i = 0; i < resultFrame.Height; ++i)
            {
                for(int j = 0; j < resultFrame.Width; ++j)
                {
                    if (indexer[i, j] > 32)
                        ++determiningPoint;
                    else
                        indexer[i, j] = 0;
                }
            }
            
            //If number of motion pixel value is bigger than user sensitiviy 
            if (determiningPoint >= userSensitivity)
                return true;
            else
                return false;
   
        }

        private void OnShown(object sender, EventArgs e)
        {
            currentFrame = new Mat();
            previousFrame = new Mat();
            posterizedFrame = new Mat();
            resultFrame = new Mat();
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

        /* Manipulate user sensitivity with trackbar */
        private void OnScroll(object sender, ScrollEventArgs e)
        {
            userSensitivity = 500 + (int)(9000.0f * ((100-(float)e.NewValue) / 100.0f));
            lbl_sensitivity.Text = e.NewValue.ToString();
        }
    }
}
