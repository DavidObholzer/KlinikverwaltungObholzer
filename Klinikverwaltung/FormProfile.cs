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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            btnAddProfile.Enabled = false;
            txtId.Enabled = false;
            btnDeleteProfile.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtPassword2.Enabled = true;
            chbAdmin.Enabled = true;
            
            
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            btnAddProfile.Enabled = true;
            txtId.Enabled = true;
            btnDeleteProfile.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword2.Enabled = false;
            chbAdmin.Enabled = false;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (!btnAddProfile.Enabled)
            {
                if (chbAdmin.Checked)
                {
                    SqlCommunication.insertIntoUser(txtUsername.Text, txtPassword.Text, "true");
                }
                else
                {
                    SqlCommunication.insertIntoUser(txtUsername.Text, txtPassword.Text, "false");
                }
            }
            else
            {
                SqlCommunication.deleteUser(txtId.Text);
            }
        }
    }
}
