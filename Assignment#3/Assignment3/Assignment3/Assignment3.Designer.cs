﻿namespace Assignment3
{
    partial class Assignment3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stylemanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lbl_month = new System.Windows.Forms.Label();
            this.grid_calendar = new MetroFramework.Controls.MetroGrid();
            this.col_sun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_wed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_leftbutton = new System.Windows.Forms.Label();
            this.lbl_rightbutton = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // stylemanager
            // 
            this.stylemanager.Owner = this;
            this.stylemanager.Style = MetroFramework.MetroColorStyle.Red;
            this.stylemanager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Font = new System.Drawing.Font("나눔바른고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_month.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_month.Location = new System.Drawing.Point(221, 33);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(63, 43);
            this.lbl_month.TabIndex = 0;
            this.lbl_month.Text = "00";
            this.lbl_month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_month.UseMnemonic = false;
            // 
            // grid_calendar
            // 
            this.grid_calendar.AllowUserToAddRows = false;
            this.grid_calendar.AllowUserToDeleteRows = false;
            this.grid_calendar.AllowUserToResizeColumns = false;
            this.grid_calendar.AllowUserToResizeRows = false;
            this.grid_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_calendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grid_calendar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_calendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_calendar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_calendar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_calendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_calendar.ColumnHeadersHeight = 20;
            this.grid_calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_calendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_sun,
            this.col_mon,
            this.col_tue,
            this.col_wed,
            this.col_thu,
            this.col_fri,
            this.col_sat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_calendar.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_calendar.Enabled = false;
            this.grid_calendar.EnableHeadersVisualStyles = false;
            this.grid_calendar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_calendar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_calendar.Location = new System.Drawing.Point(40, 84);
            this.grid_calendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_calendar.MultiSelect = false;
            this.grid_calendar.Name = "grid_calendar";
            this.grid_calendar.ReadOnly = true;
            this.grid_calendar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_calendar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_calendar.RowHeadersWidth = 10;
            this.grid_calendar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_calendar.RowTemplate.Height = 27;
            this.grid_calendar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_calendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_calendar.Size = new System.Drawing.Size(407, 224);
            this.grid_calendar.TabIndex = 1;
            // 
            // col_sun
            // 
            this.col_sun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_sun.HeaderText = "SUN";
            this.col_sun.Name = "col_sun";
            this.col_sun.ReadOnly = true;
            this.col_sun.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_sun.Width = 57;
            // 
            // col_mon
            // 
            this.col_mon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_mon.HeaderText = "MON";
            this.col_mon.Name = "col_mon";
            this.col_mon.ReadOnly = true;
            this.col_mon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_mon.Width = 63;
            // 
            // col_tue
            // 
            this.col_tue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_tue.HeaderText = "TUE";
            this.col_tue.Name = "col_tue";
            this.col_tue.ReadOnly = true;
            this.col_tue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_tue.Width = 55;
            // 
            // col_wed
            // 
            this.col_wed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_wed.HeaderText = "WED";
            this.col_wed.Name = "col_wed";
            this.col_wed.ReadOnly = true;
            this.col_wed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_wed.Width = 59;
            // 
            // col_thu
            // 
            this.col_thu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_thu.HeaderText = "THU";
            this.col_thu.Name = "col_thu";
            this.col_thu.ReadOnly = true;
            this.col_thu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_thu.Width = 58;
            // 
            // col_fri
            // 
            this.col_fri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_fri.HeaderText = "FRI";
            this.col_fri.Name = "col_fri";
            this.col_fri.ReadOnly = true;
            this.col_fri.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_fri.Width = 50;
            // 
            // col_sat
            // 
            this.col_sat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_sat.HeaderText = "SAT";
            this.col_sat.Name = "col_sat";
            this.col_sat.ReadOnly = true;
            this.col_sat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_sat.Width = 54;
            // 
            // lbl_leftbutton
            // 
            this.lbl_leftbutton.AutoSize = true;
            this.lbl_leftbutton.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_leftbutton.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_leftbutton.Location = new System.Drawing.Point(39, 41);
            this.lbl_leftbutton.Name = "lbl_leftbutton";
            this.lbl_leftbutton.Size = new System.Drawing.Size(41, 34);
            this.lbl_leftbutton.TabIndex = 2;
            this.lbl_leftbutton.Text = "<<";
            this.lbl_leftbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_leftbutton.Click += new System.EventHandler(this.LeftButtonClicked);
            // 
            // lbl_rightbutton
            // 
            this.lbl_rightbutton.AutoSize = true;
            this.lbl_rightbutton.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_rightbutton.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_rightbutton.Location = new System.Drawing.Point(375, 41);
            this.lbl_rightbutton.Name = "lbl_rightbutton";
            this.lbl_rightbutton.Size = new System.Drawing.Size(41, 34);
            this.lbl_rightbutton.TabIndex = 2;
            this.lbl_rightbutton.Text = ">>";
            this.lbl_rightbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_rightbutton.Click += new System.EventHandler(this.RightButtonClicked);
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_year.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_year.Location = new System.Drawing.Point(175, 45);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(49, 19);
            this.lbl_year.TabIndex = 3;
            this.lbl_year.Text = "0000";
            this.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Assignment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 311);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_rightbutton);
            this.Controls.Add(this.lbl_leftbutton);
            this.Controls.Add(this.grid_calendar);
            this.Controls.Add(this.lbl_month);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Assignment3";
            this.Padding = new System.Windows.Forms.Padding(22, 80, 22, 27);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_calendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager stylemanager;
        private System.Windows.Forms.Label lbl_month;
        private MetroFramework.Controls.MetroGrid grid_calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sun;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_wed;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fri;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sat;
        private System.Windows.Forms.Label lbl_rightbutton;
        private System.Windows.Forms.Label lbl_leftbutton;
        private System.Windows.Forms.Label lbl_year;
    }
}

