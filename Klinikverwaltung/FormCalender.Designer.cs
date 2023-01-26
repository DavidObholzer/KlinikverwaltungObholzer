namespace Klinikverwaltung
{
    partial class FormCalender
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
            this.pnlCalender = new System.Windows.Forms.Panel();
            this.btnForwardMonth = new System.Windows.Forms.Button();
            this.btnBackMonth = new System.Windows.Forms.Button();
            this.lblSonntag = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblSatuarday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblYearAndMonth = new System.Windows.Forms.Label();
            this.pnlCalender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCalender
            // 
            this.pnlCalender.Controls.Add(this.btnForwardMonth);
            this.pnlCalender.Controls.Add(this.btnBackMonth);
            this.pnlCalender.Controls.Add(this.lblSonntag);
            this.pnlCalender.Controls.Add(this.lblTuesday);
            this.pnlCalender.Controls.Add(this.lblWednesday);
            this.pnlCalender.Controls.Add(this.lblThursday);
            this.pnlCalender.Controls.Add(this.lblFriday);
            this.pnlCalender.Controls.Add(this.lblSatuarday);
            this.pnlCalender.Controls.Add(this.lblMonday);
            this.pnlCalender.Controls.Add(this.lblYearAndMonth);
            this.pnlCalender.Location = new System.Drawing.Point(12, 12);
            this.pnlCalender.Name = "pnlCalender";
            this.pnlCalender.Size = new System.Drawing.Size(780, 433);
            this.pnlCalender.TabIndex = 0;
            // 
            // btnForwardMonth
            // 
            this.btnForwardMonth.Location = new System.Drawing.Point(665, 32);
            this.btnForwardMonth.Name = "btnForwardMonth";
            this.btnForwardMonth.Size = new System.Drawing.Size(75, 23);
            this.btnForwardMonth.TabIndex = 9;
            this.btnForwardMonth.Text = ">";
            this.btnForwardMonth.UseVisualStyleBackColor = true;
            this.btnForwardMonth.Click += new System.EventHandler(this.btnForwardMonth_Click);
            // 
            // btnBackMonth
            // 
            this.btnBackMonth.Location = new System.Drawing.Point(31, 32);
            this.btnBackMonth.Name = "btnBackMonth";
            this.btnBackMonth.Size = new System.Drawing.Size(75, 23);
            this.btnBackMonth.TabIndex = 8;
            this.btnBackMonth.Text = "<";
            this.btnBackMonth.UseVisualStyleBackColor = true;
            this.btnBackMonth.Click += new System.EventHandler(this.btnBackMonth_Click);
            // 
            // lblSonntag
            // 
            this.lblSonntag.AutoSize = true;
            this.lblSonntag.Location = new System.Drawing.Point(689, 75);
            this.lblSonntag.Name = "lblSonntag";
            this.lblSonntag.Size = new System.Drawing.Size(51, 15);
            this.lblSonntag.TabIndex = 7;
            this.lblSonntag.Text = "Sonntag";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(132, 75);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(53, 15);
            this.lblTuesday.TabIndex = 6;
            this.lblTuesday.Text = "Dienstag";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(246, 75);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(58, 15);
            this.lblWednesday.TabIndex = 5;
            this.lblWednesday.Text = "Mittwoch";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(360, 75);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(68, 15);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "Donnerstag";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(482, 75);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(43, 15);
            this.lblFriday.TabIndex = 3;
            this.lblFriday.Text = "Freitag";
            // 
            // lblSatuarday
            // 
            this.lblSatuarday.AutoSize = true;
            this.lblSatuarday.Location = new System.Drawing.Point(584, 75);
            this.lblSatuarday.Name = "lblSatuarday";
            this.lblSatuarday.Size = new System.Drawing.Size(52, 15);
            this.lblSatuarday.TabIndex = 2;
            this.lblSatuarday.Text = "Samstag";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(31, 75);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(49, 15);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "Montag";
            // 
            // lblYearAndMonth
            // 
            this.lblYearAndMonth.AutoSize = true;
            this.lblYearAndMonth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYearAndMonth.Location = new System.Drawing.Point(316, 28);
            this.lblYearAndMonth.Name = "lblYearAndMonth";
            this.lblYearAndMonth.Size = new System.Drawing.Size(154, 25);
            this.lblYearAndMonth.TabIndex = 0;
            this.lblYearAndMonth.Text = "Month and Year";
            // 
            // FormCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 457);
            this.Controls.Add(this.pnlCalender);
            this.Name = "FormCalender";
            this.Text = "FormCalender";
            this.Load += new System.EventHandler(this.FormCalender_Load);
            this.pnlCalender.ResumeLayout(false);
            this.pnlCalender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCalender;
        private Label lblYearAndMonth;
        private Label lblSonntag;
        private Label lblTuesday;
        private Label lblWednesday;
        private Label lblThursday;
        private Label lblFriday;
        private Label lblSatuarday;
        private Label lblMonday;
        private Button btnForwardMonth;
        private Button btnBackMonth;
    }
}