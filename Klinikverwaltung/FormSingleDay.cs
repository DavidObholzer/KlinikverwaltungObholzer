﻿using System;
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
        List<string> lsPatient = new List<string>();
        List<string> lsStaff = new List<string>();
        List<string> lsRoomName = new List<string>();

        public FormSingleDay(string date)
        {
            InitializeComponent();
            this.date = date;
        }

        private void FormSingleDay_Load(object sender, EventArgs e)
        {
            lblDate.Text = date;
            List<List<string>> lsTemp = SqlCommunication.getAppointments(date);
            lsPatient = lsTemp[0];
            lsStaff = lsTemp[1];
            lsRoomName = lsTemp[2];
            

            //create buttons for each appointment
            int topValue = 100;
            int leftValue = 3;

            //for loop to get create buttons in a new row after 5 panels have been created
            for (int i = 0; i < lsPatient.Count / 5 + 0.9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    Panel btnNew = new Panel();
                    btnNew.Top = topValue;
                    btnNew.Left = 1;//change
                    btnNew.Height = 54;
                    btnNew.Width = 110;
                    btnNew.BorderStyle = BorderStyle.FixedSingle;
                    btnNew.Click += btnNew_Click;
                    pnlSingleDay.Controls.Add(btnNew);

                    leftValue += btnNew.Width;
                }
                topValue += 54;
                leftValue = 3;
            }
        }
    }
}