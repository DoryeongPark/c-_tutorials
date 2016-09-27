namespace Assignment3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lbl_month.Location = new System.Drawing.Point(221, 48);
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
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_calendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
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
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_calendar.DefaultCellStyle = dataGridViewCellStyle41;
            this.grid_calendar.Enabled = false;
            this.grid_calendar.EnableHeadersVisualStyles = false;
            this.grid_calendar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_calendar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_calendar.Location = new System.Drawing.Point(40, 91);
            this.grid_calendar.MultiSelect = false;
            this.grid_calendar.Name = "grid_calendar";
            this.grid_calendar.ReadOnly = true;
            this.grid_calendar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_calendar.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.grid_calendar.RowHeadersWidth = 10;
            this.grid_calendar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_calendar.RowTemplate.Height = 27;
            this.grid_calendar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_calendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_calendar.Size = new System.Drawing.Size(407, 221);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "<<";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.LeftClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(375, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = ">>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.RightClick);
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_year.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_year.Location = new System.Drawing.Point(175, 60);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(49, 19);
            this.lbl_year.TabIndex = 3;
            this.lbl_year.Text = "0000";
            this.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Assignment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 318);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_calendar);
            this.Controls.Add(this.lbl_month);
            this.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Assignment3";
            this.Padding = new System.Windows.Forms.Padding(22, 68, 22, 23);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_year;
    }
}

