namespace Assignment5
{
    partial class InsertIpForm
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
            this.lbl_insertip = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_insertip
            // 
            this.lbl_insertip.AutoSize = true;
            this.lbl_insertip.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_insertip.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_insertip.Location = new System.Drawing.Point(23, 27);
            this.lbl_insertip.Name = "lbl_insertip";
            this.lbl_insertip.Size = new System.Drawing.Size(236, 25);
            this.lbl_insertip.TabIndex = 0;
            this.lbl_insertip.Text = "Input IP and Port number";
            this.lbl_insertip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(93, 75);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(166, 25);
            this.tb_ip.TabIndex = 1;
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(93, 124);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(166, 25);
            this.tb_port.TabIndex = 1;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ip.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_ip.Location = new System.Drawing.Point(27, 75);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(28, 25);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "IP";
            this.lbl_ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_port.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_port.Location = new System.Drawing.Point(23, 124);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(48, 25);
            this.lbl_port.TabIndex = 0;
            this.lbl_port.Text = "Port";
            this.lbl_port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OKButtonClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelButtonClicked);
            // 
            // InsertIpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 231);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.lbl_insertip);
            this.Name = "InsertIpForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_insertip;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}