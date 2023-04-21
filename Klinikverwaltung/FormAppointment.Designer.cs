namespace Klinikverwaltung
{
    partial class FormAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btn_addAppointment = new System.Windows.Forms.Button();
            this.lbl_dateInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(12, 90);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(66, 15);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "Personal ID";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(12, 46);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(71, 15);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Patienten ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 134);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Datum";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(12, 178);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(52, 15);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Raum ID";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 222);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 15);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Beschreibung";
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(97, 43);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(93, 23);
            this.txtPatient.TabIndex = 5;
            this.txtPatient.TextChanged += new System.EventHandler(this.txtPatient_TextChanged);
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(97, 87);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(93, 23);
            this.txtStaff.TabIndex = 6;
            this.txtStaff.TextChanged += new System.EventHandler(this.txtStaff_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(97, 131);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(93, 23);
            this.txtDate.TabIndex = 7;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(97, 175);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(93, 23);
            this.txtRoom.TabIndex = 8;
            this.txtRoom.TextChanged += new System.EventHandler(this.txtRoom_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 219);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(289, 176);
            this.txtDescription.TabIndex = 9;
            // 
            // btn_addAppointment
            // 
            this.btn_addAppointment.Enabled = false;
            this.btn_addAppointment.Location = new System.Drawing.Point(237, 38);
            this.btn_addAppointment.Name = "btn_addAppointment";
            this.btn_addAppointment.Size = new System.Drawing.Size(149, 23);
            this.btn_addAppointment.TabIndex = 10;
            this.btn_addAppointment.Text = "Termin hinzufügen";
            this.btn_addAppointment.UseVisualStyleBackColor = true;
            this.btn_addAppointment.Click += new System.EventHandler(this.btn_addAppointment_Click);
            // 
            // lbl_dateInfo
            // 
            this.lbl_dateInfo.AutoSize = true;
            this.lbl_dateInfo.Location = new System.Drawing.Point(237, 134);
            this.lbl_dateInfo.Name = "lbl_dateInfo";
            this.lbl_dateInfo.Size = new System.Drawing.Size(132, 15);
            this.lbl_dateInfo.TabIndex = 11;
            this.lbl_dateInfo.Text = "Jahr-Monat-Tag Format";
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 407);
            this.Controls.Add(this.lbl_dateInfo);
            this.Controls.Add(this.btn_addAppointment);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblStaff);
            this.Name = "FormAppointment";
            this.Text = "FormAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStaff;
        private Label lblPatient;
        private Label lblDate;
        private Label lblRoom;
        private Label lblDescription;
        private TextBox txtPatient;
        private TextBox txtStaff;
        private TextBox txtDate;
        private TextBox txtRoom;
        private TextBox txtDescription;
        private Button btn_addAppointment;
        private Label lbl_dateInfo;
    }
}