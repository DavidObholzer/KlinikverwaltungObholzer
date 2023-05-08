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
    public partial class FormShift : Form
    {
        DateTime savedDate = new DateTime();
        List<Label> lDateLabels = new List<Label>();

        public FormShift()
        {
            InitializeComponent();
        }

        private void FormShift_Load(object sender, EventArgs e)
        {
            int topValue = 0;
            int leftValue = 0;
            int startTime = 0;
            int endTime = 1;

            //gets todays date
            DateTime dateOfToday = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            savedDate = dateOfToday;

            int dayAddition = 0;
            switch (dateOfToday.DayOfWeek)
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

            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 24; i2++)
                {
                    Panel pnlNew = new Panel();
                    pnlNew.Top = topValue;
                    pnlNew.Left = leftValue;
                    pnlNew.Height = 15;
                    pnlNew.Width = 110;
                    pnlNew.BorderStyle = BorderStyle.FixedSingle;
                    pnlTimetable.Controls.Add(pnlNew);

                    Label lblNew = new Label();
                    lblNew.Text = startTime + ":00 - " + endTime + ":00";
                    lblNew.Left = pnlNew.Width / 2 - lblNew.Width / 4;
                    pnlNew.Controls.Add(lblNew);

                    topValue += pnlNew.Height;
                    startTime++;
                    endTime++;
                }

                topValue = 0;
                leftValue += 110;
                startTime = 0;
                endTime = 1;

                Label lblNewDate = new Label();
                lblNewDate.Text = savedDate.AddDays(dayAddition).ToString("D");
                lblNewDate.Top = pnlTimetable.Top - 20;
                lblNewDate.Left = -85 + leftValue;
                lDateLabels.Add(lblNewDate);
                Controls.Add(lblNewDate);

                dayAddition++;
            }
        }

        public void updateLabels(bool forward)
        {
            //gets todays date
            DateTime dateOfToday = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            

            int dayAddition = 0;
            switch (dateOfToday.DayOfWeek)
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

            if (forward)
            {
                savedDate = savedDate.AddDays(7);
            }
            else
            {
                savedDate = savedDate.AddDays(-7);
            }

            foreach (Label lbl in lDateLabels)
            {
                lbl.Text = savedDate.AddDays(dayAddition).ToString("D");
                dayAddition++;
            }
        }

        private void btnBackWeek_Click(object sender, EventArgs e)
        {
            updateLabels(false);
        }

        private void btnForwardWeek_Click(object sender, EventArgs e)
        {
            updateLabels(true);
        }
    }
}
