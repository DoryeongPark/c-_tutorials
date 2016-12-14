namespace Assignment5
{
    partial class CompareFaceForm
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
            this.picb_compareface = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.lbl_compareface = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picb_compareface)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_compareface
            // 
            this.picb_compareface.Location = new System.Drawing.Point(50, 98);
            this.picb_compareface.Name = "picb_compareface";
            this.picb_compareface.Size = new System.Drawing.Size(740, 400);
            this.picb_compareface.TabIndex = 0;
            this.picb_compareface.TabStop = false;
            // 
            // lbl_compareface
            // 
            this.lbl_compareface.AutoSize = true;
            this.lbl_compareface.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_compareface.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_compareface.Location = new System.Drawing.Point(45, 43);
            this.lbl_compareface.Name = "lbl_compareface";
            this.lbl_compareface.Size = new System.Drawing.Size(312, 28);
            this.lbl_compareface.TabIndex = 3;
            this.lbl_compareface.Text = "Powersaver is finding your face";
            // 
            // CompareFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 536);
            this.Controls.Add(this.lbl_compareface);
            this.Controls.Add(this.picb_compareface);
            this.MaximizeBox = false;
            this.Name = "CompareFaceForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this.picb_compareface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl picb_compareface;
        private System.Windows.Forms.Label lbl_compareface;
    }
}