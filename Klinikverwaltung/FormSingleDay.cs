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
        private string date = string.Empty;

        public FormSingleDay(string date)
        {
            InitializeComponent();
            this.date = date;
        }

        private void FormSingleDay_Load(object sender, EventArgs e)
        {
            lblDate.Text = date;
        }
    }
}
