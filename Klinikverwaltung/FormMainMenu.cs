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
    public partial class FormMainMenu : Form
    {
        private string username;
        Panel plCalender = new Panel();
        public FormMainMenu(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            if (SqlCommunication.checkForAdmin(username))
            {
                btnStaff.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCalender fc = new FormCalender();
            Hide();
            fc.ShowDialog();
            Show();
        }

        private void btn_profiles_Click(object sender, EventArgs e)
        {
            FormProfile fp = new FormProfile(false);
            Hide();
            fp.ShowDialog();
            Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FormStaff fs = new FormStaff();
            Hide();
            fs.ShowDialog();
            Show();
        }

        private void btnDienstplan_Click(object sender, EventArgs e)
        {
            FormShift fs = new FormShift();
            fs.ShowDialog();
            Show();
        }
    }
}
