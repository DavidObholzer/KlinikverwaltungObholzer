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
        List<string> lsPatient = new List<string>();
        List<string> lsStaff = new List<string>();
        List<string> lsRoomName = new List<string>();
        List<string> lsId = new List<string>();
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
            
            MessageBox.Show(pnlNew.Tag.ToString());

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

            MessageBox.Show(lblNew.Tag.ToString());

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
            List<List<string>> lsTemp = SqlCommunication.getAppointments(date.ToString("yyyy-MM-dd"));
            lsPatient = lsTemp[0];
            lsStaff = lsTemp[1];
            lsRoomName = lsTemp[2];
            lsId = lsTemp[3];

            lsPanel.Clear();
            pnlSingleDay.Controls.Clear();

            //create buttons for each appointment
            int topValue = 10;
            int leftValue = 5;

            //for loop to get create buttons in a new row after 5 panels have been created
            //idk about the calculation rn though
            int numberOfRows = Convert.ToInt32(Math.Round(lsPatient.Count / 5 + 0.5, MidpointRounding.AwayFromZero));
            int iAppointmentCount = 0;
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int i2 = 0; i2 < 5 && iAppointmentCount < lsPatient.Count; i2++)
                {
                    Panel pnlNew = new Panel();
                    pnlNew.Top = topValue;
                    pnlNew.Left = leftValue;
                    pnlNew.Height = 154;
                    pnlNew.Width = 154;
                    pnlNew.BorderStyle = BorderStyle.FixedSingle;
                    pnlNew.Click += pnlNew_Click;
                    pnlNew.Tag = lsId[iAppointmentCount];
                    pnlSingleDay.Controls.Add(pnlNew);
                    lsPanel.Add(pnlNew);

                    leftValue += pnlNew.Width + 5;
                    iAppointmentCount++;
                }
                pnlSingleDay.Height += 164;
                topValue += 164;
                leftValue = 5;
            }

            //creates the labels for each appointment
            int i3 = 0;
            foreach (Panel p in lsPanel)
            {
                Label lblNew = new Label();
                
                lblNew.Text = lsPatient[i3];
                lblNew.Top = p.Height / 2 - lblNew.Height / 2;
                lblNew.Left = p.Width / 2 - lblNew.Width / 2;
                lblNew.Tag = p.Tag;
                lblNew.Click += lblNew_Click;
                p.Controls.Add(lblNew);
                i3++;
            }
        }
    }
}
