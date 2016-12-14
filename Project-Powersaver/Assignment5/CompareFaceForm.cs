using System;

using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;

using OpenCvSharp;
using System.Threading;

namespace Assignment5
{
    /*
     * CompareFaceForm
     * 
     * Author   :   Doryeong Park
     * Date     :   7. 12. 2016
     * Desc     :   Form tracking area which has high concordance with face registered 
     * 
     * 
     * variables
     * faceRegistered   :   Registered face area from procedure before
     * 
     * camera           :   Object which grabs frame of each time
     * currentFrame     :   Current frame from camera object
     * faceROI          :   Face areas expressed with Rectangle coordinates 
     * 
     * frameRunner      :   Thread for capturing frame
     * gcInterval       :   Counter of interval garbage collector calling
     * 
     * percentDisplayed :   Concordance point as percent displayed on Frame
     * 
     * stopFrameFlag    :   When form's closing, the flag stops all threads for capturing
     * 
     */
    public partial class CompareFaceForm : MetroForm
    {
        private Mat faceRegistered;

        private VideoCapture camera;
        private Mat currentFrame;
        private Rect[] facesROI;

        private Thread frameRunner;
        private int gcInterval = 30;

        private int percentDisplayed = 0;

        private bool stopFrameFlag = false;

        public CompareFaceForm(Mat faceRegistered)
        {
            InitializeComponent();
            this.faceRegistered = faceRegistered;
        }

        
        private void OnLoad(object sender, EventArgs e)
        {
            if (faceRegistered == null)
                Close();

            currentFrame = new Mat();
        }
        
        /* Start capturing frame */
        private void OnShown(object sender, EventArgs e)
        {
            frameRunner = new Thread(new ThreadStart(delegate () { RunFrame(); }));
            frameRunner.Start();
        }

        /* Capturing routine */
        private void RunFrame()
        {
            CheckForIllegalCrossThreadCalls = false;

            var gcCount = 0;

            try
            {
                camera = new VideoCapture(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't execute it without camera");
                Close();
            }

            //Adjust camera resolution with component size
            camera.FrameWidth = picb_compareface.Width;
            camera.FrameHeight = picb_compareface.Height;

            while (!stopFrameFlag && camera.IsOpened())
            {
                camera.Read(currentFrame);

                var haarCascade = new CascadeClassifier("haarcascade_frontalface_alt2.xml");
                facesROI = DetectFaces(haarCascade);

                //Get the highest concordance area and display it
                Compare();

                //Display frame
                picb_compareface.ImageIpl = currentFrame;

                if (gcInterval == gcCount++)
                {
                    GC.Collect();
                    gcCount = 0;
                }

                Cv2.WaitKey(30);
            }
        }

        /* Detect all candidates which are regarded as face area */
        private Rect[] DetectFaces(CascadeClassifier cascade)
        {
            Mat result;

            using (var src = currentFrame.Clone())
            using (var gray = new Mat())
            {
                result = src.Clone();
                if (src.Empty())
                    return null;

                Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);

                Rect[] faces = cascade.DetectMultiScale(
                    gray, 1.08, 2, HaarDetectionType.ScaleImage, new OpenCvSharp.Size(30, 30));

                if (faces.Length > 0)
                    return faces;
            }
            return null;
        }


        /* Pick elect which concordance is the highest and display it */
        private void Compare()
        {
            if (facesROI == null || facesROI.Length == 0)
                return;

            var result = 0.0;
            var percent = 0.0;

            var right = 0;
            var left = 0;
            var top = 0;

            for (int i = 0; i < facesROI.Length; ++i)
            {
                
                Mat corrMat = new Mat(new OpenCvSharp.Size(41, 41), MatType.CV_32FC1);
                var candidate = currentFrame.SubMat(facesROI[i]);
                
                //Scaling same size with registered face - 20
                Cv2.Resize(candidate, candidate,
                new OpenCvSharp.Size(faceRegistered.Width - 40, faceRegistered.Height - 40),
                0, 0, InterpolationFlags.Linear);

                //Make correlation map[0 ~ 1.0]
                Cv2.MatchTemplate(faceRegistered, candidate, corrMat, TemplateMatchModes.CCoeffNormed);

                double max = 0;
                double min = 0;

                //Extract Maximum point
                corrMat.MinMaxLoc(out min, out max);

                if (max < 0.6)
                    continue;
                
                //Changes maximum concordance area
                if (result < max)
                {
                    result = max;
                    percent = (int)(max * 100.0);

                    right = facesROI[i].Right;
                    left = facesROI[i].Left;
                    top = facesROI[i].Top;
                }

                //Display concordance > 70%
                if (percent >= 70)
                {
                    percentDisplayed = (int)percent;
                }

            }

            //Drawing routines with coordinates
            Cv2.PutText(currentFrame, percentDisplayed + "%",
                new OpenCvSharp.Point((right + left) / 2 - 15, (top - 50)),
                HersheyFonts.HersheyPlain,
                1.5, new Scalar(0, 255, 0), 3);


            Cv2.Line(currentFrame,
                new OpenCvSharp.Point((right + left) / 2 + 5, top - 25),
                new OpenCvSharp.Point((right + left) / 2 + 5, top - 10),
                new Scalar(0, 0, 200),
                4
            );

            Cv2.Line(currentFrame,
                new OpenCvSharp.Point((right + left) / 2 + 5, top - 10),
                new OpenCvSharp.Point((right + left) / 2 + 5 - 5, top - 10 - 5),
                new Scalar(0, 0, 200),
                4
            );

            Cv2.Line(currentFrame,
                new OpenCvSharp.Point((right + left) / 2 + 5, top - 5),
                new OpenCvSharp.Point((right + left) / 2 + 5 + 5, top - 10 - 5),
                new Scalar(0, 0, 200),
                4
            );
        }

        /* Dispose camera object */
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            camera.Dispose();
        }

        /* Groundwork to close form */
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            stopFrameFlag = true;
        }
    }
}
