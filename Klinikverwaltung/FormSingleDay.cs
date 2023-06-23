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
    public partial class FormSingleDay : Form
    {
        private DateTime date;
        List<Panel> lsPanel = new List<Panel>();

        public FormSingleDay(DateTime date)
        {
            InitializeComponent();
            this.date = date;
        }

        private void FormSingleDay_Load(object sender, EventArgs e)
        {
            lblDate.Text = date.ToString("dd. MMMM yyyy");
            updatePanelLayout();
        }

        public void pnlNew_Click(object? sender, EventArgs e)
        {
            Panel? pnlNew = sender as Panel;

            if (MessageBox.Show("Wollen Sie diesen Termin löschen?", "Löschen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommunication.deleteAppointment(Convert.ToInt32(pnlNew.Tag));
                pnlNew.Dispose();
            }

            updatePanelLayout();
        }

        public void lblNew_Click(object? sender, EventArgs e)
        {
            Label? lblNew = sender as Label;

            if (MessageBox.Show("Wollen Sie diesen Termin löschen?", "Löschen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommunication.deleteAppointment(Convert.ToInt32(lblNew.Tag));
                
                foreach (Panel p in lsPanel)
                {
                    if (p.Tag.Equals(lblNew.Tag))
                    {
                        p.Dispose();
                    }
                }
            }

            updatePanelLayout();
        }

        public void updatePanelLayout()
        {
            List<Appointment> la = SqlCommunication.getAppointments(date.ToString("yyyy-MM-dd"));

            lsPanel.Clear();
            pnlSingleDay.Controls.Clear();

            //create buttons for each appointment
            int topValue = 10;
            int leftValue = 5;

            //for loop to get create buttons in a new row after 5 panels have been created
            //idk about the calculation rn though
            int numberOfRows = Convert.ToInt32(Math.Round(la.Count / 5 + 0.5, MidpointRounding.AwayFromZero));
            int iAppointmentCount = 0;
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int i2 = 0; i2 < 5 && iAppointmentCount < la.Count; i2++)
                {
                    Panel pnlNew = new Panel();
                    pnlNew.Top = topValue;
                    pnlNew.Left = leftValue;
                    pnlNew.Height = 154;
                    pnlNew.Width = 154;
                    pnlNew.BorderStyle = BorderStyle.FixedSingle;
                    pnlNew.Click += pnlNew_Click;
                    pnlNew.Tag = la[iAppointmentCount].id;
                    pnlSingleDay.Controls.Add(pnlNew);
                    lsPanel.Add(pnlNew);

                    leftValue += pnlNew.Width + 5;
                    iAppointmentCount++;
                }
                pnlSingleDay.Height += 164;
                topValue += 164;
                leftValue = 5;
            }

            //creates the labels for each appointment - not all info showed
            int i3 = 0;
            foreach (Panel p in lsPanel)
            {
                Label lblNewPatient = new Label();

                lblNewPatient.Text = la[i3].patient;
                lblNewPatient.Top = 10;
                lblNewPatient.Left = 5;
                lblNewPatient.Tag = p.Tag;
                lblNewPatient.Click += lblNew_Click;
                p.Controls.Add(lblNewPatient);

                Label lblNewStaff = new Label();

                lblNewStaff.Text = la[i3].staff;
                lblNewStaff.Top = lblNewPatient.Height + lblNewPatient.Top + 5;
                lblNewStaff.Left = 5;
                lblNewStaff.Tag = p.Tag;
                lblNewStaff.Click += lblNew_Click;
                p.Controls.Add(lblNewStaff);

                Label lblNewRoom = new Label();

                lblNewRoom.Text = la[i3].room;
                lblNewRoom.Top = lblNewStaff.Height + lblNewStaff.Top + 5;
                lblNewRoom.Left = 5;
                lblNewRoom.Tag = p.Tag;
                lblNewRoom.Click += lblNew_Click;
                p.Controls.Add(lblNewRoom);

                i3++;
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            FormAppointment fa = new FormAppointment(date);
            
            this.Hide();
            fa.ShowDialog();
            this.Show();

            updatePanelLayout();
        }
    }
}
