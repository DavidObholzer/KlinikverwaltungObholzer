using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klinikverwaltung
{
    public partial class FormCalender : Form
    {
        static List<Panel> lpnl = new List<Panel>();
        static List<Label> llbl = new List<Label>();
        static DateTime savedDate; 

        public FormCalender()
        {
            InitializeComponent();
        }

        private void FormCalender_Load(object sender, EventArgs e)
        {
            lblYearAndMonth.Text = DateTime.Today.ToString("MMMM yyyy");

            //create panels for each day on the calender
            int topValue = 100;
            int leftValue = 3;

            for (int i=0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    Panel pnlNew = new Panel();
                    pnlNew.Top = topValue;
                    pnlNew.Left = leftValue;
                    pnlNew.Height = 54;
                    pnlNew.Width = 110;
                    pnlNew.BorderStyle = BorderStyle.FixedSingle;
                    lpnl.Add(pnlNew);
                    pnlCalender.Controls.Add(pnlNew);

                    leftValue += pnlNew.Width;
                }
                topValue += 54;
                leftValue = 3;
            }

            //get a date of the first day of current month
            DateTime dateOfFirstDay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            savedDate = dateOfFirstDay;

            int dayAddition = 0;
            switch (dateOfFirstDay.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dayAddition = 0;
                    break;

                case DayOfWeek.Tuesday:
                    dayAddition = -1;
                    break;

                case DayOfWeek.Wednesday:
                    dayAddition = -2;
                    break;

                case DayOfWeek.Thursday:
                    dayAddition = -3;
                    break;

                case DayOfWeek.Friday:
                    dayAddition = -4;
                    break;

                case DayOfWeek.Saturday:
                    dayAddition = -5;
                    break;

                case DayOfWeek.Sunday:
                    dayAddition = -6;
                    break;
            }

            foreach (Panel p in lpnl)
            {
                Label lblNew = new Label();

                if (dateOfFirstDay.AddDays(dayAddition).Month != dateOfFirstDay.Month)
                    lblNew.ForeColor = Color.Silver;

                lblNew.Text = dateOfFirstDay.AddDays(dayAddition).Day.ToString();
                lblNew.Top = p.Height / 2 - 7;
                lblNew.Left = p.Width / 2 - 3;
                llbl.Add(lblNew);
                p.Controls.Add(lblNew);

                dayAddition++;
            }
        }

        public void updateLabel(bool forward)
        {
            //get a date of the first day of next or last month
            DateTime dateOfFirstDay;

            if (forward)
            {
                dateOfFirstDay = new DateTime(savedDate.Year, savedDate.AddMonths(1).Month, 1);
            }
            else
            {  
                dateOfFirstDay = new DateTime(savedDate.Year, savedDate.AddMonths(-1).Month, 1);
            }

            lblYearAndMonth.Text = dateOfFirstDay.ToString("MMMM yyyy");
            savedDate = dateOfFirstDay;

            int dayAddition = 0;
            switch (dateOfFirstDay.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dayAddition = 0;
                    break;

                case DayOfWeek.Tuesday:
                    dayAddition = -1;
                    break;

                case DayOfWeek.Wednesday:
                    dayAddition = -2;
                    break;

                case DayOfWeek.Thursday:
                    dayAddition = -3;
                    break;

                case DayOfWeek.Friday:
                    dayAddition = -4;
                    break;

                case DayOfWeek.Saturday:
                    dayAddition = -5;
                    break;

                case DayOfWeek.Sunday:
                    dayAddition = -6;
                    break;
            }

            foreach (Label lbl in llbl)
            {
                lbl.Text = dateOfFirstDay.AddDays(dayAddition).Day.ToString();

                if (dateOfFirstDay.AddDays(dayAddition).Month != dateOfFirstDay.Month)
                    lbl.ForeColor = Color.Silver;
                else
                    lbl.ForeColor = Color.Black;

                dayAddition++;
            }
        }

        private void btnBackMonth_Click(object sender, EventArgs e)
        {
            updateLabel(false);
        }

        private void btnForwardMonth_Click(object sender, EventArgs e)
        {
            updateLabel(true);
        }
    }
}
