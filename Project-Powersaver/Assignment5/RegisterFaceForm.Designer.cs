namespace Assignment5
{
    partial class RegisterFaceForm
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
            this.picb_registerface = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.lbl_registerface = new System.Windows.Forms.Label();
            this.pb_registerface = new MetroFramework.Controls.MetroProgressBar();
            this.lbl_registerprogress = new System.Windows.Forms.Label();
            this.lbl_progressrate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picb_registerface)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_registerface
            // 
            this.picb_registerface.BackColor = System.Drawing.Color.White;
            this.picb_registerface.Location = new System.Drawing.Point(44, 88);
            this.picb_registerface.Name = "picb_registerface";
            this.picb_registerface.Size = new System.Drawing.Size(683, 395);
            this.picb_registerface.TabIndex = 0;
            this.picb_registerface.TabStop = false;
            // 
            // lbl_registerface
            // 
            this.lbl_registerface.AutoSize = true;
            this.lbl_registerface.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_registerface.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_registerface.Location = new System.Drawing.Point(152, 32);
            this.lbl_registerface.Name = "lbl_registerface";
            this.lbl_registerface.Size = new System.Drawing.Size(470, 38);
            this.lbl_registerface.TabIndex = 1;
            this.lbl_registerface.Text = "Powersaver is detecting your face";
            // 
            // pb_registerface
            // 
            this.pb_registerface.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.pb_registerface.Location = new System.Drawing.Point(44, 533);
            this.pb_registerface.Name = "pb_registerface";
            this.pb_registerface.Size = new System.Drawing.Size(595, 23);
            this.pb_registerface.Style = MetroFramework.MetroColorStyle.Blue;
            this.pb_registerface.TabIndex = 2;
            this.pb_registerface.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_registerprogress
            // 
            this.lbl_registerprogress.AutoSize = true;
            this.lbl_registerprogress.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_registerprogress.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_registerprogress.Location = new System.Drawing.Point(42, 504);
            this.lbl_registerprogress.Name = "lbl_registerprogress";
            this.lbl_registerprogress.Size = new System.Drawing.Size(70, 20);
            this.lbl_registerprogress.TabIndex = 1;
            this.lbl_registerprogress.Text = "Progress";
            // 
            // lbl_progressrate
            // 
            this.lbl_progressrate.AutoSize = true;
            this.lbl_progressrate.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_progressrate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_progressrate.Location = new System.Drawing.Point(669, 521);
            this.lbl_progressrate.Name = "lbl_progressrate";
            this.lbl_progressrate.Size = new System.Drawing.Size(58, 38);
            this.lbl_progressrate.TabIndex = 1;
            this.lbl_progressrate.Text = "0%";
            // 
            // RegisterFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 583);
            this.Controls.Add(this.pb_registerface);
            this.Controls.Add(this.lbl_registerprogress);
            this.Controls.Add(this.lbl_progressrate);
            this.Controls.Add(this.lbl_registerface);
            this.Controls.Add(this.picb_registerface);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterFaceForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this.picb_registerface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl picb_registerface;
        private System.Windows.Forms.Label lbl_registerface;
        private MetroFramework.Controls.MetroProgressBar pb_registerface;
        private System.Windows.Forms.Label lbl_registerprogress;
        private System.Windows.Forms.Label lbl_progressrate;
    }
}