namespace Assignment5
{
    partial class RegisterIdForm
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
            this.components = new System.ComponentModel.Container();
            this.sm_registeridform = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lbl_registerid = new MetroFramework.Controls.MetroLabel();
            this.tb_registerid = new MetroFramework.Controls.MetroTextBox();
            this.btn_register = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.sm_registeridform)).BeginInit();
            this.SuspendLayout();
            // 
            // sm_registeridform
            // 
            this.sm_registeridform.Owner = this;
            this.sm_registeridform.Style = MetroFramework.MetroColorStyle.Lime;
            this.sm_registeridform.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_registerid
            // 
            this.lbl_registerid.AutoSize = true;
            this.lbl_registerid.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_registerid.Location = new System.Drawing.Point(23, 30);
            this.lbl_registerid.Name = "lbl_registerid";
            this.lbl_registerid.Size = new System.Drawing.Size(93, 20);
            this.lbl_registerid.TabIndex = 0;
            this.lbl_registerid.Text = "Input your id";
            // 
            // tb_registerid
            // 
            // 
            // 
            // 
            this.tb_registerid.CustomButton.Image = null;
            this.tb_registerid.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.tb_registerid.CustomButton.Name = "";
            this.tb_registerid.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tb_registerid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_registerid.CustomButton.TabIndex = 1;
            this.tb_registerid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_registerid.CustomButton.UseSelectable = true;
            this.tb_registerid.CustomButton.Visible = false;
            this.tb_registerid.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_registerid.Lines = new string[0];
            this.tb_registerid.Location = new System.Drawing.Point(23, 63);
            this.tb_registerid.MaxLength = 15;
            this.tb_registerid.Name = "tb_registerid";
            this.tb_registerid.PasswordChar = '\0';
            this.tb_registerid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_registerid.SelectedText = "";
            this.tb_registerid.SelectionLength = 0;
            this.tb_registerid.SelectionStart = 0;
            this.tb_registerid.ShortcutsEnabled = true;
            this.tb_registerid.Size = new System.Drawing.Size(180, 30);
            this.tb_registerid.TabIndex = 1;
            this.tb_registerid.UseSelectable = true;
            this.tb_registerid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_registerid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(23, 113);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(93, 23);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register";
            this.btn_register.UseSelectable = true;
            this.btn_register.Click += new System.EventHandler(this.RegisterId);
            // 
            // RegisterIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 159);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_registerid);
            this.Controls.Add(this.lbl_registerid);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterIdForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.sm_registeridform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager sm_registeridform;
        private MetroFramework.Controls.MetroButton btn_register;
        private MetroFramework.Controls.MetroTextBox tb_registerid;
        private MetroFramework.Controls.MetroLabel lbl_registerid;
    }
}