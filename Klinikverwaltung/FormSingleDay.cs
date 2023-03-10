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

        public FormSingleDay(DateTime date)
        {
            InitializeComponent();
            this.date = date;
        }

        private void FormSingleDay_Load(object sender, EventArgs e)
        {
            lblDate.Text = date.ToString("dd. MMMM yyyy");
            List<List<string>> lsTemp = SqlCommunication.getAppointments(date.ToString("yyyy-MM-dd"));
            lsPatient = lsTemp[0];
            lsStaff = lsTemp[1];
            lsRoomName = lsTemp[2];
            

            //create buttons for each appointment
            int topValue = 100;
            int leftValue = 3;

            //for loop to get create buttons in a new row after 5 panels have been created
            //idk about the calculation rn though
            for (int i = 0; i < lsPatient.Count / 5 + 0.9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    Panel pnlNew = new Panel();
                    pnlNew.Top = topValue;
                    pnlNew.Left = 0;
                    pnlNew.Height = 140;
                    pnlNew.Width = 140;
                    pnlNew.BorderStyle = BorderStyle.FixedSingle;
                    pnlNew.Click += pnlNew_Click;
                    pnlSingleDay.Controls.Add(pnlNew);

                    leftValue += pnlNew.Width+5;
                }
                topValue += 140;
                leftValue = 0;
            }
        }

        public void pnlNew_Click(object sender, EventArgs e)
        {
            Panel? pnlNew = sender as Panel;
            
            if(MessageBox.Show("Wollen Sie diesen Termin löschen?", "Löschen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pnlNew.Dispose();
            }
        }
    }
}
