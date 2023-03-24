namespace Klinikverwaltung
{
    partial class FormSingleDay
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
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlSingleDay = new System.Windows.Forms.Panel();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(371, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "date";
            // 
            // pnlSingleDay
            // 
            this.pnlSingleDay.Location = new System.Drawing.Point(12, 115);
            this.pnlSingleDay.Name = "pnlSingleDay";
            this.pnlSingleDay.Size = new System.Drawing.Size(800, 110);
            this.pnlSingleDay.TabIndex = 2;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(12, 80);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(119, 29);
            this.btnAddAppointment.TabIndex = 3;
            this.btnAddAppointment.Text = "Termin hinzufügen";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // FormSingleDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.pnlSingleDay);
            this.Controls.Add(this.lblDate);
            this.Name = "FormSingleDay";
            this.Text = "FormSingleDay";
            this.Load += new System.EventHandler(this.FormSingleDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDate;
        private Panel pnlSingleDay;
        private Button btnAddAppointment;
    }
}