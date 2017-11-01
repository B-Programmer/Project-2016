namespace FailurePredictionArtificialLiftSystem
{
    partial class FrmWellReport
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
            this.wellIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wellPermitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wellNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wellStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wellTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblWellRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbArtificialLiftDataSet1 = new FailurePredictionArtificialLiftSystem.dbArtificialLiftDataSet1();
            this.tblWellRegTableAdapter = new FailurePredictionArtificialLiftSystem.dbArtificialLiftDataSet1TableAdapters.tblWellRegTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWellRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbArtificialLiftDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(223, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(421, 33);
            this.label12.TabIndex = 4;
            this.label12.Text = "Oil, Water and Gas Well Report";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(84, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(728, 33);
            this.label11.TabIndex = 3;
            this.label11.Text = "Failure Prediction for Rod Pump Artificial Lift Systems";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(29, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 445);
            this.panel1.TabIndex = 5;
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
            this.wellIDDataGridViewTextBoxColumn,
            this.wellPermitDataGridViewTextBoxColumn,
            this.operatorNameDataGridViewTextBoxColumn,
            this.fieldDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.wellNameDataGridViewTextBoxColumn,
            this.wellStatusDataGridViewTextBoxColumn,
            this.wellTypeDataGridViewTextBoxColumn,
            this.flowTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblWellRegBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // wellIDDataGridViewTextBoxColumn
            // 
            this.wellIDDataGridViewTextBoxColumn.DataPropertyName = "Well_ID";
            this.wellIDDataGridViewTextBoxColumn.HeaderText = "Well_ID";
            this.wellIDDataGridViewTextBoxColumn.Name = "wellIDDataGridViewTextBoxColumn";
            // 
            // wellPermitDataGridViewTextBoxColumn
            // 
            this.wellPermitDataGridViewTextBoxColumn.DataPropertyName = "Well_Permit";
            this.wellPermitDataGridViewTextBoxColumn.HeaderText = "Well_Permit";
            this.wellPermitDataGridViewTextBoxColumn.Name = "wellPermitDataGridViewTextBoxColumn";
            // 
            // operatorNameDataGridViewTextBoxColumn
            // 
            this.operatorNameDataGridViewTextBoxColumn.DataPropertyName = "Operator_Name";
            this.operatorNameDataGridViewTextBoxColumn.HeaderText = "Operator_Name";
            this.operatorNameDataGridViewTextBoxColumn.Name = "operatorNameDataGridViewTextBoxColumn";
            // 
            // fieldDataGridViewTextBoxColumn
            // 
            this.fieldDataGridViewTextBoxColumn.DataPropertyName = "Field";
            this.fieldDataGridViewTextBoxColumn.HeaderText = "Field";
            this.fieldDataGridViewTextBoxColumn.Name = "fieldDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // wellNameDataGridViewTextBoxColumn
            // 
            this.wellNameDataGridViewTextBoxColumn.DataPropertyName = "Well_Name";
            this.wellNameDataGridViewTextBoxColumn.HeaderText = "Well_Name";
            this.wellNameDataGridViewTextBoxColumn.Name = "wellNameDataGridViewTextBoxColumn";
            // 
            // wellStatusDataGridViewTextBoxColumn
            // 
            this.wellStatusDataGridViewTextBoxColumn.DataPropertyName = "Well_Status";
            this.wellStatusDataGridViewTextBoxColumn.HeaderText = "Well_Status";
            this.wellStatusDataGridViewTextBoxColumn.Name = "wellStatusDataGridViewTextBoxColumn";
            // 
            // wellTypeDataGridViewTextBoxColumn
            // 
            this.wellTypeDataGridViewTextBoxColumn.DataPropertyName = "Well_Type";
            this.wellTypeDataGridViewTextBoxColumn.HeaderText = "Well_Type";
            this.wellTypeDataGridViewTextBoxColumn.Name = "wellTypeDataGridViewTextBoxColumn";
            // 
            // flowTypeDataGridViewTextBoxColumn
            // 
            this.flowTypeDataGridViewTextBoxColumn.DataPropertyName = "Flow_Type";
            this.flowTypeDataGridViewTextBoxColumn.HeaderText = "Flow_Type";
            this.flowTypeDataGridViewTextBoxColumn.Name = "flowTypeDataGridViewTextBoxColumn";
            // 
            // tblWellRegBindingSource
            // 
            this.tblWellRegBindingSource.DataMember = "tblWellReg";
            this.tblWellRegBindingSource.DataSource = this.dbArtificialLiftDataSet1;
            // 
            // dbArtificialLiftDataSet1
            // 
            this.dbArtificialLiftDataSet1.DataSetName = "dbArtificialLiftDataSet1";
            this.dbArtificialLiftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblWellRegTableAdapter
            // 
            this.tblWellRegTableAdapter.ClearBeforeFill = true;
            // 
            // FrmWellReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FailurePredictionArtificialLiftSystem.Properties.Resources._15_revert_fhd_2000x1125_2;
            this.ClientSize = new System.Drawing.Size(873, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Name = "FrmWellReport";
            this.Text = "Well Registration Report";
            this.Load += new System.EventHandler(this.FrmWellReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWellRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbArtificialLiftDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbArtificialLiftDataSet1 dbArtificialLiftDataSet1;
        private System.Windows.Forms.BindingSource tblWellRegBindingSource;
        private dbArtificialLiftDataSet1TableAdapters.tblWellRegTableAdapter tblWellRegTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wellIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wellPermitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wellNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wellStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wellTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancel;
    }
}