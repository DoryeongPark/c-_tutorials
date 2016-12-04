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

namespace Assignment5
{
    public partial class CompareFaceForm : MetroForm
    {
        private Mat faceRegistered;

        private VideoCapture camera;
        private Mat currentFrame;
        private Rect[] facesROI;

        private Thread frameRunner;
        private int gcInterval = 5;

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

        private void OnShown(object sender, EventArgs e)
        {
            frameRunner = new Thread(new ThreadStart(delegate () { RunFrame(); }));
            frameRunner.Start();
        }

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

            camera.FrameWidth = picb_compareface.Width;
            camera.FrameHeight = picb_compareface.Height;

            while (!stopFrameFlag && camera.IsOpened())
            {
                camera.Read(currentFrame);

                var haarCascade = new CascadeClassifier("haarcascade_frontalface_alt2.xml");
                facesROI = DetectFaces(haarCascade);

                Compare();

                picb_compareface.ImageIpl = currentFrame;

                if (gcInterval == gcCount++)
                {
                    GC.Collect();
                    gcCount = 0;
                }

                Cv2.WaitKey(30);
            }
        }

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
                Cv2.Resize(candidate, candidate,
                new OpenCvSharp.Size(faceRegistered.Width - 40, faceRegistered.Height - 40),
                0, 0, InterpolationFlags.Linear);
                Cv2.MatchTemplate(faceRegistered, candidate, corrMat, TemplateMatchModes.CCoeffNormed);

                double max = 0;
                double min = 0;

                corrMat.MinMaxLoc(out min, out max);

                if (max < 0.6)
                    continue;

                if (result < max)
                {
                    result = max;
                    percent = (int)(max * 100.0);

                    right = facesROI[i].Right;
                    left = facesROI[i].Left;
                    top = facesROI[i].Top;
                }

                if (percent >= 70)
                {
                    percentDisplayed = (int)percent;
                }

            }

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

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            camera.Dispose();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            stopFrameFlag = true;
        }
    }
}
