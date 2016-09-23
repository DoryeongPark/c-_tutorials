namespace Assignment2
{
    partial class Assignment2
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
            this.lbl_main = new MetroFramework.Controls.MetroLabel();
            this.tb_brightness = new MetroFramework.Controls.MetroTrackBar();
            this.rb_monitoroff = new System.Windows.Forms.RadioButton();
            this.rb_standbymode = new System.Windows.Forms.RadioButton();
            this.rb_reboot = new System.Windows.Forms.RadioButton();
            this.rb_turnoff = new System.Windows.Forms.RadioButton();
            this.groupbox_main = new System.Windows.Forms.GroupBox();
            this.lbl_brightness = new System.Windows.Forms.Label();
            this.lbl_brightnessvalue = new System.Windows.Forms.Label();
            this.tb_volume = new MetroFramework.Controls.MetroTrackBar();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_volumevalue = new System.Windows.Forms.Label();
            this.img_volume = new System.Windows.Forms.Panel();
            this.img_brightness = new System.Windows.Forms.Panel();
            this.toggle_mute = new MetroFramework.Controls.MetroToggle();
            this.lbl_mute = new System.Windows.Forms.Label();
            this.btn_execute = new MetroFramework.Controls.MetroButton();
            this.groupbox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.BackColor = System.Drawing.Color.Transparent;
            this.lbl_main.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_main.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_main.ForeColor = System.Drawing.Color.Purple;
            this.lbl_main.Location = new System.Drawing.Point(23, 22);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(165, 25);
            this.lbl_main.TabIndex = 0;
            this.lbl_main.Text = "OptionController";
            this.lbl_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_main.UseCustomForeColor = true;
            // 
            // tb_brightness
            // 
            this.tb_brightness.BackColor = System.Drawing.Color.Transparent;
            this.tb_brightness.ForeColor = System.Drawing.Color.Purple;
            this.tb_brightness.Location = new System.Drawing.Point(144, 316);
            this.tb_brightness.Name = "tb_brightness";
            this.tb_brightness.Size = new System.Drawing.Size(286, 23);
            this.tb_brightness.TabIndex = 1;
            this.tb_brightness.UseCustomBackColor = true;
            this.tb_brightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BrightnessScrollChanged);
            this.tb_brightness.DragDrop += new System.Windows.Forms.DragEventHandler(this.BrightnessDragCompleted);
            this.tb_brightness.DragEnter += new System.Windows.Forms.DragEventHandler(this.BrightnessDragStarted);
            // 
            // rb_monitoroff
            // 
            this.rb_monitoroff.AutoSize = true;
            this.rb_monitoroff.Location = new System.Drawing.Point(15, 29);
            this.rb_monitoroff.Name = "rb_monitoroff";
            this.rb_monitoroff.Size = new System.Drawing.Size(112, 24);
            this.rb_monitoroff.TabIndex = 2;
            this.rb_monitoroff.TabStop = true;
            this.rb_monitoroff.Text = "Monitor Off";
            this.rb_monitoroff.UseVisualStyleBackColor = true;
            // 
            // rb_standbymode
            // 
            this.rb_standbymode.AutoSize = true;
            this.rb_standbymode.Location = new System.Drawing.Point(146, 29);
            this.rb_standbymode.Name = "rb_standbymode";
            this.rb_standbymode.Size = new System.Drawing.Size(130, 24);
            this.rb_standbymode.TabIndex = 2;
            this.rb_standbymode.TabStop = true;
            this.rb_standbymode.Text = "Standby Mode";
            this.rb_standbymode.UseVisualStyleBackColor = true;
            // 
            // rb_reboot
            // 
            this.rb_reboot.AutoSize = true;
            this.rb_reboot.Location = new System.Drawing.Point(295, 29);
            this.rb_reboot.Name = "rb_reboot";
            this.rb_reboot.Size = new System.Drawing.Size(79, 24);
            this.rb_reboot.TabIndex = 2;
            this.rb_reboot.TabStop = true;
            this.rb_reboot.Text = "Reboot";
            this.rb_reboot.UseVisualStyleBackColor = true;
            // 
            // rb_turnoff
            // 
            this.rb_turnoff.AutoSize = true;
            this.rb_turnoff.Location = new System.Drawing.Point(393, 29);
            this.rb_turnoff.Name = "rb_turnoff";
            this.rb_turnoff.Size = new System.Drawing.Size(88, 24);
            this.rb_turnoff.TabIndex = 2;
            this.rb_turnoff.TabStop = true;
            this.rb_turnoff.Text = "Turn Off";
            this.rb_turnoff.UseVisualStyleBackColor = true;
            // 
            // groupbox_main
            // 
            this.groupbox_main.Controls.Add(this.rb_monitoroff);
            this.groupbox_main.Controls.Add(this.rb_turnoff);
            this.groupbox_main.Controls.Add(this.rb_standbymode);
            this.groupbox_main.Controls.Add(this.rb_reboot);
            this.groupbox_main.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupbox_main.ForeColor = System.Drawing.Color.Purple;
            this.groupbox_main.Location = new System.Drawing.Point(20, 63);
            this.groupbox_main.Name = "groupbox_main";
            this.groupbox_main.Size = new System.Drawing.Size(495, 60);
            this.groupbox_main.TabIndex = 3;
            this.groupbox_main.TabStop = false;
            this.groupbox_main.Text = "Options";
            // 
            // lbl_brightness
            // 
            this.lbl_brightness.AutoSize = true;
            this.lbl_brightness.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_brightness.ForeColor = System.Drawing.Color.Purple;
            this.lbl_brightness.Location = new System.Drawing.Point(67, 278);
            this.lbl_brightness.Name = "lbl_brightness";
            this.lbl_brightness.Size = new System.Drawing.Size(89, 23);
            this.lbl_brightness.TabIndex = 3;
            this.lbl_brightness.Text = "Brightness";
            // 
            // lbl_brightnessvalue
            // 
            this.lbl_brightnessvalue.AutoSize = true;
            this.lbl_brightnessvalue.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_brightnessvalue.ForeColor = System.Drawing.Color.Purple;
            this.lbl_brightnessvalue.Location = new System.Drawing.Point(116, 316);
            this.lbl_brightnessvalue.Name = "lbl_brightnessvalue";
            this.lbl_brightnessvalue.Size = new System.Drawing.Size(17, 19);
            this.lbl_brightnessvalue.TabIndex = 5;
            this.lbl_brightnessvalue.Text = "0";
            // 
            // tb_volume
            // 
            this.tb_volume.BackColor = System.Drawing.Color.Transparent;
            this.tb_volume.ForeColor = System.Drawing.Color.Purple;
            this.tb_volume.Location = new System.Drawing.Point(144, 227);
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(286, 23);
            this.tb_volume.TabIndex = 1;
            this.tb_volume.UseCustomBackColor = true;
            this.tb_volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VolumeScrollChanged);
            this.tb_volume.DragDrop += new System.Windows.Forms.DragEventHandler(this.VolumeDragCompleted);
            this.tb_volume.DragEnter += new System.Windows.Forms.DragEventHandler(this.VolumeDragStarted);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_volume.ForeColor = System.Drawing.Color.Purple;
            this.lbl_volume.Location = new System.Drawing.Point(67, 189);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(69, 23);
            this.lbl_volume.TabIndex = 3;
            this.lbl_volume.Text = "Volume";
            // 
            // lbl_volumevalue
            // 
            this.lbl_volumevalue.AutoSize = true;
            this.lbl_volumevalue.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_volumevalue.ForeColor = System.Drawing.Color.Purple;
            this.lbl_volumevalue.Location = new System.Drawing.Point(116, 227);
            this.lbl_volumevalue.Name = "lbl_volumevalue";
            this.lbl_volumevalue.Size = new System.Drawing.Size(17, 19);
            this.lbl_volumevalue.TabIndex = 5;
            this.lbl_volumevalue.Text = "0";
            // 
            // img_volume
            // 
            this.img_volume.BackColor = System.Drawing.Color.Transparent;
            this.img_volume.BackgroundImage = global::Assignment2.Properties.Resources.volume;
            this.img_volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img_volume.Location = new System.Drawing.Point(71, 214);
            this.img_volume.Name = "img_volume";
            this.img_volume.Size = new System.Drawing.Size(39, 49);
            this.img_volume.TabIndex = 4;
            // 
            // img_brightness
            // 
            this.img_brightness.BackColor = System.Drawing.Color.Transparent;
            this.img_brightness.BackgroundImage = global::Assignment2.Properties.Resources.brightness;
            this.img_brightness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img_brightness.Location = new System.Drawing.Point(71, 305);
            this.img_brightness.Name = "img_brightness";
            this.img_brightness.Size = new System.Drawing.Size(39, 45);
            this.img_brightness.TabIndex = 4;
            // 
            // toggle_mute
            // 
            this.toggle_mute.AutoSize = true;
            this.toggle_mute.Location = new System.Drawing.Point(336, 193);
            this.toggle_mute.Name = "toggle_mute";
            this.toggle_mute.Size = new System.Drawing.Size(80, 19);
            this.toggle_mute.Style = MetroFramework.MetroColorStyle.Purple;
            this.toggle_mute.TabIndex = 6;
            this.toggle_mute.Text = "Off";
            this.toggle_mute.UseSelectable = true;
            this.toggle_mute.CheckedChanged += new System.EventHandler(this.MuteToggled);
            // 
            // lbl_mute
            // 
            this.lbl_mute.AutoSize = true;
            this.lbl_mute.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_mute.ForeColor = System.Drawing.Color.Purple;
            this.lbl_mute.Location = new System.Drawing.Point(297, 194);
            this.lbl_mute.Name = "lbl_mute";
            this.lbl_mute.Size = new System.Drawing.Size(45, 20);
            this.lbl_mute.TabIndex = 3;
            this.lbl_mute.Text = "Mute";
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(422, 129);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(90, 29);
            this.btn_execute.TabIndex = 7;
            this.btn_execute.Text = "Execute";
            this.btn_execute.UseSelectable = true;
            this.btn_execute.Click += new System.EventHandler(this.ExecuteButtonClicked);
            // 
            // Assignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 379);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.toggle_mute);
            this.Controls.Add(this.lbl_volumevalue);
            this.Controls.Add(this.lbl_brightnessvalue);
            this.Controls.Add(this.img_volume);
            this.Controls.Add(this.img_brightness);
            this.Controls.Add(this.lbl_mute);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.lbl_brightness);
            this.Controls.Add(this.groupbox_main);
            this.Controls.Add(this.tb_volume);
            this.Controls.Add(this.tb_brightness);
            this.Controls.Add(this.lbl_main);
            this.Name = "Assignment2";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnDestroy);
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupbox_main.ResumeLayout(false);
            this.groupbox_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_main;
        private MetroFramework.Controls.MetroTrackBar tb_brightness;
        private System.Windows.Forms.RadioButton rb_monitoroff;
        private System.Windows.Forms.RadioButton rb_standbymode;
        private System.Windows.Forms.RadioButton rb_reboot;
        private System.Windows.Forms.RadioButton rb_turnoff;
        private System.Windows.Forms.GroupBox groupbox_main;
        private System.Windows.Forms.Label lbl_brightness;
        private System.Windows.Forms.Panel img_brightness;
        private System.Windows.Forms.Label lbl_brightnessvalue;
        private MetroFramework.Controls.MetroTrackBar tb_volume;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Panel img_volume;
        private System.Windows.Forms.Label lbl_volumevalue;
        private MetroFramework.Controls.MetroToggle toggle_mute;
        private System.Windows.Forms.Label lbl_mute;
        private MetroFramework.Controls.MetroButton btn_execute;
    }
}

