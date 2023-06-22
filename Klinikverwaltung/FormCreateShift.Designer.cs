namespace Klinikverwaltung
{
    partial class FormCreateShift
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtBeginning = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBeginning = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(322, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(12, 150);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(132, 15);
            this.lblFormat.TabIndex = 48;
            this.lblFormat.Text = "yyyy-MM-dd hh:mm:ss";
            // 
            // btnComplete
            // 
            this.btnComplete.Enabled = false;
            this.btnComplete.Location = new System.Drawing.Point(12, 241);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(385, 36);
            this.btnComplete.TabIndex = 47;
            this.btnComplete.Text = "Fertigstellen";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(215, 23);
            this.txtId.TabIndex = 46;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 45;
            this.lblId.Text = "ID";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(101, 188);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(215, 23);
            this.txtDescription.TabIndex = 39;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(101, 121);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(215, 23);
            this.txtEnd.TabIndex = 38;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // txtBeginning
            // 
            this.txtBeginning.Location = new System.Drawing.Point(101, 67);
            this.txtBeginning.Name = "txtBeginning";
            this.txtBeginning.Size = new System.Drawing.Size(215, 23);
            this.txtBeginning.TabIndex = 37;
            this.txtBeginning.TextChanged += new System.EventHandler(this.txtBeginning_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 191);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 15);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Beschreibung";
            // 
            // lblBeginning
            // 
            this.lblBeginning.AutoSize = true;
            this.lblBeginning.Location = new System.Drawing.Point(12, 70);
            this.lblBeginning.Name = "lblBeginning";
            this.lblBeginning.Size = new System.Drawing.Size(46, 15);
            this.lblBeginning.TabIndex = 34;
            this.lblBeginning.Text = "Anfang";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(12, 129);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(33, 15);
            this.lblEnd.TabIndex = 33;
            this.lblEnd.Text = "Ende";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "yyyy-MM-dd hh:mm:ss";
            // 
            // FormCreateShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtBeginning);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblBeginning);
            this.Controls.Add(this.lblEnd);
            this.Name = "FormCreateShift";
            this.Text = "FormCreateShift";
            this.Load += new System.EventHandler(this.FormCreateShift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private Label lblFormat;
        private Button btnComplete;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtDescription;
        private TextBox txtEnd;
        private TextBox txtBeginning;
        private Label lblDescription;
        private Label lblBeginning;
        private Label lblEnd;
        private Label label1;
    }
}