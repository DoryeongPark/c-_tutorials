using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Globalization;

namespace Assignment3
{
    public partial class Assignment3 : MetroForm
    {
        public Assignment3()
        {
            InitializeComponent();
        }

        DateTime currentDateTimePage;
    
        private void onLoad(object sender, EventArgs e)
        {
            GregorianCalendar gc = new GregorianCalendar();

            currentDateTimePage = DateTime.Today;
            lbl_month.Text = Convert.ToString(gc.GetMonth(currentDateTimePage));
            lbl_year.Text = Convert.ToString(gc.GetYear(currentDateTimePage));

            grid_calendar.DefaultCellStyle.Font = new Font("나눔바른고딕", 13);
            grid_calendar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in grid_calendar.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Font = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            UpdateGridView(currentDateTimePage);
            
        }

        private void UpdateGridView(DateTime dateTime)
        {
            grid_calendar.Rows.Clear();
            
            var dw = new DayOfWeek();
            var monthCount = GetDayCountInMonth(currentDateTimePage, out dw);
            var weekday = ParseWeekDayToInteger(dw);

            var index = grid_calendar.Rows.Add();

            for (int i = 1; i <= monthCount; ++i)
            {
                grid_calendar.Rows[index].Cells[weekday++].Value = Convert.ToString(i);
                
                if (weekday == 7)
                {
                    index = grid_calendar.Rows.Add();
                    weekday = 0;
                }
            }
        }

        private int GetDayCountInMonth(DateTime dateTime, out DayOfWeek weekDay)
        {
            GregorianCalendar gc = new GregorianCalendar();

            var firstOfCurrent = new DateTime(dateTime.Year, dateTime.Month, 1);
            DateTime lastOfCurrent;

            if (dateTime.Month != 12)
            {
                lastOfCurrent = new DateTime(dateTime.Year, dateTime.Month + 1, 1);
                weekDay = gc.GetDayOfWeek(firstOfCurrent);
                return gc.GetDayOfYear(lastOfCurrent) - gc.GetDayOfYear(firstOfCurrent);
            }
            else
            {
                lastOfCurrent = new DateTime(dateTime.Year, 12, 31);
                weekDay = gc.GetDayOfWeek(firstOfCurrent);
                return gc.GetDayOfYear(lastOfCurrent) - gc.GetDayOfYear(firstOfCurrent) + 1;
            }            
        }

        private int ParseWeekDayToInteger(DayOfWeek weekDay)
        {
            switch (weekDay.ToString())
            {
                case "Sunday":
                    return 0;
                case "Monday":
                    return 1;
                case "Tuesday":
                    return 2;
                case "Wednesday":
                    return 3;
                case "Thursday":
                    return 4;
                case "Friday":
                    return 5;
                case "Saturday":
                    return 6;
                default:
                    return -1;
            }

        }

        private void LeftClick(object sender, EventArgs e)
        {
            GregorianCalendar gc = new GregorianCalendar();
            currentDateTimePage = gc.AddMonths(currentDateTimePage, -1);
            UpdateGridView(currentDateTimePage);
            lbl_month.Text = Convert.ToString(gc.GetMonth(currentDateTimePage));
            lbl_year.Text = Convert.ToString(gc.GetYear(currentDateTimePage));
        }

        private void RightClick(object sender, EventArgs e)
        {
            GregorianCalendar gc = new GregorianCalendar();
            currentDateTimePage = gc.AddMonths(currentDateTimePage, 1);
            UpdateGridView(currentDateTimePage);
            lbl_month.Text = Convert.ToString(gc.GetMonth(currentDateTimePage));
            lbl_year.Text = Convert.ToString(gc.GetYear(currentDateTimePage));
        }
    }
}
