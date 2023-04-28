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
        Panel plCalender = new Panel();
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            
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
            FormProfile fp = new FormProfile();
            Hide();
            fp.ShowDialog();
            Show();
        }
    }
}
