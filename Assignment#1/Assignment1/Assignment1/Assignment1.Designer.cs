namespace Assignment1
{
    partial class Assignment1
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
            this.btn_color = new MetroFramework.Controls.MetroButton();
            this.btn_label = new MetroFramework.Controls.MetroButton();
            this.btn_msgbox = new MetroFramework.Controls.MetroButton();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_main.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_main.Location = new System.Drawing.Point(14, 71);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(80, 25);
            this.lbl_main.TabIndex = 0;
            this.lbl_main.Text = "Exercise";
            this.lbl_main.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(208, 71);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(101, 41);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Change Color";
            this.btn_color.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_color.UseSelectable = true;
            this.btn_color.Click += new System.EventHandler(this.ChangeColorButtonClicked);
            // 
            // btn_label
            // 
            this.btn_label.Location = new System.Drawing.Point(208, 118);
            this.btn_label.Name = "btn_label";
            this.btn_label.Size = new System.Drawing.Size(101, 41);
            this.btn_label.TabIndex = 1;
            this.btn_label.Text = "Change Text";
            this.btn_label.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_label.UseSelectable = true;
            this.btn_label.Click += new System.EventHandler(this.ChangeTextButtonClicked);
            // 
            // btn_msgbox
            // 
            this.btn_msgbox.Location = new System.Drawing.Point(208, 165);
            this.btn_msgbox.Name = "btn_msgbox";
            this.btn_msgbox.Size = new System.Drawing.Size(101, 41);
            this.btn_msgbox.TabIndex = 1;
            this.btn_msgbox.Text = "MessageBox";
            this.btn_msgbox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_msgbox.UseSelectable = true;
            this.btn_msgbox.Click += new System.EventHandler(this.MessageBoxClicked);
            // 
            // pnl_main
            // 
            this.pnl_main.Location = new System.Drawing.Point(14, 111);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(173, 95);
            this.pnl_main.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 229);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.btn_msgbox);
            this.Controls.Add(this.btn_label);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.lbl_main);
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Load += new System.EventHandler(this.LoadForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_main;
        private MetroFramework.Controls.MetroButton btn_color;
        private MetroFramework.Controls.MetroButton btn_label;
        private MetroFramework.Controls.MetroButton btn_msgbox;
        private System.Windows.Forms.Panel pnl_main;
    }
}

