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
    public partial class FormAppointment : Form
    {
        private DateTime date;
        public FormAppointment(DateTime date)
        {
            this.date = date;
            InitializeComponent();
        }

        public void checkForNullValues()
        {
            if (txtDate.Text.Equals("") || txtPatient.Text.Equals("") ||
                txtRoom.Text.Equals("") || txtStaff.Text.Equals(""))
            {
                btn_addAppointment.Enabled = false;
            }
            else if (!Int32.TryParse(txtPatient.Text, out int unused) || !Int32.TryParse(txtStaff.Text, out int unused2))
            {
                MessageBox.Show("Nur natürliche Zahlen (ohne 0) bei den IDs eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_addAppointment.Enabled = false;
            }
            else
            {
                btn_addAppointment.Enabled = true;
            }
        }

        private void btn_addAppointment_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Equals(""))
            {
                SqlCommunication.setAppointment(txtPatient.Text, txtStaff.Text, txtDate.Text, txtRoom.Text, "");
            }
            else
            {
                SqlCommunication.setAppointment(txtPatient.Text, txtStaff.Text, txtDate.Text, txtRoom.Text, txtDescription.Text);
            }

            MessageBox.Show("Termin erstellt", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPatient.Text = "";
            txtStaff.Text = "";
            txtDate.Text = "";
            txtRoom.Text = "";
            txtDescription.Text = "";
        }

        private void txtPatient_TextChanged(object sender, EventArgs e)
        {
            checkForNullValues();
        }

        private void txtStaff_TextChanged(object sender, EventArgs e)
        {
            checkForNullValues();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            checkForNullValues();
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {
            checkForNullValues();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            FormSearch fs = new FormSearch("TblPatient");
            fs.Show();
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            FormSearch fs = new FormSearch("TblStaff");
            fs.Show();
        }
    }
}
