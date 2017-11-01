namespace FailurePredictionArtificialLiftSystem
{
    partial class FrmDailyMeasure
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
            this.btnPredict = new System.Windows.Forms.Button();
            this.dtpMeasuredDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGrossFluidRate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFluidLevel = new System.Windows.Forms.TextBox();
            this.txtLastApprovedWater = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtLastApprovedOil = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNetDownholePumpEfficiency = new System.Windows.Forms.TextBox();
            this.txtPolishedRodHorsePower = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGearboxTorque = new System.Windows.Forms.TextBox();
            this.cboWellStatus = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPumpFillage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDailyRuntime = new System.Windows.Forms.TextBox();
            this.txtYesterdayCycles = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFlowLinePressure = new System.Windows.Forms.TextBox();
            this.txtSurfaceStrokeLength = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStrokePerMinute = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMinimumSurfaceLoad = new System.Windows.Forms.TextBox();
            this.txtPeakSurfaceLoad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCardArea = new System.Windows.Forms.TextBox();
            this.cboWellID = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboPumpID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(139, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(603, 33);
            this.label12.TabIndex = 8;
            this.label12.Text = "Daily Measure Multivariate Time Series Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(75, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(728, 33);
            this.label11.TabIndex = 7;
            this.label11.Text = "Failure Prediction for Rod Pump Artificial Lift Systems";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnPredict);
            this.panel1.Controls.Add(this.dtpMeasuredDate);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.cboWellStatus);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cboWellID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cboPumpID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 506);
            this.panel1.TabIndex = 6;
            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredict.Location = new System.Drawing.Point(439, 462);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(134, 45);
            this.btnPredict.TabIndex = 33;
            this.btnPredict.Text = "&Predict";
            this.btnPredict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // dtpMeasuredDate
            // 
            this.dtpMeasuredDate.Location = new System.Drawing.Point(160, 46);
            this.dtpMeasuredDate.Name = "dtpMeasuredDate";
            this.dtpMeasuredDate.Size = new System.Drawing.Size(289, 29);
            this.dtpMeasuredDate.TabIndex = 32;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGrossFluidRate);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtFluidLevel);
            this.groupBox4.Controls.Add(this.txtLastApprovedWater);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtLastApprovedOil);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(422, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 222);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Well Fluid Parameters Reading";
            // 
            // txtGrossFluidRate
            // 
            this.txtGrossFluidRate.Location = new System.Drawing.Point(282, 131);
            this.txtGrossFluidRate.Name = "txtGrossFluidRate";
            this.txtGrossFluidRate.Size = new System.Drawing.Size(142, 29);
            this.txtGrossFluidRate.TabIndex = 15;
            this.txtGrossFluidRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtGrossFluidRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(6, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 22);
            this.label19.TabIndex = 13;
            this.label19.Text = "Gross Fluid Rate:";
            // 
            // txtFluidLevel
            // 
            this.txtFluidLevel.Location = new System.Drawing.Point(282, 96);
            this.txtFluidLevel.Name = "txtFluidLevel";
            this.txtFluidLevel.Size = new System.Drawing.Size(142, 29);
            this.txtFluidLevel.TabIndex = 12;
            this.txtFluidLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtFluidLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // txtLastApprovedWater
            // 
            this.txtLastApprovedWater.Location = new System.Drawing.Point(282, 61);
            this.txtLastApprovedWater.Name = "txtLastApprovedWater";
            this.txtLastApprovedWater.Size = new System.Drawing.Size(142, 29);
            this.txtLastApprovedWater.TabIndex = 11;
            this.txtLastApprovedWater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtLastApprovedWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(6, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 22);
            this.label20.TabIndex = 5;
            this.label20.Text = "Fluid Level:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(6, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(193, 22);
            this.label21.TabIndex = 4;
            this.label21.Text = "Last Approved Water:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(6, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(166, 22);
            this.label22.TabIndex = 3;
            this.label22.Text = "Last Approved Oil:";
            // 
            // txtLastApprovedOil
            // 
            this.txtLastApprovedOil.Location = new System.Drawing.Point(282, 26);
            this.txtLastApprovedOil.Name = "txtLastApprovedOil";
            this.txtLastApprovedOil.Size = new System.Drawing.Size(142, 29);
            this.txtLastApprovedOil.TabIndex = 10;
            this.txtLastApprovedOil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtLastApprovedOil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNetDownholePumpEfficiency);
            this.groupBox3.Controls.Add(this.txtPolishedRodHorsePower);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtGearboxTorque);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(422, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 139);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculated Parameters Reading";
            // 
            // txtNetDownholePumpEfficiency
            // 
            this.txtNetDownholePumpEfficiency.Location = new System.Drawing.Point(282, 96);
            this.txtNetDownholePumpEfficiency.Name = "txtNetDownholePumpEfficiency";
            this.txtNetDownholePumpEfficiency.Size = new System.Drawing.Size(142, 29);
            this.txtNetDownholePumpEfficiency.TabIndex = 12;
            this.txtNetDownholePumpEfficiency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtNetDownholePumpEfficiency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // txtPolishedRodHorsePower
            // 
            this.txtPolishedRodHorsePower.Location = new System.Drawing.Point(282, 61);
            this.txtPolishedRodHorsePower.Name = "txtPolishedRodHorsePower";
            this.txtPolishedRodHorsePower.Size = new System.Drawing.Size(142, 29);
            this.txtPolishedRodHorsePower.TabIndex = 11;
            this.txtPolishedRodHorsePower.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtPolishedRodHorsePower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Net Downhole Pump Efficiency:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Polished Rod Horse Power:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Gearbox Torque:";
            // 
            // txtGearboxTorque
            // 
            this.txtGearboxTorque.Location = new System.Drawing.Point(282, 26);
            this.txtGearboxTorque.Name = "txtGearboxTorque";
            this.txtGearboxTorque.Size = new System.Drawing.Size(142, 29);
            this.txtGearboxTorque.TabIndex = 10;
            this.txtGearboxTorque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtGearboxTorque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // cboWellStatus
            // 
            this.cboWellStatus.FormattingEnabled = true;
            this.cboWellStatus.Items.AddRange(new object[] {
            "Normal",
            "Fail"});
            this.cboWellStatus.Location = new System.Drawing.Point(606, 46);
            this.cboWellStatus.Name = "cboWellStatus";
            this.cboWellStatus.Size = new System.Drawing.Size(251, 30);
            this.cboWellStatus.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(485, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 22);
            this.label18.TabIndex = 28;
            this.label18.Text = "Well Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPumpFillage);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDailyRuntime);
            this.groupBox2.Controls.Add(this.txtYesterdayCycles);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtFlowLinePressure);
            this.groupBox2.Controls.Add(this.txtSurfaceStrokeLength);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtStrokePerMinute);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(15, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 249);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Working Status Parameters Reading";
            // 
            // txtPumpFillage
            // 
            this.txtPumpFillage.Location = new System.Drawing.Point(221, 133);
            this.txtPumpFillage.Name = "txtPumpFillage";
            this.txtPumpFillage.Size = new System.Drawing.Size(142, 29);
            this.txtPumpFillage.TabIndex = 18;
            this.txtPumpFillage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtPumpFillage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pump Fillage:";
            // 
            // txtDailyRuntime
            // 
            this.txtDailyRuntime.Location = new System.Drawing.Point(221, 206);
            this.txtDailyRuntime.Name = "txtDailyRuntime";
            this.txtDailyRuntime.Size = new System.Drawing.Size(142, 29);
            this.txtDailyRuntime.TabIndex = 16;
            this.txtDailyRuntime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtDailyRuntime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // txtYesterdayCycles
            // 
            this.txtYesterdayCycles.Location = new System.Drawing.Point(221, 170);
            this.txtYesterdayCycles.Name = "txtYesterdayCycles";
            this.txtYesterdayCycles.Size = new System.Drawing.Size(142, 29);
            this.txtYesterdayCycles.TabIndex = 15;
            this.txtYesterdayCycles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtYesterdayCycles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(6, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(218, 22);
            this.label17.TabIndex = 14;
            this.label17.Text = "Daily Runtime (per hour):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(6, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 22);
            this.label16.TabIndex = 13;
            this.label16.Text = "Yesterday Cycles:";
            // 
            // txtFlowLinePressure
            // 
            this.txtFlowLinePressure.Location = new System.Drawing.Point(221, 96);
            this.txtFlowLinePressure.Name = "txtFlowLinePressure";
            this.txtFlowLinePressure.Size = new System.Drawing.Size(142, 29);
            this.txtFlowLinePressure.TabIndex = 12;
            this.txtFlowLinePressure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtFlowLinePressure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // txtSurfaceStrokeLength
            // 
            this.txtSurfaceStrokeLength.Location = new System.Drawing.Point(221, 61);
            this.txtSurfaceStrokeLength.Name = "txtSurfaceStrokeLength";
            this.txtSurfaceStrokeLength.Size = new System.Drawing.Size(142, 29);
            this.txtSurfaceStrokeLength.TabIndex = 11;
            this.txtSurfaceStrokeLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtSurfaceStrokeLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(6, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "Flow Line Pressure:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(6, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "Surface Stroke Length:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(6, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 22);
            this.label15.TabIndex = 3;
            this.label15.Text = "Strokes per Minute:";
            // 
            // txtStrokePerMinute
            // 
            this.txtStrokePerMinute.Location = new System.Drawing.Point(221, 26);
            this.txtStrokePerMinute.Name = "txtStrokePerMinute";
            this.txtStrokePerMinute.Size = new System.Drawing.Size(142, 29);
            this.txtStrokePerMinute.TabIndex = 10;
            this.txtStrokePerMinute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtStrokePerMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMinimumSurfaceLoad);
            this.groupBox1.Controls.Add(this.txtPeakSurfaceLoad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCardArea);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 139);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dynamometer Reading";
            // 
            // txtMinimumSurfaceLoad
            // 
            this.txtMinimumSurfaceLoad.Location = new System.Drawing.Point(221, 96);
            this.txtMinimumSurfaceLoad.Name = "txtMinimumSurfaceLoad";
            this.txtMinimumSurfaceLoad.Size = new System.Drawing.Size(142, 29);
            this.txtMinimumSurfaceLoad.TabIndex = 12;
            this.txtMinimumSurfaceLoad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtMinimumSurfaceLoad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // txtPeakSurfaceLoad
            // 
            this.txtPeakSurfaceLoad.Location = new System.Drawing.Point(221, 61);
            this.txtPeakSurfaceLoad.Name = "txtPeakSurfaceLoad";
            this.txtPeakSurfaceLoad.Size = new System.Drawing.Size(142, 29);
            this.txtPeakSurfaceLoad.TabIndex = 11;
            this.txtPeakSurfaceLoad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtPeakSurfaceLoad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(6, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Minimum Surface Load:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Peak Surface Load:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Card Area:";
            // 
            // txtCardArea
            // 
            this.txtCardArea.Location = new System.Drawing.Point(221, 26);
            this.txtCardArea.Name = "txtCardArea";
            this.txtCardArea.Size = new System.Drawing.Size(142, 29);
            this.txtCardArea.TabIndex = 10;
            this.txtCardArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardArea_KeyDown);
            this.txtCardArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardArea_KeyPress);
            // 
            // cboWellID
            // 
            this.cboWellID.FormattingEnabled = true;
            this.cboWellID.Location = new System.Drawing.Point(160, 11);
            this.cboWellID.Name = "cboWellID";
            this.cboWellID.Size = new System.Drawing.Size(291, 30);
            this.cboWellID.TabIndex = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(719, 461);
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
            this.btnSave.Location = new System.Drawing.Point(579, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 45);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboPumpID
            // 
            this.cboPumpID.FormattingEnabled = true;
            this.cboPumpID.Location = new System.Drawing.Point(606, 12);
            this.cboPumpID.Name = "cboPumpID";
            this.cboPumpID.Size = new System.Drawing.Size(251, 30);
            this.cboPumpID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Measured Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Well Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(485, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pump ID:";
            // 
            // FrmDailyMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FailurePredictionArtificialLiftSystem.Properties.Resources._15_revert_fhd_2000x1125_2;
            this.ClientSize = new System.Drawing.Size(902, 617);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDailyMeasure";
            this.Text = "Daily Measure Multi-Variate Time Series Data For Rod Pump";
            this.Load += new System.EventHandler(this.FrmDailyMeasure_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboWellID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboPumpID;
        private System.Windows.Forms.TextBox txtCardArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinimumSurfaceLoad;
        private System.Windows.Forms.TextBox txtPeakSurfaceLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFlowLinePressure;
        private System.Windows.Forms.TextBox txtSurfaceStrokeLength;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStrokePerMinute;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDailyRuntime;
        private System.Windows.Forms.TextBox txtYesterdayCycles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNetDownholePumpEfficiency;
        private System.Windows.Forms.TextBox txtPolishedRodHorsePower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGearboxTorque;
        private System.Windows.Forms.ComboBox cboWellStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtGrossFluidRate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtFluidLevel;
        private System.Windows.Forms.TextBox txtLastApprovedWater;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtLastApprovedOil;
        private System.Windows.Forms.DateTimePicker dtpMeasuredDate;
        private System.Windows.Forms.TextBox txtPumpFillage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPredict;
    }
}