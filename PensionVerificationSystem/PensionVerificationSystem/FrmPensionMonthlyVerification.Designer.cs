namespace PensionVerificationSystem
{
    partial class FrmPensionMonthlyVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPensionMonthlyVerification));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPensionerId = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPensionerFullname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboVerificationMonth = new System.Windows.Forms.ComboBox();
            this.cboVerificationYear = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDateDueForPayment = new System.Windows.Forms.DateTimePicker();
            this.txtMonthlyPensionPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(10, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 58);
            this.panel2.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = global::PensionVerificationSystem.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.Location = new System.Drawing.Point(322, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "   &Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(92, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "  &Verify";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtPensionerId);
            this.panel1.Controls.Add(this.txtAccountNumber);
            this.panel1.Controls.Add(this.txtBankName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPensionerFullname);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cboVerificationMonth);
            this.panel1.Controls.Add(this.cboVerificationYear);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtpDateDueForPayment);
            this.panel1.Controls.Add(this.txtMonthlyPensionPayment);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 310);
            this.panel1.TabIndex = 5;
            // 
            // txtPensionerId
            // 
            this.txtPensionerId.Location = new System.Drawing.Point(285, 9);
            this.txtPensionerId.Name = "txtPensionerId";
            this.txtPensionerId.Size = new System.Drawing.Size(252, 26);
            this.txtPensionerId.TabIndex = 43;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(285, 239);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(252, 26);
            this.txtAccountNumber.TabIndex = 42;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(286, 207);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(252, 26);
            this.txtBankName.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Account Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Bank Name:";
            // 
            // txtPensionerFullname
            // 
            this.txtPensionerFullname.Location = new System.Drawing.Point(285, 41);
            this.txtPensionerFullname.Name = "txtPensionerFullname";
            this.txtPensionerFullname.Size = new System.Drawing.Size(252, 26);
            this.txtPensionerFullname.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "Persioner\'s Fullname:";
            // 
            // cboVerificationMonth
            // 
            this.cboVerificationMonth.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVerificationMonth.FormattingEnabled = true;
            this.cboVerificationMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cboVerificationMonth.Location = new System.Drawing.Point(286, 108);
            this.cboVerificationMonth.Name = "cboVerificationMonth";
            this.cboVerificationMonth.Size = new System.Drawing.Size(170, 27);
            this.cboVerificationMonth.TabIndex = 36;
            this.cboVerificationMonth.Text = "September";
            // 
            // cboVerificationYear
            // 
            this.cboVerificationYear.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVerificationYear.FormattingEnabled = true;
            this.cboVerificationYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cboVerificationYear.Location = new System.Drawing.Point(286, 138);
            this.cboVerificationYear.Name = "cboVerificationYear";
            this.cboVerificationYear.Size = new System.Drawing.Size(170, 27);
            this.cboVerificationYear.TabIndex = 35;
            this.cboVerificationYear.Text = "2016";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Verification Year:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Verification Month:";
            // 
            // dtpDateDueForPayment
            // 
            this.dtpDateDueForPayment.Location = new System.Drawing.Point(285, 174);
            this.dtpDateDueForPayment.Name = "dtpDateDueForPayment";
            this.dtpDateDueForPayment.Size = new System.Drawing.Size(252, 26);
            this.dtpDateDueForPayment.TabIndex = 14;
            // 
            // txtMonthlyPensionPayment
            // 
            this.txtMonthlyPensionPayment.Location = new System.Drawing.Point(286, 76);
            this.txtMonthlyPensionPayment.Name = "txtMonthlyPensionPayment";
            this.txtMonthlyPensionPayment.Size = new System.Drawing.Size(252, 26);
            this.txtMonthlyPensionPayment.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Due for Payment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly Pension Payment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persioner\'s Id:";
            // 
            // FrmPensionMonthlyVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PensionVerificationSystem.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(564, 416);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPensionMonthlyVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pension Monthly Verification Form";
            this.Load += new System.EventHandler(this.FrmPensionMonthlyVerification_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPensionerFullname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboVerificationMonth;
        private System.Windows.Forms.ComboBox cboVerificationYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDateDueForPayment;
        private System.Windows.Forms.TextBox txtMonthlyPensionPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPensionerId;
    }
}