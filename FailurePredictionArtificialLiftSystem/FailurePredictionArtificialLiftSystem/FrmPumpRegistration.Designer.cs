namespace FailurePredictionArtificialLiftSystem
{
    partial class FrmPumpRegistration
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPump = new System.Windows.Forms.ComboBox();
            this.cboOperatingRange = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboArtificialLift = new System.Windows.Forms.ComboBox();
            this.txtPumpDepth = new System.Windows.Forms.TextBox();
            this.cboCable = new System.Windows.Forms.ComboBox();
            this.cboMotor = new System.Windows.Forms.ComboBox();
            this.txtOperatingFrequency = new System.Windows.Forms.TextBox();
            this.txtPumpID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(193, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(422, 33);
            this.label12.TabIndex = 5;
            this.label12.Text = "Pump Artificial Lift Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(47, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(728, 33);
            this.label11.TabIndex = 4;
            this.label11.Text = "Failure Prediction for Rod Pump Artificial Lift Systems";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cboPump);
            this.panel1.Controls.Add(this.cboOperatingRange);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cboArtificialLift);
            this.panel1.Controls.Add(this.txtPumpDepth);
            this.panel1.Controls.Add(this.cboCable);
            this.panel1.Controls.Add(this.cboMotor);
            this.panel1.Controls.Add(this.txtOperatingFrequency);
            this.panel1.Controls.Add(this.txtPumpID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(125, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 383);
            this.panel1.TabIndex = 3;
            // 
            // cboPump
            // 
            this.cboPump.FormattingEnabled = true;
            this.cboPump.Items.AddRange(new object[] {
            "Centrilift 562 P100",
            "Centrilift 562 P110",
            "Centrilift 562 P120",
            "Centrilift 562 P130",
            "Centrilift 740 F120",
            "Centrilift 740 F130",
            "Centrilift 740 F140"});
            this.cboPump.Location = new System.Drawing.Point(210, 85);
            this.cboPump.Name = "cboPump";
            this.cboPump.Size = new System.Drawing.Size(291, 30);
            this.cboPump.TabIndex = 25;
            // 
            // cboOperatingRange
            // 
            this.cboOperatingRange.FormattingEnabled = true;
            this.cboOperatingRange.Items.AddRange(new object[] {
            "7000 - 13200 bbl/day (60Hz)",
            "7000 - 15200 bbl/day (80Hz)",
            "8500 - 18200 bbl/day (120Hz)",
            "9000 - 21500 bbl/day (150Hz)"});
            this.cboOperatingRange.Location = new System.Drawing.Point(210, 123);
            this.cboOperatingRange.Name = "cboOperatingRange";
            this.cboOperatingRange.Size = new System.Drawing.Size(291, 30);
            this.cboOperatingRange.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(507, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Hz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(508, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "m";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(367, 300);
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
            this.btnSave.Location = new System.Drawing.Point(227, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 45);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboArtificialLift
            // 
            this.cboArtificialLift.FormattingEnabled = true;
            this.cboArtificialLift.Items.AddRange(new object[] {
            "Electric Submersible Pump",
            "Gas Lift",
            "Hydraulic Pump",
            "Progressive Cavity Pump",
            "Jet Pump",
            "Sucker Rod Pump",
            "Multiphase Pump",
            "Injection of Diluent",
            "Gas Lift with Coiled Tubing"});
            this.cboArtificialLift.Location = new System.Drawing.Point(210, 49);
            this.cboArtificialLift.Name = "cboArtificialLift";
            this.cboArtificialLift.Size = new System.Drawing.Size(291, 30);
            this.cboArtificialLift.TabIndex = 17;
            // 
            // txtPumpDepth
            // 
            this.txtPumpDepth.Location = new System.Drawing.Point(210, 228);
            this.txtPumpDepth.Name = "txtPumpDepth";
            this.txtPumpDepth.Size = new System.Drawing.Size(292, 29);
            this.txtPumpDepth.TabIndex = 16;
            // 
            // cboCable
            // 
            this.cboCable.FormattingEnabled = true;
            this.cboCable.Items.AddRange(new object[] {
            "Grade 1 Copper",
            "Grade 2 Copper",
            "Grade 3 Copper",
            "Grade 4 Copper",
            "Grade 1 Lead",
            "Grade 2 Lead",
            "Grade 1 Aluminium",
            "Grade 2 Aluminium"});
            this.cboCable.Location = new System.Drawing.Point(210, 193);
            this.cboCable.Name = "cboCable";
            this.cboCable.Size = new System.Drawing.Size(291, 30);
            this.cboCable.TabIndex = 15;
            // 
            // cboMotor
            // 
            this.cboMotor.FormattingEnabled = true;
            this.cboMotor.Items.AddRange(new object[] {
            "Centrilift 562 450 HP",
            "Centrilift 562 450 DP",
            "Centrilift 562 750 HP",
            "Centrilift 562 750 DP",
            "Centrilift 740 450 HP",
            "Centrilift 740 450 DP"});
            this.cboMotor.Location = new System.Drawing.Point(210, 158);
            this.cboMotor.Name = "cboMotor";
            this.cboMotor.Size = new System.Drawing.Size(291, 30);
            this.cboMotor.TabIndex = 14;
            // 
            // txtOperatingFrequency
            // 
            this.txtOperatingFrequency.Location = new System.Drawing.Point(210, 265);
            this.txtOperatingFrequency.Name = "txtOperatingFrequency";
            this.txtOperatingFrequency.Size = new System.Drawing.Size(292, 29);
            this.txtOperatingFrequency.TabIndex = 11;
            // 
            // txtPumpID
            // 
            this.txtPumpID.Location = new System.Drawing.Point(210, 15);
            this.txtPumpID.Name = "txtPumpID";
            this.txtPumpID.Size = new System.Drawing.Size(292, 29);
            this.txtPumpID.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(7, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Operating Frequency:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(17, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pump Depth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(17, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cable:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(17, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(17, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operating Range:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pump:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artificial Lift:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pump ID:";
            // 
            // FrmPumpRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FailurePredictionArtificialLiftSystem.Properties.Resources._15_revert_fhd_2000x1125_2;
            this.ClientSize = new System.Drawing.Size(822, 614);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPumpRegistration";
            this.Text = "Pump Artificial Lift Registration Form";
            this.Load += new System.EventHandler(this.FrmPumpRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboArtificialLift;
        private System.Windows.Forms.TextBox txtPumpDepth;
        private System.Windows.Forms.ComboBox cboCable;
        private System.Windows.Forms.ComboBox cboMotor;
        private System.Windows.Forms.TextBox txtOperatingFrequency;
        private System.Windows.Forms.TextBox txtPumpID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPump;
        private System.Windows.Forms.ComboBox cboOperatingRange;
    }
}