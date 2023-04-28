namespace Klinikverwaltung
{
    partial class FormStaff
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
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.lblProfession = new System.Windows.Forms.Label();
            this.btnChangeProfile = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Enabled = false;
            this.btnAddProfile.Location = new System.Drawing.Point(222, 13);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(149, 36);
            this.btnAddProfile.TabIndex = 22;
            this.btnAddProfile.Text = "Benutzer hinzufügen";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(101, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(93, 23);
            this.txtName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Vorname";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 104);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 15);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Nachname";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(12, 151);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(83, 15);
            this.lblBirthday.TabIndex = 14;
            this.lblBirthday.Text = "Geburtsdatum";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 195);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(41, 15);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Gehalt";
            // 
            // txtLastname
            // 
            this.txtLastname.Enabled = false;
            this.txtLastname.Location = new System.Drawing.Point(101, 104);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(93, 23);
            this.txtLastname.TabIndex = 18;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Enabled = false;
            this.txtBirthday.Location = new System.Drawing.Point(101, 148);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(93, 23);
            this.txtBirthday.TabIndex = 19;
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(101, 192);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(93, 23);
            this.txtSalary.TabIndex = 20;
            // 
            // txtProfession
            // 
            this.txtProfession.Enabled = false;
            this.txtProfession.Location = new System.Drawing.Point(101, 235);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(93, 23);
            this.txtProfession.TabIndex = 21;
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Location = new System.Drawing.Point(12, 238);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(35, 15);
            this.lblProfession.TabIndex = 23;
            this.lblProfession.Text = "Beruf";
            // 
            // btnChangeProfile
            // 
            this.btnChangeProfile.Enabled = false;
            this.btnChangeProfile.Location = new System.Drawing.Point(377, 13);
            this.btnChangeProfile.Name = "btnChangeProfile";
            this.btnChangeProfile.Size = new System.Drawing.Size(149, 36);
            this.btnChangeProfile.TabIndex = 25;
            this.btnChangeProfile.Text = "Benutzer bearbeiten";
            this.btnChangeProfile.UseVisualStyleBackColor = true;
            this.btnChangeProfile.Click += new System.EventHandler(this.btnChangeProfile_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 26;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(101, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 23);
            this.txtId.TabIndex = 29;
            // 
            // btnComplete
            // 
            this.btnComplete.Enabled = false;
            this.btnComplete.Location = new System.Drawing.Point(222, 60);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(304, 36);
            this.btnComplete.TabIndex = 30;
            this.btnComplete.Text = "Fertigstellen";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 407);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnChangeProfile);
            this.Controls.Add(this.txtProfession);
            this.Controls.Add(this.lblProfession);
            this.Controls.Add(this.btnAddProfile);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLastName);
            this.Name = "FormStaff";
            this.Text = "FormProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddProfile;
        private TextBox txtName;
        private Label lblName;
        private Label lblLastName;
        private Label lblBirthday;
        private Label lblSalary;
        private TextBox txtLastname;
        private TextBox txtBirthday;
        private TextBox txtSalary;
        private TextBox txtProfession;
        private Label lblProfession;
        private Button btnChangeProfile;
        private Label lblId;
        private TextBox txtId;
        private Button btnComplete;
    }
}