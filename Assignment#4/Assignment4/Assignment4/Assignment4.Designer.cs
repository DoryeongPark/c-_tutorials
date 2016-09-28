namespace Assignment4
{
    partial class Assignment4
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
            this.btn_open = new MetroFramework.Controls.MetroButton();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.btn_fonteditor = new MetroFramework.Controls.MetroButton();
            this.btn_backgroundcoloreditor = new MetroFramework.Controls.MetroButton();
            this.tb_main = new System.Windows.Forms.TextBox();
            this.lbl_title1 = new System.Windows.Forms.Label();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.lbl_textcurrentfile = new System.Windows.Forms.Label();
            this.lbl_currentfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(669, 44);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(138, 34);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseSelectable = true;
            this.btn_open.Click += new System.EventHandler(this.OpenButtonClicked);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(669, 89);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 34);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.SaveButtonClicked);
            // 
            // btn_fonteditor
            // 
            this.btn_fonteditor.Location = new System.Drawing.Point(669, 134);
            this.btn_fonteditor.Name = "btn_fonteditor";
            this.btn_fonteditor.Size = new System.Drawing.Size(138, 34);
            this.btn_fonteditor.TabIndex = 1;
            this.btn_fonteditor.Text = "Font";
            this.btn_fonteditor.UseSelectable = true;
            this.btn_fonteditor.Click += new System.EventHandler(this.FontButtonClicked);
            // 
            // btn_backgroundcoloreditor
            // 
            this.btn_backgroundcoloreditor.Location = new System.Drawing.Point(669, 179);
            this.btn_backgroundcoloreditor.Name = "btn_backgroundcoloreditor";
            this.btn_backgroundcoloreditor.Size = new System.Drawing.Size(138, 34);
            this.btn_backgroundcoloreditor.TabIndex = 1;
            this.btn_backgroundcoloreditor.Text = "Background Color";
            this.btn_backgroundcoloreditor.UseSelectable = true;
            this.btn_backgroundcoloreditor.Click += new System.EventHandler(this.BackgroundButtonClicked);
            // 
            // tb_main
            // 
            this.tb_main.AcceptsTab = true;
            this.tb_main.Location = new System.Drawing.Point(13, 16);
            this.tb_main.Multiline = true;
            this.tb_main.Name = "tb_main";
            this.tb_main.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_main.Size = new System.Drawing.Size(640, 314);
            this.tb_main.TabIndex = 0;
            this.tb_main.TabStop = false;
            this.tb_main.WordWrap = false;
            // 
            // lbl_title1
            // 
            this.lbl_title1.AutoSize = true;
            this.lbl_title1.Font = new System.Drawing.Font("나눔바른고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_title1.ForeColor = System.Drawing.Color.Teal;
            this.lbl_title1.Location = new System.Drawing.Point(664, 269);
            this.lbl_title1.Name = "lbl_title1";
            this.lbl_title1.Size = new System.Drawing.Size(97, 27);
            this.lbl_title1.TabIndex = 3;
            this.lbl_title1.Text = "TextFile";
            // 
            // lbl_title2
            // 
            this.lbl_title2.AutoSize = true;
            this.lbl_title2.Font = new System.Drawing.Font("나눔바른고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_title2.ForeColor = System.Drawing.Color.Teal;
            this.lbl_title2.Location = new System.Drawing.Point(666, 296);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(77, 27);
            this.lbl_title2.TabIndex = 3;
            this.lbl_title2.Text = "Editer";
            // 
            // lbl_textcurrentfile
            // 
            this.lbl_textcurrentfile.AutoSize = true;
            this.lbl_textcurrentfile.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_textcurrentfile.ForeColor = System.Drawing.Color.Teal;
            this.lbl_textcurrentfile.Location = new System.Drawing.Point(10, 345);
            this.lbl_textcurrentfile.Name = "lbl_textcurrentfile";
            this.lbl_textcurrentfile.Size = new System.Drawing.Size(89, 17);
            this.lbl_textcurrentfile.TabIndex = 3;
            this.lbl_textcurrentfile.Text = "Current file:";
            // 
            // lbl_currentfile
            // 
            this.lbl_currentfile.AutoSize = true;
            this.lbl_currentfile.Font = new System.Drawing.Font("나눔바른고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_currentfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_currentfile.Location = new System.Drawing.Point(105, 346);
            this.lbl_currentfile.Name = "lbl_currentfile";
            this.lbl_currentfile.Size = new System.Drawing.Size(0, 16);
            this.lbl_currentfile.TabIndex = 3;
            // 
            // Assignment4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 374);
            this.Controls.Add(this.lbl_title2);
            this.Controls.Add(this.lbl_currentfile);
            this.Controls.Add(this.lbl_textcurrentfile);
            this.Controls.Add(this.lbl_title1);
            this.Controls.Add(this.tb_main);
            this.Controls.Add(this.btn_backgroundcoloreditor);
            this.Controls.Add(this.btn_fonteditor);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Name = "Assignment4";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_open;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroButton btn_fonteditor;
        private MetroFramework.Controls.MetroButton btn_backgroundcoloreditor;
        private System.Windows.Forms.TextBox tb_main;
        private System.Windows.Forms.Label lbl_title1;
        private System.Windows.Forms.Label lbl_title2;
        private System.Windows.Forms.Label lbl_textcurrentfile;
        private System.Windows.Forms.Label lbl_currentfile;
    }
}

