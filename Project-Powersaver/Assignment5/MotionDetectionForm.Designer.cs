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
            this.lbl_motiondetection = new System.Windows.Forms.Label();
            this.lbl_sensitivity = new System.Windows.Forms.Label();
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
            this.tb_compareface.Location = new System.Drawing.Point(73, 516);
            this.tb_compareface.Name = "tb_compareface";
            this.tb_compareface.Size = new System.Drawing.Size(561, 23);
            this.tb_compareface.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_compareface.TabIndex = 1;
            this.tb_compareface.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tb_compareface.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OnScroll);
            // 
            // lbl_motiondetection
            // 
            this.lbl_motiondetection.AutoSize = true;
            this.lbl_motiondetection.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_motiondetection.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_motiondetection.Location = new System.Drawing.Point(69, 39);
            this.lbl_motiondetection.Name = "lbl_motiondetection";
            this.lbl_motiondetection.Size = new System.Drawing.Size(174, 28);
            this.lbl_motiondetection.TabIndex = 2;
            this.lbl_motiondetection.Text = "Motion Detected";
            // 
            // lbl_sensitivity
            // 
            this.lbl_sensitivity.AutoSize = true;
            this.lbl_sensitivity.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_sensitivity.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_sensitivity.Location = new System.Drawing.Point(662, 511);
            this.lbl_sensitivity.Name = "lbl_sensitivity";
            this.lbl_sensitivity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_sensitivity.Size = new System.Drawing.Size(36, 28);
            this.lbl_sensitivity.TabIndex = 2;
            this.lbl_sensitivity.Text = "50";
            // 
            // MotionDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 569);
            this.Controls.Add(this.lbl_sensitivity);
            this.Controls.Add(this.lbl_motiondetection);
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
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl picb_motiondetection;
        private MetroFramework.Controls.MetroTrackBar tb_compareface;
        private System.Windows.Forms.Label lbl_motiondetection;
        private System.Windows.Forms.Label lbl_sensitivity;
    }
}