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
    public partial class FormShift : Form
    {
        public FormShift()
        {
            InitializeComponent();
        }

        private void FormShift_Load(object sender, EventArgs e)
        {
            int topValue = 0;
            int leftValue = 0;

            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 24; i2++)
                {
                    Panel pnlNew = new Panel();
                    pnlNew.Top = topValue;
                    pnlNew.Left = leftValue;
                    pnlNew.Height = 15;
                    pnlNew.Width = 110;
                    pnlNew.BorderStyle = BorderStyle.FixedSingle;
                    pnlTimetable.Controls.Add(pnlNew);

                    topValue += pnlNew.Height;
                }
                topValue = 0;
                leftValue += 110;
            }
        }
    }
}
