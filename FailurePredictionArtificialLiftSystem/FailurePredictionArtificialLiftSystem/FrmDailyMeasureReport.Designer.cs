namespace FailurePredictionArtificialLiftSystem
{
    partial class FrmDailyMeasureReport
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
            this.components = new System.ComponentModel.Container();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbArtificialLiftDataSet3 = new FailurePredictionArtificialLiftSystem.dbArtificialLiftDataSet3();
            this.tblDailyMeasureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDailyMeasureTableAdapter = new FailurePredictionArtificialLiftSystem.dbArtificialLiftDataSet3TableAdapters.tblDailyMeasureTableAdapter();
            this.wellIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pumpIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measuredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wellStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peakSurfaceLoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumSurfaceLoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strokePerMinuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceStrokeLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLinePressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pumpFillageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yesterdayCyclesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyRuntimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearboxTorqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polishedRodHorsePowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netDownholePumpEfficiencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastApprovedOilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastApprovedWaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fluidLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossFluidRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbArtificialLiftDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDailyMeasureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(165, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(630, 33);
            this.label12.TabIndex = 10;
            this.label12.Text = "Daily Measure Multivariate Time Series Report";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(115, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(728, 33);
            this.label11.TabIndex = 9;
            this.label11.Text = "Failure Prediction for Rod Pump Artificial Lift Systems";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(23, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 465);
            this.panel1.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(756, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 45);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wellIDDataGridViewTextBoxColumn,
            this.pumpIDDataGridViewTextBoxColumn,
            this.measuredDateDataGridViewTextBoxColumn,
            this.wellStatusDataGridViewTextBoxColumn,
            this.cardAreaDataGridViewTextBoxColumn,
            this.peakSurfaceLoadDataGridViewTextBoxColumn,
            this.minimumSurfaceLoadDataGridViewTextBoxColumn,
            this.strokePerMinuteDataGridViewTextBoxColumn,
            this.surfaceStrokeLengthDataGridViewTextBoxColumn,
            this.flowLinePressureDataGridViewTextBoxColumn,
            this.pumpFillageDataGridViewTextBoxColumn,
            this.yesterdayCyclesDataGridViewTextBoxColumn,
            this.dailyRuntimeDataGridViewTextBoxColumn,
            this.gearboxTorqueDataGridViewTextBoxColumn,
            this.polishedRodHorsePowerDataGridViewTextBoxColumn,
            this.netDownholePumpEfficiencyDataGridViewTextBoxColumn,
            this.lastApprovedOilDataGridViewTextBoxColumn,
            this.lastApprovedWaterDataGridViewTextBoxColumn,
            this.fluidLevelDataGridViewTextBoxColumn,
            this.grossFluidRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDailyMeasureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(873, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbArtificialLiftDataSet3
            // 
            this.dbArtificialLiftDataSet3.DataSetName = "dbArtificialLiftDataSet3";
            this.dbArtificialLiftDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDailyMeasureBindingSource
            // 
            this.tblDailyMeasureBindingSource.DataMember = "tblDailyMeasure";
            this.tblDailyMeasureBindingSource.DataSource = this.dbArtificialLiftDataSet3;
            // 
            // tblDailyMeasureTableAdapter
            // 
            this.tblDailyMeasureTableAdapter.ClearBeforeFill = true;
            // 
            // wellIDDataGridViewTextBoxColumn
            // 
            this.wellIDDataGridViewTextBoxColumn.DataPropertyName = "Well_ID";
            this.wellIDDataGridViewTextBoxColumn.HeaderText = "Well_ID";
            this.wellIDDataGridViewTextBoxColumn.Name = "wellIDDataGridViewTextBoxColumn";
            // 
            // pumpIDDataGridViewTextBoxColumn
            // 
            this.pumpIDDataGridViewTextBoxColumn.DataPropertyName = "Pump_ID";
            this.pumpIDDataGridViewTextBoxColumn.HeaderText = "Pump_ID";
            this.pumpIDDataGridViewTextBoxColumn.Name = "pumpIDDataGridViewTextBoxColumn";
            // 
            // measuredDateDataGridViewTextBoxColumn
            // 
            this.measuredDateDataGridViewTextBoxColumn.DataPropertyName = "Measured_Date";
            this.measuredDateDataGridViewTextBoxColumn.HeaderText = "Measured_Date";
            this.measuredDateDataGridViewTextBoxColumn.Name = "measuredDateDataGridViewTextBoxColumn";
            // 
            // wellStatusDataGridViewTextBoxColumn
            // 
            this.wellStatusDataGridViewTextBoxColumn.DataPropertyName = "Well_Status";
            this.wellStatusDataGridViewTextBoxColumn.HeaderText = "Well_Status";
            this.wellStatusDataGridViewTextBoxColumn.Name = "wellStatusDataGridViewTextBoxColumn";
            // 
            // cardAreaDataGridViewTextBoxColumn
            // 
            this.cardAreaDataGridViewTextBoxColumn.DataPropertyName = "Card_Area";
            this.cardAreaDataGridViewTextBoxColumn.HeaderText = "Card_Area";
            this.cardAreaDataGridViewTextBoxColumn.Name = "cardAreaDataGridViewTextBoxColumn";
            // 
            // peakSurfaceLoadDataGridViewTextBoxColumn
            // 
            this.peakSurfaceLoadDataGridViewTextBoxColumn.DataPropertyName = "Peak_Surface_Load";
            this.peakSurfaceLoadDataGridViewTextBoxColumn.HeaderText = "Peak_Surface_Load";
            this.peakSurfaceLoadDataGridViewTextBoxColumn.Name = "peakSurfaceLoadDataGridViewTextBoxColumn";
            // 
            // minimumSurfaceLoadDataGridViewTextBoxColumn
            // 
            this.minimumSurfaceLoadDataGridViewTextBoxColumn.DataPropertyName = "Minimum_Surface_Load";
            this.minimumSurfaceLoadDataGridViewTextBoxColumn.HeaderText = "Minimum_Surface_Load";
            this.minimumSurfaceLoadDataGridViewTextBoxColumn.Name = "minimumSurfaceLoadDataGridViewTextBoxColumn";
            // 
            // strokePerMinuteDataGridViewTextBoxColumn
            // 
            this.strokePerMinuteDataGridViewTextBoxColumn.DataPropertyName = "Stroke_Per_Minute";
            this.strokePerMinuteDataGridViewTextBoxColumn.HeaderText = "Stroke_Per_Minute";
            this.strokePerMinuteDataGridViewTextBoxColumn.Name = "strokePerMinuteDataGridViewTextBoxColumn";
            // 
            // surfaceStrokeLengthDataGridViewTextBoxColumn
            // 
            this.surfaceStrokeLengthDataGridViewTextBoxColumn.DataPropertyName = "Surface_Stroke_Length";
            this.surfaceStrokeLengthDataGridViewTextBoxColumn.HeaderText = "Surface_Stroke_Length";
            this.surfaceStrokeLengthDataGridViewTextBoxColumn.Name = "surfaceStrokeLengthDataGridViewTextBoxColumn";
            // 
            // flowLinePressureDataGridViewTextBoxColumn
            // 
            this.flowLinePressureDataGridViewTextBoxColumn.DataPropertyName = "Flow_Line_Pressure";
            this.flowLinePressureDataGridViewTextBoxColumn.HeaderText = "Flow_Line_Pressure";
            this.flowLinePressureDataGridViewTextBoxColumn.Name = "flowLinePressureDataGridViewTextBoxColumn";
            // 
            // pumpFillageDataGridViewTextBoxColumn
            // 
            this.pumpFillageDataGridViewTextBoxColumn.DataPropertyName = "Pump_Fillage";
            this.pumpFillageDataGridViewTextBoxColumn.HeaderText = "Pump_Fillage";
            this.pumpFillageDataGridViewTextBoxColumn.Name = "pumpFillageDataGridViewTextBoxColumn";
            // 
            // yesterdayCyclesDataGridViewTextBoxColumn
            // 
            this.yesterdayCyclesDataGridViewTextBoxColumn.DataPropertyName = "Yesterday_Cycles";
            this.yesterdayCyclesDataGridViewTextBoxColumn.HeaderText = "Yesterday_Cycles";
            this.yesterdayCyclesDataGridViewTextBoxColumn.Name = "yesterdayCyclesDataGridViewTextBoxColumn";
            // 
            // dailyRuntimeDataGridViewTextBoxColumn
            // 
            this.dailyRuntimeDataGridViewTextBoxColumn.DataPropertyName = "Daily_Runtime";
            this.dailyRuntimeDataGridViewTextBoxColumn.HeaderText = "Daily_Runtime";
            this.dailyRuntimeDataGridViewTextBoxColumn.Name = "dailyRuntimeDataGridViewTextBoxColumn";
            // 
            // gearboxTorqueDataGridViewTextBoxColumn
            // 
            this.gearboxTorqueDataGridViewTextBoxColumn.DataPropertyName = "Gearbox_Torque";
            this.gearboxTorqueDataGridViewTextBoxColumn.HeaderText = "Gearbox_Torque";
            this.gearboxTorqueDataGridViewTextBoxColumn.Name = "gearboxTorqueDataGridViewTextBoxColumn";
            // 
            // polishedRodHorsePowerDataGridViewTextBoxColumn
            // 
            this.polishedRodHorsePowerDataGridViewTextBoxColumn.DataPropertyName = "Polished_Rod_Horse_Power";
            this.polishedRodHorsePowerDataGridViewTextBoxColumn.HeaderText = "Polished_Rod_Horse_Power";
            this.polishedRodHorsePowerDataGridViewTextBoxColumn.Name = "polishedRodHorsePowerDataGridViewTextBoxColumn";
            // 
            // netDownholePumpEfficiencyDataGridViewTextBoxColumn
            // 
            this.netDownholePumpEfficiencyDataGridViewTextBoxColumn.DataPropertyName = "Net_Downhole_Pump_Efficiency";
            this.netDownholePumpEfficiencyDataGridViewTextBoxColumn.HeaderText = "Net_Downhole_Pump_Efficiency";
            this.netDownholePumpEfficiencyDataGridViewTextBoxColumn.Name = "netDownholePumpEfficiencyDataGridViewTextBoxColumn";
            // 
            // lastApprovedOilDataGridViewTextBoxColumn
            // 
            this.lastApprovedOilDataGridViewTextBoxColumn.DataPropertyName = "Last_Approved_Oil";
            this.lastApprovedOilDataGridViewTextBoxColumn.HeaderText = "Last_Approved_Oil";
            this.lastApprovedOilDataGridViewTextBoxColumn.Name = "lastApprovedOilDataGridViewTextBoxColumn";
            // 
            // lastApprovedWaterDataGridViewTextBoxColumn
            // 
            this.lastApprovedWaterDataGridViewTextBoxColumn.DataPropertyName = "Last_Approved_Water";
            this.lastApprovedWaterDataGridViewTextBoxColumn.HeaderText = "Last_Approved_Water";
            this.lastApprovedWaterDataGridViewTextBoxColumn.Name = "lastApprovedWaterDataGridViewTextBoxColumn";
            // 
            // fluidLevelDataGridViewTextBoxColumn
            // 
            this.fluidLevelDataGridViewTextBoxColumn.DataPropertyName = "Fluid_Level";
            this.fluidLevelDataGridViewTextBoxColumn.HeaderText = "Fluid_Level";
            this.fluidLevelDataGridViewTextBoxColumn.Name = "fluidLevelDataGridViewTextBoxColumn";
            // 
            // grossFluidRateDataGridViewTextBoxColumn
            // 
            this.grossFluidRateDataGridViewTextBoxColumn.DataPropertyName = "Gross_Fluid_Rate";
            this.grossFluidRateDataGridViewTextBoxColumn.HeaderText = "Gross_Fluid_Rate";
            this.grossFluidRateDataGridViewTextBoxColumn.Name = "grossFluidRateDataGridViewTextBoxColumn";
            // 
            // FrmDailyMeasureReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Name = "FrmDailyMeasureReport";
            this.Text = "Daily Measure Report";
            this.Load += new System.EventHandler(this.FrmDailyMeasureReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbArtificialLiftDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDailyMeasureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbArtificialLiftDataSet3 dbArtificialLiftDataSet3;
        private System.Windows.Forms.BindingSource tblDailyMeasureBindingSource;
        private dbArtificialLiftDataSet3TableAdapters.tblDailyMeasureTableAdapter tblDailyMeasureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wellIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pumpIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measuredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wellStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peakSurfaceLoadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumSurfaceLoadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strokePerMinuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceStrokeLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowLinePressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pumpFillageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yesterdayCyclesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyRuntimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearboxTorqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polishedRodHorsePowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netDownholePumpEfficiencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastApprovedOilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastApprovedWaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fluidLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossFluidRateDataGridViewTextBoxColumn;
    }
}