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
    public partial class FormCreateShift : Form
    {
        string id;
        public FormCreateShift(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormCreateShift_Load(object sender, EventArgs e)
        {
            txtId.Text = id;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch fs = new FormSearch("TblStaff");
            fs.Show();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Shift shift = new Shift();

            try
            {
                shift.sId = Convert.ToInt32(txtId.Text);
                shift.startDate = Convert.ToDateTime(txtBeginning.Text);
                shift.endDate = Convert.ToDateTime(txtEnd.Text);
                shift.description = txtDescription.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            SqlCommunication.setShift(shift);
            MessageBox.Show("Neue Schicht erstellt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBeginning_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("") || txtBeginning.Text.Equals("") || txtEnd.Text.Equals("") || txtDescription.Text.Equals(""))
            {
                return;
            }

            btnComplete.Enabled = true;
        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("") || txtBeginning.Text.Equals("") || txtEnd.Text.Equals("") || txtDescription.Text.Equals(""))
            {
                return;
            }

            btnComplete.Enabled = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("") || txtBeginning.Text.Equals("") || txtEnd.Text.Equals("") || txtDescription.Text.Equals(""))
            {
                return;
            }

            btnComplete.Enabled = true;
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("") || txtBeginning.Text.Equals("") || txtEnd.Text.Equals("") || txtDescription.Text.Equals(""))
            {
                return;
            }

            btnComplete.Enabled = true;
        }
    }
}
