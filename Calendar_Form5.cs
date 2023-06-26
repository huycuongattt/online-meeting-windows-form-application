using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Calendar_Form5 : Form
    {
        int month, year;
        public static int static_month, static_year;
        public Calendar_Form5()
        {
            InitializeComponent();
        }

        private void Calendar_Form5_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            //LETS get the first day of the month.
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //first lets create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++) {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucdays = new UserControlDay();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }

        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++;
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            //LETS get the first day of the month.
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //first lets create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucdays = new UserControlDay();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            if (month == 1)
            {
                month = 13;
                year--;
            }
            month--;
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            //LETS get the first day of the month.
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            //first lets create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            //now lets create usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucdays = new UserControlDay();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
