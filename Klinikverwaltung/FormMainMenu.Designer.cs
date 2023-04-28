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
            this.SuspendLayout();
            // 
            // btnCalender
            // 
            this.btnCalender.Location = new System.Drawing.Point(334, 176);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(108, 55);
            this.btnCalender.TabIndex = 0;
            this.btnCalender.Text = "Kalender";
            this.btnCalender.UseVisualStyleBackColor = true;
            this.btnCalender.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_profiles
            // 
            this.btn_profiles.Location = new System.Drawing.Point(334, 237);
            this.btn_profiles.Name = "btn_profiles";
            this.btn_profiles.Size = new System.Drawing.Size(108, 55);
            this.btn_profiles.TabIndex = 1;
            this.btn_profiles.Text = "Benutzerprofile verwalten";
            this.btn_profiles.UseVisualStyleBackColor = true;
            this.btn_profiles.Click += new System.EventHandler(this.btn_profiles_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_profiles);
            this.Controls.Add(this.btnCalender);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCalender;
        private Button btn_profiles;
    }
}