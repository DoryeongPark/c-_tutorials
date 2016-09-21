namespace Assignment0
{
    partial class Assignment0
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
            this.btn_main = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_main.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_main.Location = new System.Drawing.Point(23, 41);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(44, 25);
            this.lbl_main.TabIndex = 0;
            this.lbl_main.Text = "Test";
            this.lbl_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_main
            // 
            this.btn_main.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_main.Location = new System.Drawing.Point(105, 106);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(83, 33);
            this.btn_main.TabIndex = 1;
            this.btn_main.Text = "Send";
            this.btn_main.UseSelectable = true;
            this.btn_main.Click += new System.EventHandler(this.MainButtonClicked);
            // 
            // Assignment0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 174);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.lbl_main);
            this.Name = "Assignment0";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_main;
        private MetroFramework.Controls.MetroButton btn_main;
    }
}

