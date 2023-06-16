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
    public partial class FormSearch : Form
    {
        private string table;
        public FormSearch(string table)
        {
            InitializeComponent();
            this.table = table;
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = SqlCommunication.fillDataTable(table);
        }
    }
}
