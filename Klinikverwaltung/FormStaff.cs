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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            btnComplete.Enabled = true;
            btnAddStaff.Enabled = false;
            btnChangeStaff.Enabled = true;
            txtId.Enabled = false;
            txtName.Enabled = true;
            txtLastname.Enabled = true;
            txtBirthday.Enabled = true;
            txtSalary.Enabled = true;
            txtProfession.Enabled = true;
        }

        private void btnChangeStaff_Click(object sender, EventArgs e)
        {
            btnComplete.Enabled = true;
            btnChangeStaff.Enabled = false;
            btnAddStaff.Enabled = true;
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtLastname.Enabled = true;
            txtBirthday.Enabled = true;
            txtSalary.Enabled = true;
            txtProfession.Enabled = true;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (!btnAddStaff.Enabled)
            {
                SqlCommunication.createStaff(txtName.Text, txtLastname.Text, txtBirthday.Text, txtSalary.Text, txtProfession.Text);
            }
            else
            {
                SqlCommunication.changeStaff(txtId.Text, txtName.Text, txtLastname.Text, txtBirthday.Text, txtSalary.Text, txtProfession.Text);
            }
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch fs = new FormSearch("TblStaff");
            fs.Show();
        }
    }
}
