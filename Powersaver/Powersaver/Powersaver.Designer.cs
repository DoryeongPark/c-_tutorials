namespace Powersaver
{
    partial class Powersaver
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
            this.stylemanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lbl_appname = new System.Windows.Forms.Label();
            this.lbl_monitor = new System.Windows.Forms.Label();
            this.lbl_system = new System.Windows.Forms.Label();
            this.lbl_reservation = new System.Windows.Forms.Label();
            this.btn_powersave = new MetroFramework.Controls.MetroButton();
            this.btn_suspend = new MetroFramework.Controls.MetroButton();
            this.btn_hibernate = new MetroFramework.Controls.MetroButton();
            this.tb_min = new MetroFramework.Controls.MetroTextBox();
            this.lbl_min = new MetroFramework.Controls.MetroLabel();
            this.tb_sec = new MetroFramework.Controls.MetroTextBox();
            this.lbl_sec = new MetroFramework.Controls.MetroLabel();
            this.btn_off = new MetroFramework.Controls.MetroButton();
            this.pb_reservation = new MetroFramework.Controls.MetroProgressBar();
            this.btn_cancelreservation = new MetroFramework.Controls.MetroButton();
            this.lbl_log = new System.Windows.Forms.Label();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).BeginInit();
            this.SuspendLayout();
            // 
            // stylemanager
            // 
            this.stylemanager.Owner = this;
            this.stylemanager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_appname
            // 
            this.lbl_appname.AutoSize = true;
            this.lbl_appname.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_appname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_appname.Location = new System.Drawing.Point(6, 10);
            this.lbl_appname.Name = "lbl_appname";
            this.lbl_appname.Size = new System.Drawing.Size(216, 51);
            this.lbl_appname.TabIndex = 0;
            this.lbl_appname.Text = "Powersaver";
            // 
            // lbl_monitor
            // 
            this.lbl_monitor.AutoSize = true;
            this.lbl_monitor.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_monitor.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_monitor.Location = new System.Drawing.Point(11, 87);
            this.lbl_monitor.Name = "lbl_monitor";
            this.lbl_monitor.Size = new System.Drawing.Size(77, 23);
            this.lbl_monitor.TabIndex = 0;
            this.lbl_monitor.Text = "Monitor";
            // 
            // lbl_system
            // 
            this.lbl_system.AutoSize = true;
            this.lbl_system.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_system.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_system.Location = new System.Drawing.Point(11, 175);
            this.lbl_system.Name = "lbl_system";
            this.lbl_system.Size = new System.Drawing.Size(69, 23);
            this.lbl_system.TabIndex = 0;
            this.lbl_system.Text = "System";
            // 
            // lbl_reservation
            // 
            this.lbl_reservation.AutoSize = true;
            this.lbl_reservation.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_reservation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_reservation.Location = new System.Drawing.Point(11, 263);
            this.lbl_reservation.Name = "lbl_reservation";
            this.lbl_reservation.Size = new System.Drawing.Size(105, 23);
            this.lbl_reservation.TabIndex = 1;
            this.lbl_reservation.Text = "Reservation";
            // 
            // btn_powersave
            // 
            this.btn_powersave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_powersave.Location = new System.Drawing.Point(15, 123);
            this.btn_powersave.Name = "btn_powersave";
            this.btn_powersave.Size = new System.Drawing.Size(178, 35);
            this.btn_powersave.TabIndex = 2;
            this.btn_powersave.Text = "Powersave";
            this.btn_powersave.UseSelectable = true;
            this.btn_powersave.Click += new System.EventHandler(this.MonitorPowerSaveButtonClicked);
            // 
            // btn_suspend
            // 
            this.btn_suspend.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_suspend.Location = new System.Drawing.Point(15, 214);
            this.btn_suspend.Name = "btn_suspend";
            this.btn_suspend.Size = new System.Drawing.Size(178, 35);
            this.btn_suspend.TabIndex = 2;
            this.btn_suspend.Text = "Suspend";
            this.btn_suspend.UseSelectable = true;
            this.btn_suspend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SystemSuspendButtonClicked);
            // 
            // btn_hibernate
            // 
            this.btn_hibernate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_hibernate.Location = new System.Drawing.Point(216, 214);
            this.btn_hibernate.Name = "btn_hibernate";
            this.btn_hibernate.Size = new System.Drawing.Size(178, 35);
            this.btn_hibernate.TabIndex = 2;
            this.btn_hibernate.Text = "Hibernate";
            this.btn_hibernate.UseSelectable = true;
            this.btn_hibernate.Click += new System.EventHandler(this.SystemHibernateButtonClicked);
            // 
            // tb_min
            // 
            // 
            // 
            // 
            this.tb_min.CustomButton.Image = null;
            this.tb_min.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.tb_min.CustomButton.Name = "";
            this.tb_min.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_min.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_min.CustomButton.TabIndex = 1;
            this.tb_min.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_min.CustomButton.UseSelectable = true;
            this.tb_min.CustomButton.Visible = false;
            this.tb_min.Lines = new string[0];
            this.tb_min.Location = new System.Drawing.Point(15, 293);
            this.tb_min.MaxLength = 2;
            this.tb_min.Name = "tb_min";
            this.tb_min.PasswordChar = '\0';
            this.tb_min.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_min.SelectedText = "";
            this.tb_min.SelectionLength = 0;
            this.tb_min.SelectionStart = 0;
            this.tb_min.ShortcutsEnabled = true;
            this.tb_min.Size = new System.Drawing.Size(34, 25);
            this.tb_min.TabIndex = 3;
            this.tb_min.UseSelectable = true;
            this.tb_min.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_min.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputReservationTime);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_min.Location = new System.Drawing.Point(49, 296);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(34, 20);
            this.lbl_min.TabIndex = 4;
            this.lbl_min.Text = "min";
            // 
            // tb_sec
            // 
            // 
            // 
            // 
            this.tb_sec.CustomButton.Image = null;
            this.tb_sec.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.tb_sec.CustomButton.Name = "";
            this.tb_sec.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_sec.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_sec.CustomButton.TabIndex = 1;
            this.tb_sec.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_sec.CustomButton.UseSelectable = true;
            this.tb_sec.CustomButton.Visible = false;
            this.tb_sec.Lines = new string[0];
            this.tb_sec.Location = new System.Drawing.Point(89, 293);
            this.tb_sec.MaxLength = 2;
            this.tb_sec.Name = "tb_sec";
            this.tb_sec.PasswordChar = '\0';
            this.tb_sec.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_sec.SelectedText = "";
            this.tb_sec.SelectionLength = 0;
            this.tb_sec.SelectionStart = 0;
            this.tb_sec.ShortcutsEnabled = true;
            this.tb_sec.Size = new System.Drawing.Size(34, 25);
            this.tb_sec.TabIndex = 3;
            this.tb_sec.UseSelectable = true;
            this.tb_sec.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_sec.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_sec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputReservationTime);
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_sec.Location = new System.Drawing.Point(124, 296);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(30, 20);
            this.lbl_sec.TabIndex = 4;
            this.lbl_sec.Text = "sec";
            // 
            // btn_off
            // 
            this.btn_off.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_off.Location = new System.Drawing.Point(216, 123);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(178, 35);
            this.btn_off.TabIndex = 2;
            this.btn_off.Text = "Off";
            this.btn_off.UseSelectable = true;
            this.btn_off.Click += new System.EventHandler(this.MonitorOffButtonClicked);
            // 
            // pb_reservation
            // 
            this.pb_reservation.Location = new System.Drawing.Point(15, 332);
            this.pb_reservation.Name = "pb_reservation";
            this.pb_reservation.Size = new System.Drawing.Size(293, 23);
            this.pb_reservation.TabIndex = 5;
            // 
            // btn_cancelreservation
            // 
            this.btn_cancelreservation.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_cancelreservation.Location = new System.Drawing.Point(325, 332);
            this.btn_cancelreservation.Name = "btn_cancelreservation";
            this.btn_cancelreservation.Size = new System.Drawing.Size(64, 23);
            this.btn_cancelreservation.TabIndex = 2;
            this.btn_cancelreservation.Text = "Cancel";
            this.btn_cancelreservation.UseSelectable = true;
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_log.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_log.Location = new System.Drawing.Point(11, 363);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(41, 23);
            this.lbl_log.TabIndex = 1;
            this.lbl_log.Text = "Log";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(151, 151);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(15, 400);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Multiline = true;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ReadOnly = true;
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(379, 156);
            this.metroTextBox3.TabIndex = 6;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Powersaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 579);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.pb_reservation);
            this.Controls.Add(this.lbl_sec);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.tb_sec);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.btn_hibernate);
            this.Controls.Add(this.btn_cancelreservation);
            this.Controls.Add(this.btn_suspend);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_powersave);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.lbl_reservation);
            this.Controls.Add(this.lbl_system);
            this.Controls.Add(this.lbl_monitor);
            this.Controls.Add(this.lbl_appname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Powersaver";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowIcon = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onDestroy);
            this.Load += new System.EventHandler(this.Powersaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager stylemanager;
        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.Label lbl_monitor;
        private System.Windows.Forms.Label lbl_system;
        private System.Windows.Forms.Label lbl_reservation;
        private MetroFramework.Controls.MetroButton btn_powersave;
        private MetroFramework.Controls.MetroButton btn_suspend;
        private MetroFramework.Controls.MetroButton btn_hibernate;
        private MetroFramework.Controls.MetroTextBox tb_min;
        private MetroFramework.Controls.MetroLabel lbl_min;
        private MetroFramework.Controls.MetroTextBox tb_sec;
        private MetroFramework.Controls.MetroLabel lbl_sec;
        private MetroFramework.Controls.MetroButton btn_off;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroProgressBar pb_reservation;
        private MetroFramework.Controls.MetroButton btn_cancelreservation;
        private System.Windows.Forms.Label lbl_log;
    }
}

