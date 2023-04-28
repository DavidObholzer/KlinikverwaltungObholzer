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

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            btnAddProfile.Enabled = false;
            btnChangeProfile.Enabled = true;
            txtId.Enabled = false;
            txtName.Enabled = true;
            txtLastname.Enabled = true;
            txtBirthday.Enabled = true;
            txtSalary.Enabled = true;
            txtProfession.Enabled = true;
        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            btnChangeProfile.Enabled = false;
            btnAddProfile.Enabled = true;
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtLastname.Enabled = true;
            txtBirthday.Enabled = true;
            txtSalary.Enabled = true;
            txtProfession.Enabled = true;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

        }
    }
}
