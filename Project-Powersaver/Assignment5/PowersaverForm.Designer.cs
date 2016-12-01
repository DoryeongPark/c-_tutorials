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
            this.lbl_mode = new System.Windows.Forms.Label();
            this.rb_hibernate = new MetroFramework.Controls.MetroRadioButton();
            this.tb_log = new MetroFramework.Controls.MetroTextBox();
            this.btn_shortcut = new MetroFramework.Controls.MetroButton();
            this.notifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cm_powersaver = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_show = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_monitoroff = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_shutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.socketOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socketOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_powersaver = new System.Windows.Forms.MenuStrip();
            this.ms_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_monitoroff = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_standbymode = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_shutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_reservation = new MetroFramework.Controls.MetroPanel();
            this.btn_reservationexecutenow = new MetroFramework.Controls.MetroButton();
            this.btn_reservationcancel = new MetroFramework.Controls.MetroButton();
            this.lbl_reservation = new MetroFramework.Controls.MetroLabel();
            this.pb_reservation = new MetroFramework.Controls.MetroProgressBar();
            this.lbl_time = new System.Windows.Forms.Label();
            this.tb_min = new MetroFramework.Controls.MetroTextBox();
            this.tb_sec = new MetroFramework.Controls.MetroTextBox();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reservation = new MetroFramework.Controls.MetroButton();
            this.btn_savelog = new MetroFramework.Controls.MetroButton();
            this.btn_registerid = new MetroFramework.Controls.MetroButton();
            this.btn_registerface = new MetroFramework.Controls.MetroButton();
            this.btn_compareface = new MetroFramework.Controls.MetroButton();
            this.lbl_vision = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_detectmotion = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.cm_powersaver.SuspendLayout();
            this.ms_powersaver.SuspendLayout();
            this.pnl_reservation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btn_execute.Location = new System.Drawing.Point(244, 112);
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
            this.lbl_title.Location = new System.Drawing.Point(14, 25);
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
            this.lbl_log.Location = new System.Drawing.Point(23, 376);
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
            this.pnl_main.Controls.Add(this.lbl_mode);
            this.pnl_main.Controls.Add(this.rb_monitoroff);
            this.pnl_main.Controls.Add(this.rb_hibernate);
            this.pnl_main.Controls.Add(this.rb_shutdown);
            this.pnl_main.Controls.Add(this.rb_standbymode);
            this.pnl_main.Location = new System.Drawing.Point(20, 105);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(354, 145);
            this.pnl_main.TabIndex = 3;
            // 
            // lbl_mode
            // 
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mode.Font = new System.Drawing.Font("맑은 고딕", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_mode.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_mode.Location = new System.Drawing.Point(8, 118);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(120, 15);
            this.lbl_mode.TabIndex = 2;
            this.lbl_mode.Text = "Local Control Mode";
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
            // tb_log
            // 
            // 
            // 
            // 
            this.tb_log.CustomButton.Image = null;
            this.tb_log.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.tb_log.CustomButton.Name = "";
            this.tb_log.CustomButton.Size = new System.Drawing.Size(159, 159);
            this.tb_log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_log.CustomButton.TabIndex = 1;
            this.tb_log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_log.CustomButton.UseSelectable = true;
            this.tb_log.CustomButton.Visible = false;
            this.tb_log.Lines = new string[0];
            this.tb_log.Location = new System.Drawing.Point(20, 402);
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
            this.tb_log.Size = new System.Drawing.Size(354, 161);
            this.tb_log.TabIndex = 4;
            this.tb_log.UseSelectable = true;
            this.tb_log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_log.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_shortcut
            // 
            this.btn_shortcut.Location = new System.Drawing.Point(303, 76);
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
            this.socketOnToolStripMenuItem,
            this.socketOffToolStripMenuItem,
            this.cm_exit});
            this.cm_powersaver.Name = "cm_powersaver";
            this.cm_powersaver.Size = new System.Drawing.Size(164, 160);
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
            // socketOnToolStripMenuItem
            // 
            this.socketOnToolStripMenuItem.Name = "socketOnToolStripMenuItem";
            this.socketOnToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.socketOnToolStripMenuItem.Text = "Socket on";
            this.socketOnToolStripMenuItem.Click += new System.EventHandler(this.SocketOn);
            // 
            // socketOffToolStripMenuItem
            // 
            this.socketOffToolStripMenuItem.Name = "socketOffToolStripMenuItem";
            this.socketOffToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.socketOffToolStripMenuItem.Text = "Socket off";
            this.socketOffToolStripMenuItem.Click += new System.EventHandler(this.SocketOff);
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
            this.ms_powersaver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ms_powersaver.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_powersaver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_menu});
            this.ms_powersaver.Location = new System.Drawing.Point(20, 60);
            this.ms_powersaver.Name = "ms_powersaver";
            this.ms_powersaver.Size = new System.Drawing.Size(359, 33);
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
            this.ms_menu.ForeColor = System.Drawing.Color.GreenYellow;
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
            // pnl_reservation
            // 
            this.pnl_reservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_reservation.Controls.Add(this.btn_reservationexecutenow);
            this.pnl_reservation.Controls.Add(this.btn_reservationcancel);
            this.pnl_reservation.Controls.Add(this.lbl_reservation);
            this.pnl_reservation.Controls.Add(this.pb_reservation);
            this.pnl_reservation.HorizontalScrollbarBarColor = true;
            this.pnl_reservation.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_reservation.HorizontalScrollbarSize = 10;
            this.pnl_reservation.Location = new System.Drawing.Point(20, 105);
            this.pnl_reservation.Name = "pnl_reservation";
            this.pnl_reservation.Size = new System.Drawing.Size(354, 145);
            this.pnl_reservation.TabIndex = 6;
            this.pnl_reservation.VerticalScrollbarBarColor = true;
            this.pnl_reservation.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_reservation.VerticalScrollbarSize = 10;
            // 
            // btn_reservationexecutenow
            // 
            this.btn_reservationexecutenow.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_reservationexecutenow.Location = new System.Drawing.Point(179, 112);
            this.btn_reservationexecutenow.Name = "btn_reservationexecutenow";
            this.btn_reservationexecutenow.Size = new System.Drawing.Size(118, 24);
            this.btn_reservationexecutenow.TabIndex = 8;
            this.btn_reservationexecutenow.Text = "Execute now";
            this.btn_reservationexecutenow.UseSelectable = true;
            this.btn_reservationexecutenow.Click += new System.EventHandler(this.ExecuteNowReservation);
            // 
            // btn_reservationcancel
            // 
            this.btn_reservationcancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_reservationcancel.Location = new System.Drawing.Point(55, 112);
            this.btn_reservationcancel.Name = "btn_reservationcancel";
            this.btn_reservationcancel.Size = new System.Drawing.Size(118, 24);
            this.btn_reservationcancel.TabIndex = 8;
            this.btn_reservationcancel.Text = "Cancel";
            this.btn_reservationcancel.UseSelectable = true;
            this.btn_reservationcancel.Click += new System.EventHandler(this.CancelReservation);
            // 
            // lbl_reservation
            // 
            this.lbl_reservation.AutoSize = true;
            this.lbl_reservation.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_reservation.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_reservation.Location = new System.Drawing.Point(6, 21);
            this.lbl_reservation.Name = "lbl_reservation";
            this.lbl_reservation.Size = new System.Drawing.Size(81, 17);
            this.lbl_reservation.TabIndex = 7;
            this.lbl_reservation.Text = "Reservation";
            // 
            // pb_reservation
            // 
            this.pb_reservation.Location = new System.Drawing.Point(5, 57);
            this.pb_reservation.Name = "pb_reservation";
            this.pb_reservation.Size = new System.Drawing.Size(344, 23);
            this.pb_reservation.TabIndex = 2;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_time.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_time.Location = new System.Drawing.Point(23, 266);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(92, 20);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "Reservation";
            // 
            // tb_min
            // 
            // 
            // 
            // 
            this.tb_min.CustomButton.Image = null;
            this.tb_min.CustomButton.Location = new System.Drawing.Point(3, 1);
            this.tb_min.CustomButton.Name = "";
            this.tb_min.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tb_min.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_min.CustomButton.TabIndex = 1;
            this.tb_min.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_min.CustomButton.UseSelectable = true;
            this.tb_min.CustomButton.Visible = false;
            this.tb_min.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_min.Lines = new string[0];
            this.tb_min.Location = new System.Drawing.Point(44, 12);
            this.tb_min.MaxLength = 32767;
            this.tb_min.Name = "tb_min";
            this.tb_min.PasswordChar = '\0';
            this.tb_min.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_min.SelectedText = "";
            this.tb_min.SelectionLength = 0;
            this.tb_min.SelectionStart = 0;
            this.tb_min.ShortcutsEnabled = true;
            this.tb_min.Size = new System.Drawing.Size(37, 35);
            this.tb_min.TabIndex = 8;
            this.tb_min.UseSelectable = true;
            this.tb_min.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_min.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_sec
            // 
            // 
            // 
            // 
            this.tb_sec.CustomButton.Image = null;
            this.tb_sec.CustomButton.Location = new System.Drawing.Point(3, 1);
            this.tb_sec.CustomButton.Name = "";
            this.tb_sec.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tb_sec.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_sec.CustomButton.TabIndex = 1;
            this.tb_sec.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_sec.CustomButton.UseSelectable = true;
            this.tb_sec.CustomButton.Visible = false;
            this.tb_sec.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_sec.Lines = new string[0];
            this.tb_sec.Location = new System.Drawing.Point(128, 12);
            this.tb_sec.MaxLength = 32767;
            this.tb_sec.Name = "tb_sec";
            this.tb_sec.PasswordChar = '\0';
            this.tb_sec.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_sec.SelectedText = "";
            this.tb_sec.SelectionLength = 0;
            this.tb_sec.SelectionStart = 0;
            this.tb_sec.ShortcutsEnabled = true;
            this.tb_sec.Size = new System.Drawing.Size(37, 35);
            this.tb_sec.TabIndex = 8;
            this.tb_sec.UseSelectable = true;
            this.tb_sec.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_sec.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_min.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_min.Location = new System.Drawing.Point(82, 21);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(36, 20);
            this.lbl_min.TabIndex = 2;
            this.lbl_min.Text = "min";
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sec.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_sec.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_sec.Location = new System.Drawing.Point(166, 21);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(31, 20);
            this.lbl_sec.TabIndex = 2;
            this.lbl_sec.Text = "sec";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_min);
            this.panel1.Controls.Add(this.lbl_min);
            this.panel1.Controls.Add(this.tb_sec);
            this.panel1.Controls.Add(this.btn_reservation);
            this.panel1.Controls.Add(this.lbl_sec);
            this.panel1.Location = new System.Drawing.Point(20, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 62);
            this.panel1.TabIndex = 9;
            // 
            // btn_reservation
            // 
            this.btn_reservation.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_reservation.Location = new System.Drawing.Point(213, 19);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(99, 24);
            this.btn_reservation.TabIndex = 8;
            this.btn_reservation.Text = "Reservation";
            this.btn_reservation.UseSelectable = true;
            this.btn_reservation.Click += new System.EventHandler(this.ReservationRoutine);
            // 
            // btn_savelog
            // 
            this.btn_savelog.Location = new System.Drawing.Point(268, 373);
            this.btn_savelog.Name = "btn_savelog";
            this.btn_savelog.Size = new System.Drawing.Size(104, 23);
            this.btn_savelog.TabIndex = 1;
            this.btn_savelog.Text = "Save log as File";
            this.btn_savelog.UseSelectable = true;
            this.btn_savelog.Click += new System.EventHandler(this.SaveLogAsFile);
            // 
            // btn_registerid
            // 
            this.btn_registerid.Location = new System.Drawing.Point(303, 47);
            this.btn_registerid.Name = "btn_registerid";
            this.btn_registerid.Size = new System.Drawing.Size(69, 23);
            this.btn_registerid.TabIndex = 1;
            this.btn_registerid.Text = "Register";
            this.btn_registerid.UseSelectable = true;
            this.btn_registerid.Click += new System.EventHandler(this.RegisterId);
            // 
            // btn_registerface
            // 
            this.btn_registerface.Location = new System.Drawing.Point(22, 18);
            this.btn_registerface.Name = "btn_registerface";
            this.btn_registerface.Size = new System.Drawing.Size(99, 23);
            this.btn_registerface.TabIndex = 1;
            this.btn_registerface.Text = "Register Face";
            this.btn_registerface.UseSelectable = true;
            this.btn_registerface.Click += new System.EventHandler(this.RegisterId);
            // 
            // btn_compareface
            // 
            this.btn_compareface.Location = new System.Drawing.Point(127, 18);
            this.btn_compareface.Name = "btn_compareface";
            this.btn_compareface.Size = new System.Drawing.Size(101, 23);
            this.btn_compareface.TabIndex = 1;
            this.btn_compareface.Text = "Compare Face";
            this.btn_compareface.UseSelectable = true;
            this.btn_compareface.Click += new System.EventHandler(this.RegisterId);
            // 
            // lbl_vision
            // 
            this.lbl_vision.AutoSize = true;
            this.lbl_vision.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vision.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_vision.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_vision.Location = new System.Drawing.Point(23, 585);
            this.lbl_vision.Name = "lbl_vision";
            this.lbl_vision.Size = new System.Drawing.Size(175, 20);
            this.lbl_vision.TabIndex = 2;
            this.lbl_vision.Text = "Vision [Laptop Camera]";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_registerface);
            this.panel2.Controls.Add(this.btn_detectmotion);
            this.panel2.Controls.Add(this.btn_compareface);
            this.panel2.Location = new System.Drawing.Point(20, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 60);
            this.panel2.TabIndex = 10;
            // 
            // btn_detectmotion
            // 
            this.btn_detectmotion.Location = new System.Drawing.Point(234, 18);
            this.btn_detectmotion.Name = "btn_detectmotion";
            this.btn_detectmotion.Size = new System.Drawing.Size(101, 23);
            this.btn_detectmotion.TabIndex = 1;
            this.btn_detectmotion.Text = "Detect Motion";
            this.btn_detectmotion.UseSelectable = true;
            this.btn_detectmotion.Click += new System.EventHandler(this.RegisterId);
            // 
            // PowersaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_reservation);
            this.Controls.Add(this.btn_savelog);
            this.Controls.Add(this.btn_registerid);
            this.Controls.Add(this.btn_shortcut);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_vision);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.ms_powersaver);
            this.Controls.Add(this.panel2);
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
            this.Resize += new System.EventHandler(this.OnResize);
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.cm_powersaver.ResumeLayout(false);
            this.ms_powersaver.ResumeLayout(false);
            this.ms_powersaver.PerformLayout();
            this.pnl_reservation.ResumeLayout(false);
            this.pnl_reservation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroRadioButton rb_hibernate;
        private MetroFramework.Controls.MetroPanel pnl_reservation;
        private MetroFramework.Controls.MetroProgressBar pb_reservation;
        private MetroFramework.Controls.MetroButton btn_reservationcancel;
        private MetroFramework.Controls.MetroLabel lbl_reservation;
        private MetroFramework.Controls.MetroButton btn_reservationexecutenow;
        private MetroFramework.Controls.MetroTextBox tb_sec;
        private MetroFramework.Controls.MetroTextBox tb_min;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btn_reservation;
        private MetroFramework.Controls.MetroButton btn_savelog;
        private MetroFramework.Controls.MetroButton btn_registerid;
        private System.Windows.Forms.ToolStripMenuItem socketOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socketOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cm_exit;
        private System.Windows.Forms.Label lbl_mode;
        private System.Windows.Forms.Label lbl_vision;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton btn_registerface;
        private MetroFramework.Controls.MetroButton btn_detectmotion;
        private MetroFramework.Controls.MetroButton btn_compareface;
    }
}

