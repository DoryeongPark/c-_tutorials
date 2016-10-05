namespace Assignment5
{
    partial class ShutdownDelayForm
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
            this.lbl_shutdowndelay = new MetroFramework.Controls.MetroLabel();
            this.sm_shutdowndelayform = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pb_shutdowndelay = new MetroFramework.Controls.MetroProgressBar();
            this.btn_shutdowndelaystop = new MetroFramework.Controls.MetroButton();
            this.lbl_alert = new MetroFramework.Controls.MetroLabel();
            this.btn_shutdowndelayshutdownnow = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.sm_shutdowndelayform)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_shutdowndelay
            // 
            this.lbl_shutdowndelay.AutoSize = true;
            this.lbl_shutdowndelay.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_shutdowndelay.Location = new System.Drawing.Point(14, 40);
            this.lbl_shutdowndelay.Name = "lbl_shutdowndelay";
            this.lbl_shutdowndelay.Size = new System.Drawing.Size(340, 20);
            this.lbl_shutdowndelay.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbl_shutdowndelay.TabIndex = 0;
            this.lbl_shutdowndelay.Text = "Powersaver is ready to shutdown your compter";
            this.lbl_shutdowndelay.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // sm_shutdowndelayform
            // 
            this.sm_shutdowndelayform.Owner = this;
            // 
            // pb_shutdowndelay
            // 
            this.pb_shutdowndelay.Location = new System.Drawing.Point(16, 73);
            this.pb_shutdowndelay.Name = "pb_shutdowndelay";
            this.pb_shutdowndelay.Size = new System.Drawing.Size(412, 23);
            this.pb_shutdowndelay.Style = MetroFramework.MetroColorStyle.Lime;
            this.pb_shutdowndelay.TabIndex = 1;
            this.pb_shutdowndelay.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_shutdowndelaystop
            // 
            this.btn_shutdowndelaystop.Location = new System.Drawing.Point(14, 115);
            this.btn_shutdowndelaystop.Name = "btn_shutdowndelaystop";
            this.btn_shutdowndelaystop.Size = new System.Drawing.Size(107, 23);
            this.btn_shutdowndelaystop.TabIndex = 2;
            this.btn_shutdowndelaystop.Text = "Stop";
            this.btn_shutdowndelaystop.UseSelectable = true;
            this.btn_shutdowndelaystop.Click += new System.EventHandler(this.Stop);
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_alert.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_alert.Location = new System.Drawing.Point(261, 121);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(157, 17);
            this.lbl_alert.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbl_alert.TabIndex = 0;
            this.lbl_alert.Text = "Shutdown in 15 seconds";
            this.lbl_alert.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_shutdowndelayshutdownnow
            // 
            this.btn_shutdowndelayshutdownnow.Location = new System.Drawing.Point(136, 115);
            this.btn_shutdowndelayshutdownnow.Name = "btn_shutdowndelayshutdownnow";
            this.btn_shutdowndelayshutdownnow.Size = new System.Drawing.Size(107, 23);
            this.btn_shutdowndelayshutdownnow.TabIndex = 2;
            this.btn_shutdowndelayshutdownnow.Text = "Shutdown now";
            this.btn_shutdowndelayshutdownnow.UseSelectable = true;
            this.btn_shutdowndelayshutdownnow.Click += new System.EventHandler(this.ShutdownNow);
            // 
            // ShutdownDelayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 161);
            this.ControlBox = false;
            this.Controls.Add(this.btn_shutdowndelayshutdownnow);
            this.Controls.Add(this.btn_shutdowndelaystop);
            this.Controls.Add(this.pb_shutdowndelay);
            this.Controls.Add(this.lbl_alert);
            this.Controls.Add(this.lbl_shutdowndelay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShutdownDelayForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.sm_shutdowndelayform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_shutdowndelay;
        private MetroFramework.Components.MetroStyleManager sm_shutdowndelayform;
        private MetroFramework.Controls.MetroButton btn_shutdowndelaystop;
        private MetroFramework.Controls.MetroProgressBar pb_shutdowndelay;
        private MetroFramework.Controls.MetroLabel lbl_alert;
        private MetroFramework.Controls.MetroButton btn_shutdowndelayshutdownnow;
    }
}