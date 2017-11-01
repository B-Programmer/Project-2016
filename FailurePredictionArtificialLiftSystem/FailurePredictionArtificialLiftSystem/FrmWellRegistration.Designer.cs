namespace FailurePredictionArtificialLiftSystem
{
    partial class FrmWellRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboFlowType = new System.Windows.Forms.ComboBox();
            this.cboWellType = new System.Windows.Forms.ComboBox();
            this.cboWellStatus = new System.Windows.Forms.ComboBox();
            this.txtWellName = new System.Windows.Forms.TextBox();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.txtField = new System.Windows.Forms.TextBox();
            this.txtOperatorName = new System.Windows.Forms.TextBox();
            this.txtWellPermit = new System.Windows.Forms.TextBox();
            this.txtWellID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cboFlowType);
            this.panel1.Controls.Add(this.cboWellType);
            this.panel1.Controls.Add(this.cboWellStatus);
            this.panel1.Controls.Add(this.txtWellName);
            this.panel1.Controls.Add(this.cboLocation);
            this.panel1.Controls.Add(this.cboCountry);
            this.panel1.Controls.Add(this.txtField);
            this.panel1.Controls.Add(this.txtOperatorName);
            this.panel1.Controls.Add(this.txtWellPermit);
            this.panel1.Controls.Add(this.txtWellID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(92, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 434);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(336, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 45);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(196, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 45);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboFlowType
            // 
            this.cboFlowType.FormattingEnabled = true;
            this.cboFlowType.Items.AddRange(new object[] {
            "Tubing Flow",
            "Single Branch Flow",
            "Double Branch Flow",
            "Flow Coupling"});
            this.cboFlowType.Location = new System.Drawing.Point(178, 333);
            this.cboFlowType.Name = "cboFlowType";
            this.cboFlowType.Size = new System.Drawing.Size(291, 30);
            this.cboFlowType.TabIndex = 19;
            // 
            // cboWellType
            // 
            this.cboWellType.FormattingEnabled = true;
            this.cboWellType.Items.AddRange(new object[] {
            "Producer",
            "Production",
            "Tubing",
            "Oil Well",
            "Water Well",
            "Gas Well"});
            this.cboWellType.Location = new System.Drawing.Point(177, 298);
            this.cboWellType.Name = "cboWellType";
            this.cboWellType.Size = new System.Drawing.Size(291, 30);
            this.cboWellType.TabIndex = 18;
            // 
            // cboWellStatus
            // 
            this.cboWellStatus.FormattingEnabled = true;
            this.cboWellStatus.Items.AddRange(new object[] {
            "Normal",
            "Fair",
            "Abnormal",
            "Weak",
            "Poor"});
            this.cboWellStatus.Location = new System.Drawing.Point(177, 263);
            this.cboWellStatus.Name = "cboWellStatus";
            this.cboWellStatus.Size = new System.Drawing.Size(291, 30);
            this.cboWellStatus.TabIndex = 17;
            // 
            // txtWellName
            // 
            this.txtWellName.Location = new System.Drawing.Point(177, 228);
            this.txtWellName.Name = "txtWellName";
            this.txtWellName.Size = new System.Drawing.Size(292, 29);
            this.txtWellName.TabIndex = 16;
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Items.AddRange(new object[] {
            "Norway",
            "Cross-river",
            "Delta",
            "Lagos",
            "Enugu",
            "Kaduna",
            "Porthacourt",
            "Niger",
            "Benue",
            "Toronto",
            "Bejing",
            "Belgium",
            "New York",
            "Alandasa",
            "Weblendom"});
            this.cboLocation.Location = new System.Drawing.Point(177, 193);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(291, 30);
            this.cboLocation.TabIndex = 15;
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Algeria",
            "Cameroun",
            "China",
            "Japan",
            "Korea",
            "Kenya",
            "Ghana",
            "Libya",
            "Nigeria",
            "Togo",
            "Talisman",
            "Canada",
            "Toronto",
            "USA",
            "UAE",
            "Saudi Arabia",
            "South Africa",
            "Brazil",
            "Argentina",
            "England",
            "Germany",
            "Spain",
            "Italy",
            "",
            ""});
            this.cboCountry.Location = new System.Drawing.Point(177, 158);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(291, 30);
            this.cboCountry.TabIndex = 14;
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(177, 120);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(292, 29);
            this.txtField.TabIndex = 13;
            // 
            // txtOperatorName
            // 
            this.txtOperatorName.Location = new System.Drawing.Point(177, 85);
            this.txtOperatorName.Name = "txtOperatorName";
            this.txtOperatorName.Size = new System.Drawing.Size(292, 29);
            this.txtOperatorName.TabIndex = 12;
            // 
            // txtWellPermit
            // 
            this.txtWellPermit.Location = new System.Drawing.Point(177, 50);
            this.txtWellPermit.Name = "txtWellPermit";
            this.txtWellPermit.Size = new System.Drawing.Size(292, 29);
            this.txtWellPermit.TabIndex = 11;
            // 
            // txtWellID
            // 
            this.txtWellID.Location = new System.Drawing.Point(177, 15);
            this.txtWellID.Name = "txtWellID";
            this.txtWellID.Size = new System.Drawing.Size(292, 29);
            this.txtWellID.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(17, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Flow Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(17, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Well Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(17, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Well Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(17, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Well Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(17, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(17, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(17, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Field:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operator Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Well Permit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Well ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(25, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(728, 33);
            this.label11.TabIndex = 1;
            this.label11.Text = "Failure Prediction for Rod Pump Artificial Lift Systems";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(128, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(484, 33);
            this.label12.TabIndex = 2;
            this.label12.Text = "Oil, Water and Gas Well Information";
            // 
            // FrmWellRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FailurePredictionArtificialLiftSystem.Properties.Resources._15_revert_fhd_2000x1125_2;
            this.ClientSize = new System.Drawing.Size(794, 623);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Name = "FrmWellRegistration";
            this.Text = "Oil, Water, and Gas Well Registration Form";
            this.Load += new System.EventHandler(this.FrmWellRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboWellType;
        private System.Windows.Forms.ComboBox cboWellStatus;
        private System.Windows.Forms.TextBox txtWellName;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.TextBox txtOperatorName;
        private System.Windows.Forms.TextBox txtWellPermit;
        private System.Windows.Forms.TextBox txtWellID;
        private System.Windows.Forms.ComboBox cboFlowType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

