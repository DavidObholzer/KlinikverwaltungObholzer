namespace Klinikverwaltung
{
    partial class FormShift
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTimetable = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(332, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dienstplan";
            // 
            // pnlTimetable
            // 
            this.pnlTimetable.Location = new System.Drawing.Point(12, 114);
            this.pnlTimetable.Name = "pnlTimetable";
            this.pnlTimetable.Size = new System.Drawing.Size(770, 360);
            this.pnlTimetable.TabIndex = 1;
            // 
            // FormShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 486);
            this.Controls.Add(this.pnlTimetable);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormShift";
            this.Text = "FormShift";
            this.Load += new System.EventHandler(this.FormShift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Panel pnlTimetable;
    }
}