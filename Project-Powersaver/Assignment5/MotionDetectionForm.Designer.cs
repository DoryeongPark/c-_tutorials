namespace Assignment5
{
    partial class MotionDetectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picb_motiondetection = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.tb_compareface = new MetroFramework.Controls.MetroTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picb_motiondetection)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_motiondetection
            // 
            this.picb_motiondetection.Location = new System.Drawing.Point(73, 86);
            this.picb_motiondetection.Name = "picb_motiondetection";
            this.picb_motiondetection.Size = new System.Drawing.Size(625, 380);
            this.picb_motiondetection.TabIndex = 0;
            this.picb_motiondetection.TabStop = false;
            // 
            // tb_compareface
            // 
            this.tb_compareface.BackColor = System.Drawing.Color.Transparent;
            this.tb_compareface.Location = new System.Drawing.Point(74, 516);
            this.tb_compareface.Name = "tb_compareface";
            this.tb_compareface.Size = new System.Drawing.Size(625, 23);
            this.tb_compareface.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_compareface.TabIndex = 1;
            this.tb_compareface.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MotionDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 569);
            this.Controls.Add(this.tb_compareface);
            this.Controls.Add(this.picb_motiondetection);
            this.Name = "MotionDetectionForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this.picb_motiondetection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl picb_motiondetection;
        private MetroFramework.Controls.MetroTrackBar tb_compareface;
    }
}