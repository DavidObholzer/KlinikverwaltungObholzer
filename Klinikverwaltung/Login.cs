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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cbxSSIP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSSIP.Checked)
            {
                txtPassword.Enabled = false;
                txtUser.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true;
                txtUser.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbxSSIP.Checked)
            {
                SqlCommunication.LoginSSIP();
            }
            else
            {
                if (SqlCommunication.LoginNoSSIP(txtUser.Text, txtPassword.Text))
                {
                    //continue to next form
                }
                else
                {

                }
            }
        }
    }
}
