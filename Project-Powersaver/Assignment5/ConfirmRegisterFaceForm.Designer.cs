namespace Assignment5
{
    partial class ConfirmRegisterFaceForm
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
            this.lbl_confirmregisterface = new System.Windows.Forms.Label();
            this.button_registerfaceok = new MetroFramework.Controls.MetroButton();
            this.btn_registerfacecancel = new MetroFramework.Controls.MetroButton();
            this.picb_confirmregister = new OpenCvSharp.UserInterface.PictureBoxIpl();
            ((System.ComponentModel.ISupportInitialize)(this.picb_confirmregister)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_confirmregisterface
            // 
            this.lbl_confirmregisterface.AutoSize = true;
            this.lbl_confirmregisterface.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_confirmregisterface.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_confirmregisterface.Location = new System.Drawing.Point(23, 39);
            this.lbl_confirmregisterface.Name = "lbl_confirmregisterface";
            this.lbl_confirmregisterface.Size = new System.Drawing.Size(257, 20);
            this.lbl_confirmregisterface.TabIndex = 2;
            this.lbl_confirmregisterface.Text = "Do you want to register your face?";
            // 
            // button_registerfaceok
            // 
            this.button_registerfaceok.Location = new System.Drawing.Point(317, 39);
            this.button_registerfaceok.Name = "button_registerfaceok";
            this.button_registerfaceok.Size = new System.Drawing.Size(75, 23);
            this.button_registerfaceok.Style = MetroFramework.MetroColorStyle.Blue;
            this.button_registerfaceok.TabIndex = 3;
            this.button_registerfaceok.Text = "OK";
            this.button_registerfaceok.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_registerfaceok.UseSelectable = true;
            this.button_registerfaceok.Click += new System.EventHandler(this.OnOKButtonClicked);
            // 
            // btn_registerfacecancel
            // 
            this.btn_registerfacecancel.Location = new System.Drawing.Point(407, 39);
            this.btn_registerfacecancel.Name = "btn_registerfacecancel";
            this.btn_registerfacecancel.Size = new System.Drawing.Size(75, 23);
            this.btn_registerfacecancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_registerfacecancel.TabIndex = 3;
            this.btn_registerfacecancel.Text = "Cancel";
            this.btn_registerfacecancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_registerfacecancel.UseSelectable = true;
            this.btn_registerfacecancel.Click += new System.EventHandler(this.OnCancelButtonClicked);
            // 
            // picb_confirmregister
            // 
            this.picb_confirmregister.Location = new System.Drawing.Point(130, 96);
            this.picb_confirmregister.Name = "picb_confirmregister";
            this.picb_confirmregister.Size = new System.Drawing.Size(255, 255);
            this.picb_confirmregister.TabIndex = 4;
            this.picb_confirmregister.TabStop = false;
            // 
            // ConfirmRegisterFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 398);
            this.Controls.Add(this.picb_confirmregister);
            this.Controls.Add(this.btn_registerfacecancel);
            this.Controls.Add(this.button_registerfaceok);
            this.Controls.Add(this.lbl_confirmregisterface);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmRegisterFaceForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.picb_confirmregister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_confirmregisterface;
        private MetroFramework.Controls.MetroButton button_registerfaceok;
        private MetroFramework.Controls.MetroButton btn_registerfacecancel;
        private OpenCvSharp.UserInterface.PictureBoxIpl picb_confirmregister;
    }
}