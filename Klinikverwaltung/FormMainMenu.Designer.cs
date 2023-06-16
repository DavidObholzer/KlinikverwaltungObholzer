namespace Klinikverwaltung
{
    partial class FormMainMenu
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
            this.btnCalender = new System.Windows.Forms.Button();
            this.btn_profiles = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnDienstplan = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalender
            // 
            this.btnCalender.Location = new System.Drawing.Point(305, 110);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(173, 55);
            this.btnCalender.TabIndex = 0;
            this.btnCalender.Text = "Kalender";
            this.btnCalender.UseVisualStyleBackColor = true;
            this.btnCalender.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_profiles
            // 
            this.btn_profiles.Location = new System.Drawing.Point(305, 171);
            this.btn_profiles.Name = "btn_profiles";
            this.btn_profiles.Size = new System.Drawing.Size(173, 55);
            this.btn_profiles.TabIndex = 1;
            this.btn_profiles.Text = "Benutzerprofile verwalten";
            this.btn_profiles.UseVisualStyleBackColor = true;
            this.btn_profiles.Click += new System.EventHandler(this.btn_profiles_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Enabled = false;
            this.btnStaff.Location = new System.Drawing.Point(305, 232);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(173, 55);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Mitarbeiter verwalten";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnDienstplan
            // 
            this.btnDienstplan.Location = new System.Drawing.Point(305, 293);
            this.btnDienstplan.Name = "btnDienstplan";
            this.btnDienstplan.Size = new System.Drawing.Size(173, 55);
            this.btnDienstplan.TabIndex = 3;
            this.btnDienstplan.Text = "Dienstplan";
            this.btnDienstplan.UseVisualStyleBackColor = true;
            this.btnDienstplan.Click += new System.EventHandler(this.btnDienstplan_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(263, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Klinikverwaltung";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDienstplan);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btn_profiles);
            this.Controls.Add(this.btnCalender);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalender;
        private Button btn_profiles;
        private Button btnStaff;
        private Button btnDienstplan;
        private Label lblTitle;
    }
}