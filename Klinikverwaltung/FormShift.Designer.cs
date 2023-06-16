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
            this.btnForwardWeek = new System.Windows.Forms.Button();
            this.btnBackWeek = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(331, 8);
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
            // btnForwardWeek
            // 
            this.btnForwardWeek.Location = new System.Drawing.Point(707, 12);
            this.btnForwardWeek.Name = "btnForwardWeek";
            this.btnForwardWeek.Size = new System.Drawing.Size(75, 23);
            this.btnForwardWeek.TabIndex = 11;
            this.btnForwardWeek.Text = ">";
            this.btnForwardWeek.UseVisualStyleBackColor = true;
            this.btnForwardWeek.Click += new System.EventHandler(this.btnForwardWeek_Click);
            // 
            // btnBackWeek
            // 
            this.btnBackWeek.Location = new System.Drawing.Point(12, 12);
            this.btnBackWeek.Name = "btnBackWeek";
            this.btnBackWeek.Size = new System.Drawing.Size(75, 23);
            this.btnBackWeek.TabIndex = 10;
            this.btnBackWeek.Text = "<";
            this.btnBackWeek.UseVisualStyleBackColor = true;
            this.btnBackWeek.Click += new System.EventHandler(this.btnBackWeek_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(12, 48);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(144, 15);
            this.lblEmployee.TabIndex = 12;
            this.lblEmployee.Text = "Mitarbeiter ID auswählen: ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(162, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 23);
            this.txtId.TabIndex = 13;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(316, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(234, 45);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(76, 23);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.Text = "Auswählen";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FormShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 486);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnForwardWeek);
            this.Controls.Add(this.btnBackWeek);
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
        private Button btnForwardWeek;
        private Button btnBackWeek;
        private Label lblEmployee;
        private TextBox txtId;
        private Button btnSearch;
        private Button btnSelect;
    }
}