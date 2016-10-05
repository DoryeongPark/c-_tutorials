namespace Powersaver
{
    partial class ShortcutForm
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
            this.sm_shortcutform = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lbl_shortcuts = new MetroFramework.Controls.MetroLabel();
            this.lbl_monitoroff = new MetroFramework.Controls.MetroLabel();
            this.lbl_shutdown = new MetroFramework.Controls.MetroLabel();
            this.tb_monitoroff = new MetroFramework.Controls.MetroButton();
            this.tb_shutdown = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.sm_shortcutform)).BeginInit();
            this.SuspendLayout();
            // 
            // sm_shortcutform
            // 
            this.sm_shortcutform.Owner = this;
            this.sm_shortcutform.Style = MetroFramework.MetroColorStyle.Lime;
            this.sm_shortcutform.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_shortcuts
            // 
            this.lbl_shortcuts.AutoSize = true;
            this.lbl_shortcuts.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_shortcuts.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_shortcuts.Location = new System.Drawing.Point(14, 27);
            this.lbl_shortcuts.Name = "lbl_shortcuts";
            this.lbl_shortcuts.Size = new System.Drawing.Size(98, 25);
            this.lbl_shortcuts.TabIndex = 0;
            this.lbl_shortcuts.Text = "Shortcuts";
            // 
            // lbl_monitoroff
            // 
            this.lbl_monitoroff.AutoSize = true;
            this.lbl_monitoroff.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_monitoroff.Location = new System.Drawing.Point(19, 94);
            this.lbl_monitoroff.Name = "lbl_monitoroff";
            this.lbl_monitoroff.Size = new System.Drawing.Size(93, 20);
            this.lbl_monitoroff.TabIndex = 0;
            this.lbl_monitoroff.Text = "Monitor Off";
            // 
            // lbl_shutdown
            // 
            this.lbl_shutdown.AutoSize = true;
            this.lbl_shutdown.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_shutdown.Location = new System.Drawing.Point(30, 158);
            this.lbl_shutdown.Name = "lbl_shutdown";
            this.lbl_shutdown.Size = new System.Drawing.Size(80, 20);
            this.lbl_shutdown.TabIndex = 0;
            this.lbl_shutdown.Text = "Shutdown";
            // 
            // tb_monitoroff
            // 
            this.tb_monitoroff.Location = new System.Drawing.Point(142, 89);
            this.tb_monitoroff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_monitoroff.Name = "tb_monitoroff";
            this.tb_monitoroff.Size = new System.Drawing.Size(38, 31);
            this.tb_monitoroff.TabIndex = 1;
            this.tb_monitoroff.UseSelectable = true;
            // 
            // tb_shutdown
            // 
            this.tb_shutdown.Location = new System.Drawing.Point(142, 153);
            this.tb_shutdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_shutdown.Name = "tb_shutdown";
            this.tb_shutdown.Size = new System.Drawing.Size(38, 31);
            this.tb_shutdown.TabIndex = 1;
            this.tb_shutdown.UseSelectable = true;
            // 
            // ShortcutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 221);
            this.Controls.Add(this.tb_shutdown);
            this.Controls.Add(this.tb_monitoroff);
            this.Controls.Add(this.lbl_shutdown);
            this.Controls.Add(this.lbl_monitoroff);
            this.Controls.Add(this.lbl_shortcuts);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShortcutForm";
            this.Padding = new System.Windows.Forms.Padding(22, 80, 22, 27);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.sm_shortcutform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager sm_shortcutform;
        private MetroFramework.Controls.MetroLabel lbl_shortcuts;
        private MetroFramework.Controls.MetroLabel lbl_shutdown;
        private MetroFramework.Controls.MetroLabel lbl_monitoroff;
        private MetroFramework.Controls.MetroButton tb_shutdown;
        private MetroFramework.Controls.MetroButton tb_monitoroff;
    }
}