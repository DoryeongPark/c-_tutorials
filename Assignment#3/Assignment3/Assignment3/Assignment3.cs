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

    /*
     * Assignment3
     * Program which's able to show current calendar and display next or previous calendar by button  
     */
    public partial class Assignment3 : MetroForm
    {
        public Assignment3()
        {
            InitializeComponent();
        }

        DateTime currentDateTimePage;
    
        /* Load current date and apply it to components. */
        private void onLoad(object sender, EventArgs e)
        {
            GregorianCalendar gc = new GregorianCalendar();

            currentDateTimePage = DateTime.Today;
            lbl_month.Text = Convert.ToString(gc.GetMonth(currentDateTimePage));
            lbl_year.Text = Convert.ToString(gc.GetYear(currentDateTimePage));

            grid_calendar.DefaultCellStyle.Font = new Font("맑은 고딕", 13);
            grid_calendar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in grid_calendar.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Font = new Font("맑은 고딕", 11, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            UpdateGridView(currentDateTimePage);
            
        }

        /* 
         * Updates Datagridview as parameter 
         * dateTime: Date user wanna apply to Calendar
         * ex)  User wants to look up calendar containing 2016/8/23 
         *      -> UpdateGridView(Datetime(2016/8/23)) ]
         *      -> Calendar(DataGridView) updated
         */
        private void UpdateGridView(DateTime dateTime)
        {
            grid_calendar.Rows.Clear();
            
            var dw = new DayOfWeek();
            var monthCount = GetDayCountInMonth(currentDateTimePage, out dw);
            var weekday = ParseWeekDayToInteger(dw);

            var index = grid_calendar.Rows.Add();

            /* From 1st to last day of month */
            for (int i = 1; i <= monthCount; ++i)
            {
                grid_calendar.Rows[index].Cells[weekday++].Value = Convert.ToString(i);

                /* If current weekday is Saturday then insert new row */
                if (weekday == 7)
                {
                    index = grid_calendar.Rows.Add();
                    weekday = 0;
                }
            }
        }

        /* Returns Date's maximum day count in month and 1st day's weekday  */
        private int GetDayCountInMonth(DateTime dateTime, out DayOfWeek weekDay)
        {
            GregorianCalendar gc = new GregorianCalendar();

            /* Total day count of next month - Total day count of current month = current month's day count */
            var firstOfCurrent = new DateTime(dateTime.Year, dateTime.Month, 1);
            DateTime lastOfCurrent;

            if (dateTime.Month != 12)
            {
                lastOfCurrent = new DateTime(dateTime.Year, dateTime.Month + 1, 1);
                weekDay = gc.GetDayOfWeek(firstOfCurrent);
                return gc.GetDayOfYear(lastOfCurrent) - gc.GetDayOfYear(firstOfCurrent);
            }
            else // If parameter's month is 12, lastOfCurrent needs to be 12/31
            {
                lastOfCurrent = new DateTime(dateTime.Year, 12, 31);
                weekDay = gc.GetDayOfWeek(firstOfCurrent);
                return gc.GetDayOfYear(lastOfCurrent) - gc.GetDayOfYear(firstOfCurrent) + 1;
            }            
        }

        /* Parse WeekDay with string to number */
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

        /* Update label and calendar(DataGridView) with previous month from current date */
        private void LeftClick(object sender, EventArgs e)
        {
            GregorianCalendar gc = new GregorianCalendar();
            currentDateTimePage = gc.AddMonths(currentDateTimePage, -1); //Decrements month to current date
            UpdateGridView(currentDateTimePage);
            lbl_month.Text = Convert.ToString(gc.GetMonth(currentDateTimePage));
            lbl_year.Text = Convert.ToString(gc.GetYear(currentDateTimePage));
        }

        /* Update label and calendar(DataGridView) with next month from current date */
        private void RightClick(object sender, EventArgs e)
        {
            GregorianCalendar gc = new GregorianCalendar();
            currentDateTimePage = gc.AddMonths(currentDateTimePage, 1);//Increments month to current date
            UpdateGridView(currentDateTimePage);
            lbl_month.Text = Convert.ToString(gc.GetMonth(currentDateTimePage));
            lbl_year.Text = Convert.ToString(gc.GetYear(currentDateTimePage));
        }
    }
}
