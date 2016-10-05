namespace Powersaver
{
    partial class PowersaverForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowersaverForm));
            this.stylemanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.rb_monitoroff = new MetroFramework.Controls.MetroRadioButton();
            this.btn_execute = new MetroFramework.Controls.MetroButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.rb_standbymode = new MetroFramework.Controls.MetroRadioButton();
            this.rb_shutdown = new MetroFramework.Controls.MetroRadioButton();
            this.lbl_log = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.tb_log = new MetroFramework.Controls.MetroTextBox();
            this.btn_shortcut = new MetroFramework.Controls.MetroButton();
            this.notifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cm_powersaver = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_show = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_monitoroff = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_shutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_powersaver = new System.Windows.Forms.MenuStrip();
            this.ms_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_monitoroff = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_standbymode = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_shutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.rb_hibernate = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.cm_powersaver.SuspendLayout();
            this.ms_powersaver.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylemanager
            // 
            this.stylemanager.Owner = this;
            this.stylemanager.Style = MetroFramework.MetroColorStyle.Lime;
            this.stylemanager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // rb_monitoroff
            // 
            this.rb_monitoroff.AutoSize = true;
            this.rb_monitoroff.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_monitoroff.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rb_monitoroff.Location = new System.Drawing.Point(5, 7);
            this.rb_monitoroff.Name = "rb_monitoroff";
            this.rb_monitoroff.Size = new System.Drawing.Size(107, 20);
            this.rb_monitoroff.TabIndex = 0;
            this.rb_monitoroff.Text = "Monitor off";
            this.rb_monitoroff.UseSelectable = true;
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(189, 112);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(96, 23);
            this.btn_execute.TabIndex = 1;
            this.btn_execute.Text = "Execute";
            this.btn_execute.UseSelectable = true;
            this.btn_execute.Click += new System.EventHandler(this.ExecuteButtonClicked);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_title.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_title.Location = new System.Drawing.Point(14, 28);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(148, 32);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "PowerSaver";
            // 
            // rb_standbymode
            // 
            this.rb_standbymode.AutoSize = true;
            this.rb_standbymode.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_standbymode.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rb_standbymode.Location = new System.Drawing.Point(5, 33);
            this.rb_standbymode.Name = "rb_standbymode";
            this.rb_standbymode.Size = new System.Drawing.Size(126, 20);
            this.rb_standbymode.TabIndex = 0;
            this.rb_standbymode.Text = "Standby mode";
            this.rb_standbymode.UseSelectable = true;
            // 
            // rb_shutdown
            // 
            this.rb_shutdown.AutoSize = true;
            this.rb_shutdown.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_shutdown.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rb_shutdown.Location = new System.Drawing.Point(5, 85);
            this.rb_shutdown.Name = "rb_shutdown";
            this.rb_shutdown.Size = new System.Drawing.Size(96, 20);
            this.rb_shutdown.TabIndex = 0;
            this.rb_shutdown.Text = "Shutdown";
            this.rb_shutdown.UseSelectable = true;
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.BackColor = System.Drawing.Color.Transparent;
            this.lbl_log.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_log.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_log.Location = new System.Drawing.Point(34, 257);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(35, 20);
            this.lbl_log.TabIndex = 2;
            this.lbl_log.Text = "Log";
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_main.Controls.Add(this.btn_execute);
            this.pnl_main.Controls.Add(this.rb_monitoroff);
            this.pnl_main.Controls.Add(this.rb_hibernate);
            this.pnl_main.Controls.Add(this.rb_shutdown);
            this.pnl_main.Controls.Add(this.rb_standbymode);
            this.pnl_main.Location = new System.Drawing.Point(34, 97);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(293, 145);
            this.pnl_main.TabIndex = 3;
            // 
            // tb_log
            // 
            // 
            // 
            // 
            this.tb_log.CustomButton.Image = null;
            this.tb_log.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.tb_log.CustomButton.Name = "";
            this.tb_log.CustomButton.Size = new System.Drawing.Size(133, 133);
            this.tb_log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_log.CustomButton.TabIndex = 1;
            this.tb_log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_log.CustomButton.UseSelectable = true;
            this.tb_log.CustomButton.Visible = false;
            this.tb_log.Lines = new string[0];
            this.tb_log.Location = new System.Drawing.Point(34, 285);
            this.tb_log.MaxLength = 32767;
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.PasswordChar = '\0';
            this.tb_log.ReadOnly = true;
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log.SelectedText = "";
            this.tb_log.SelectionLength = 0;
            this.tb_log.SelectionStart = 0;
            this.tb_log.ShortcutsEnabled = true;
            this.tb_log.Size = new System.Drawing.Size(293, 135);
            this.tb_log.TabIndex = 4;
            this.tb_log.UseSelectable = true;
            this.tb_log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_log.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_shortcut
            // 
            this.btn_shortcut.Location = new System.Drawing.Point(258, 68);
            this.btn_shortcut.Name = "btn_shortcut";
            this.btn_shortcut.Size = new System.Drawing.Size(69, 23);
            this.btn_shortcut.TabIndex = 1;
            this.btn_shortcut.Text = "Shortcuts";
            this.btn_shortcut.UseSelectable = true;
            this.btn_shortcut.Click += new System.EventHandler(this.ShortcutButtonClicked);
            // 
            // notifyicon
            // 
            this.notifyicon.ContextMenuStrip = this.cm_powersaver;
            this.notifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyicon.Icon")));
            this.notifyicon.Visible = true;
            this.notifyicon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayiconClicked);
            // 
            // cm_powersaver
            // 
            this.cm_powersaver.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cm_powersaver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_show,
            this.cm_monitoroff,
            this.cm_shutdown,
            this.cm_exit});
            this.cm_powersaver.Name = "cm_powersaver";
            this.cm_powersaver.Size = new System.Drawing.Size(164, 108);
            // 
            // cm_show
            // 
            this.cm_show.Name = "cm_show";
            this.cm_show.Size = new System.Drawing.Size(163, 26);
            this.cm_show.Text = "Show";
            this.cm_show.Click += new System.EventHandler(this.CMenuItemShowClicked);
            // 
            // cm_monitoroff
            // 
            this.cm_monitoroff.Name = "cm_monitoroff";
            this.cm_monitoroff.Size = new System.Drawing.Size(163, 26);
            this.cm_monitoroff.Text = "Monitor off";
            this.cm_monitoroff.Click += new System.EventHandler(this.MonitoroffRoutine);
            // 
            // cm_shutdown
            // 
            this.cm_shutdown.Name = "cm_shutdown";
            this.cm_shutdown.Size = new System.Drawing.Size(163, 26);
            this.cm_shutdown.Text = "Shutdown";
            this.cm_shutdown.Click += new System.EventHandler(this.ShutdownRoutine);
            // 
            // cm_exit
            // 
            this.cm_exit.Name = "cm_exit";
            this.cm_exit.Size = new System.Drawing.Size(163, 26);
            this.cm_exit.Text = "Exit";
            this.cm_exit.Click += new System.EventHandler(this.ExitRoutine);
            // 
            // ms_powersaver
            // 
            this.ms_powersaver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ms_powersaver.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_powersaver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_menu});
            this.ms_powersaver.Location = new System.Drawing.Point(20, 60);
            this.ms_powersaver.Name = "ms_powersaver";
            this.ms_powersaver.Size = new System.Drawing.Size(323, 33);
            this.ms_powersaver.TabIndex = 5;
            // 
            // ms_menu
            // 
            this.ms_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ms_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_monitoroff,
            this.ms_standbymode,
            this.ms_shutdown,
            this.ms_exit});
            this.ms_menu.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ms_menu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(76, 29);
            this.ms_menu.Text = "Menu";
            // 
            // ms_monitoroff
            // 
            this.ms_monitoroff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ms_monitoroff.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ms_monitoroff.Name = "ms_monitoroff";
            this.ms_monitoroff.Size = new System.Drawing.Size(223, 30);
            this.ms_monitoroff.Text = "Monitor off";
            this.ms_monitoroff.Click += new System.EventHandler(this.MonitoroffRoutine);
            // 
            // ms_standbymode
            // 
            this.ms_standbymode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ms_standbymode.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ms_standbymode.Name = "ms_standbymode";
            this.ms_standbymode.Size = new System.Drawing.Size(223, 30);
            this.ms_standbymode.Text = "Standby mode";
            this.ms_standbymode.Click += new System.EventHandler(this.StandbyModeRoutine);
            // 
            // ms_shutdown
            // 
            this.ms_shutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ms_shutdown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ms_shutdown.Name = "ms_shutdown";
            this.ms_shutdown.Size = new System.Drawing.Size(223, 30);
            this.ms_shutdown.Text = "Shut down";
            this.ms_shutdown.Click += new System.EventHandler(this.ShutdownRoutine);
            // 
            // ms_exit
            // 
            this.ms_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ms_exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ms_exit.Name = "ms_exit";
            this.ms_exit.Size = new System.Drawing.Size(223, 30);
            this.ms_exit.Text = "Exit";
            this.ms_exit.Click += new System.EventHandler(this.ExitRoutine);
            // 
            // rb_hibernate
            // 
            this.rb_hibernate.AutoSize = true;
            this.rb_hibernate.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_hibernate.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rb_hibernate.Location = new System.Drawing.Point(5, 59);
            this.rb_hibernate.Name = "rb_hibernate";
            this.rb_hibernate.Size = new System.Drawing.Size(94, 20);
            this.rb_hibernate.TabIndex = 0;
            this.rb_hibernate.Text = "Hibernate";
            this.rb_hibernate.UseSelectable = true;
            // 
            // PowersaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 457);
            this.Controls.Add(this.btn_shortcut);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.ms_powersaver);
            this.MainMenuStrip = this.ms_powersaver;
            this.MaximizeBox = false;
            this.Name = "PowersaverForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnDestroy);
            this.Shown += new System.EventHandler(this.OnLoad);
            this.VisibleChanged += new System.EventHandler(this.OnHide);
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.cm_powersaver.ResumeLayout(false);
            this.ms_powersaver.ResumeLayout(false);
            this.ms_powersaver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager stylemanager;
        private MetroFramework.Controls.MetroButton btn_execute;
        private MetroFramework.Controls.MetroRadioButton rb_monitoroff;
        private System.Windows.Forms.Label lbl_title;
        private MetroFramework.Controls.MetroRadioButton rb_shutdown;
        private MetroFramework.Controls.MetroRadioButton rb_standbymode;
        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.Panel pnl_main;
        private MetroFramework.Controls.MetroTextBox tb_log;
        private MetroFramework.Controls.MetroButton btn_shortcut;
        private System.Windows.Forms.NotifyIcon notifyicon;
        private System.Windows.Forms.MenuStrip ms_powersaver;
        private System.Windows.Forms.ToolStripMenuItem ms_menu;
        private System.Windows.Forms.ToolStripMenuItem ms_monitoroff;
        private System.Windows.Forms.ToolStripMenuItem ms_standbymode;
        private System.Windows.Forms.ToolStripMenuItem ms_shutdown;
        private System.Windows.Forms.ToolStripMenuItem ms_exit;
        private System.Windows.Forms.ContextMenuStrip cm_powersaver;
        private System.Windows.Forms.ToolStripMenuItem cm_show;
        private System.Windows.Forms.ToolStripMenuItem cm_monitoroff;
        private System.Windows.Forms.ToolStripMenuItem cm_shutdown;
        private System.Windows.Forms.ToolStripMenuItem cm_exit;
        private MetroFramework.Controls.MetroRadioButton rb_hibernate;
    }
}

