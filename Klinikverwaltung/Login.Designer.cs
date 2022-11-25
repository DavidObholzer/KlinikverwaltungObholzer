namespace Klinikverwaltung
{
    partial class Login
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
            this.cbxSSIP = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblLoginHeadline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxSSIP
            // 
            this.cbxSSIP.AutoSize = true;
            this.cbxSSIP.Location = new System.Drawing.Point(11, 184);
            this.cbxSSIP.Name = "cbxSSIP";
            this.cbxSSIP.Size = new System.Drawing.Size(48, 19);
            this.cbxSSIP.TabIndex = 17;
            this.cbxSSIP.Text = "SSIP";
            this.cbxSSIP.UseVisualStyleBackColor = true;
            this.cbxSSIP.CheckedChanged += new System.EventHandler(this.cbxSSIP_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 23);
            this.txtPassword.TabIndex = 16;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(100, 95);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(166, 23);
            this.txtUser.TabIndex = 15;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(100, 53);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(166, 23);
            this.txtIP.TabIndex = 14;
            this.txtIP.Text = "(localdb)\\MSSQLLocalDB";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(100, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(166, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 140);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 15);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Passwort";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(11, 98);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 15);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Benutzername";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(11, 56);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 15);
            this.lblIP.TabIndex = 10;
            this.lblIP.Text = "IP";
            // 
            // lblLoginHeadline
            // 
            this.lblLoginHeadline.AutoSize = true;
            this.lblLoginHeadline.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginHeadline.Location = new System.Drawing.Point(68, 11);
            this.lblLoginHeadline.Name = "lblLoginHeadline";
            this.lblLoginHeadline.Size = new System.Drawing.Size(133, 25);
            this.lblLoginHeadline.TabIndex = 9;
            this.lblLoginHeadline.Text = "Anmeldung";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxSSIP);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblLoginHeadline);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbxSSIP;
        private TextBox txtPassword;
        private TextBox txtUser;
        private TextBox txtIP;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblIP;
        private Label lblLoginHeadline;
    }
}