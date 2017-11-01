namespace FailurePredictionArtificialLiftSystem
{
    partial class FrmPumpReport
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
            this.pumpIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artificialLiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pumpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pumpDepthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingFrequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPumpRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbArtificialLiftDataSet2 = new FailurePredictionArtificialLiftSystem.dbArtificialLiftDataSet2();
            this.tblPumpRegTableAdapter = new FailurePredictionArtificialLiftSystem.dbArtificialLiftDataSet2TableAdapters.tblPumpRegTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPumpRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbArtificialLiftDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(244, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(359, 33);
            this.label12.TabIndex = 7;
            this.label12.Text = "Pump Artificial Lift Report";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(70, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(728, 33);
            this.label11.TabIndex = 6;
            this.label11.Text = "Failure Prediction for Rod Pump Artificial Lift Systems";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(23, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 445);
            this.panel1.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(677, 390);
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
            this.pumpIDDataGridViewTextBoxColumn,
            this.artificialLiftDataGridViewTextBoxColumn,
            this.pumpDataGridViewTextBoxColumn,
            this.operatingRangeDataGridViewTextBoxColumn,
            this.motorDataGridViewTextBoxColumn,
            this.cableDataGridViewTextBoxColumn,
            this.pumpDepthDataGridViewTextBoxColumn,
            this.operatingFrequencyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPumpRegBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // pumpIDDataGridViewTextBoxColumn
            // 
            this.pumpIDDataGridViewTextBoxColumn.DataPropertyName = "Pump_ID";
            this.pumpIDDataGridViewTextBoxColumn.HeaderText = "Pump_ID";
            this.pumpIDDataGridViewTextBoxColumn.Name = "pumpIDDataGridViewTextBoxColumn";
            // 
            // artificialLiftDataGridViewTextBoxColumn
            // 
            this.artificialLiftDataGridViewTextBoxColumn.DataPropertyName = "Artificial_Lift";
            this.artificialLiftDataGridViewTextBoxColumn.HeaderText = "Artificial_Lift";
            this.artificialLiftDataGridViewTextBoxColumn.Name = "artificialLiftDataGridViewTextBoxColumn";
            // 
            // pumpDataGridViewTextBoxColumn
            // 
            this.pumpDataGridViewTextBoxColumn.DataPropertyName = "Pump";
            this.pumpDataGridViewTextBoxColumn.HeaderText = "Pump";
            this.pumpDataGridViewTextBoxColumn.Name = "pumpDataGridViewTextBoxColumn";
            // 
            // operatingRangeDataGridViewTextBoxColumn
            // 
            this.operatingRangeDataGridViewTextBoxColumn.DataPropertyName = "Operating_Range";
            this.operatingRangeDataGridViewTextBoxColumn.HeaderText = "Operating_Range";
            this.operatingRangeDataGridViewTextBoxColumn.Name = "operatingRangeDataGridViewTextBoxColumn";
            // 
            // motorDataGridViewTextBoxColumn
            // 
            this.motorDataGridViewTextBoxColumn.DataPropertyName = "Motor";
            this.motorDataGridViewTextBoxColumn.HeaderText = "Motor";
            this.motorDataGridViewTextBoxColumn.Name = "motorDataGridViewTextBoxColumn";
            // 
            // cableDataGridViewTextBoxColumn
            // 
            this.cableDataGridViewTextBoxColumn.DataPropertyName = "Cable";
            this.cableDataGridViewTextBoxColumn.HeaderText = "Cable";
            this.cableDataGridViewTextBoxColumn.Name = "cableDataGridViewTextBoxColumn";
            // 
            // pumpDepthDataGridViewTextBoxColumn
            // 
            this.pumpDepthDataGridViewTextBoxColumn.DataPropertyName = "Pump_Depth";
            this.pumpDepthDataGridViewTextBoxColumn.HeaderText = "Pump_Depth";
            this.pumpDepthDataGridViewTextBoxColumn.Name = "pumpDepthDataGridViewTextBoxColumn";
            // 
            // operatingFrequencyDataGridViewTextBoxColumn
            // 
            this.operatingFrequencyDataGridViewTextBoxColumn.DataPropertyName = "Operating_Frequency";
            this.operatingFrequencyDataGridViewTextBoxColumn.HeaderText = "Operating_Frequency";
            this.operatingFrequencyDataGridViewTextBoxColumn.Name = "operatingFrequencyDataGridViewTextBoxColumn";
            // 
            // tblPumpRegBindingSource
            // 
            this.tblPumpRegBindingSource.DataMember = "tblPumpReg";
            this.tblPumpRegBindingSource.DataSource = this.dbArtificialLiftDataSet2;
            // 
            // dbArtificialLiftDataSet2
            // 
            this.dbArtificialLiftDataSet2.DataSetName = "dbArtificialLiftDataSet2";
            this.dbArtificialLiftDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPumpRegTableAdapter
            // 
            this.tblPumpRegTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPumpReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FailurePredictionArtificialLiftSystem.Properties.Resources._15_revert_fhd_2000x1125_2;
            this.ClientSize = new System.Drawing.Size(870, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Name = "FrmPumpReport";
            this.Text = "Pump Registration Report";
            this.Load += new System.EventHandler(this.FrmPumpReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPumpRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbArtificialLiftDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbArtificialLiftDataSet2 dbArtificialLiftDataSet2;
        private System.Windows.Forms.BindingSource tblPumpRegBindingSource;
        private dbArtificialLiftDataSet2TableAdapters.tblPumpRegTableAdapter tblPumpRegTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pumpIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artificialLiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pumpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pumpDepthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingFrequencyDataGridViewTextBoxColumn;
    }
}