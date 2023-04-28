namespace Klinikverwaltung
{
    partial class FormProfile
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnChangeProfile = new System.Windows.Forms.Button();
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 35;
            this.lblId.Text = "ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(93, 23);
            this.txtPassword.TabIndex = 32;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(123, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(93, 23);
            this.txtUsername.TabIndex = 31;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 58);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 15);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Benutzername";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 99);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 15);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Passwort eingeben";
            // 
            // btnComplete
            // 
            this.btnComplete.Enabled = false;
            this.btnComplete.Location = new System.Drawing.Point(12, 179);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(304, 36);
            this.btnComplete.TabIndex = 40;
            this.btnComplete.Text = "Fertigstellen";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(123, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 23);
            this.txtId.TabIndex = 39;
            // 
            // btnChangeProfile
            // 
            this.btnChangeProfile.Enabled = false;
            this.btnChangeProfile.Location = new System.Drawing.Point(167, 137);
            this.btnChangeProfile.Name = "btnChangeProfile";
            this.btnChangeProfile.Size = new System.Drawing.Size(149, 36);
            this.btnChangeProfile.TabIndex = 37;
            this.btnChangeProfile.Text = "Benutzer bearbeiten";
            this.btnChangeProfile.UseVisualStyleBackColor = true;
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Enabled = false;
            this.btnAddProfile.Location = new System.Drawing.Point(12, 137);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(149, 36);
            this.btnAddProfile.TabIndex = 36;
            this.btnAddProfile.Text = "Benutzer hinzufügen";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 317);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnChangeProfile);
            this.Controls.Add(this.btnAddProfile);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblId;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnComplete;
        private TextBox txtId;
        private Button btnChangeProfile;
        private Button btnAddProfile;
    }
}