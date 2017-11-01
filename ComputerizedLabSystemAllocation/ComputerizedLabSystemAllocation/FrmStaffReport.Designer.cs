namespace ComputerizedLabSystemAllocation
{
    partial class FrmStaffReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSchoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStaffRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbStaffRegDataSet = new ComputerizedLabSystemAllocation.dbStaffRegDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tblStaffRegTableAdapter = new ComputerizedLabSystemAllocation.dbStaffRegDataSetTableAdapters.tblStaffRegTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStaffRegDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.staffSexDataGridViewTextBoxColumn,
            this.staffSchoolDataGridViewTextBoxColumn,
            this.staffDepartmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStaffRegBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 444);
            this.dataGridView1.TabIndex = 37;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Name";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "Staff_Name";
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            // 
            // staffSexDataGridViewTextBoxColumn
            // 
            this.staffSexDataGridViewTextBoxColumn.DataPropertyName = "Staff_Sex";
            this.staffSexDataGridViewTextBoxColumn.HeaderText = "Staff_Sex";
            this.staffSexDataGridViewTextBoxColumn.Name = "staffSexDataGridViewTextBoxColumn";
            // 
            // staffSchoolDataGridViewTextBoxColumn
            // 
            this.staffSchoolDataGridViewTextBoxColumn.DataPropertyName = "Staff_School";
            this.staffSchoolDataGridViewTextBoxColumn.HeaderText = "Staff_School";
            this.staffSchoolDataGridViewTextBoxColumn.Name = "staffSchoolDataGridViewTextBoxColumn";
            // 
            // staffDepartmentDataGridViewTextBoxColumn
            // 
            this.staffDepartmentDataGridViewTextBoxColumn.DataPropertyName = "Staff_Department";
            this.staffDepartmentDataGridViewTextBoxColumn.HeaderText = "Staff_Department";
            this.staffDepartmentDataGridViewTextBoxColumn.Name = "staffDepartmentDataGridViewTextBoxColumn";
            // 
            // tblStaffRegBindingSource
            // 
            this.tblStaffRegBindingSource.DataMember = "tblStaffReg";
            this.tblStaffRegBindingSource.DataSource = this.dbStaffRegDataSet;
            // 
            // dbStaffRegDataSet
            // 
            this.dbStaffRegDataSet.DataSetName = "dbStaffRegDataSet";
            this.dbStaffRegDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(295, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 36);
            this.label8.TabIndex = 36;
            this.label8.Text = "Staff Report";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMarquee
            // 
            this.lblMarquee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMarquee.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarquee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarquee.Location = new System.Drawing.Point(89, 11);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(718, 28);
            this.lblMarquee.TabIndex = 35;
            this.lblMarquee.Text = "A Computerized Laboratory System Allocation Software";
            this.lblMarquee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(706, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 33);
            this.button3.TabIndex = 71;
            this.button3.Text = "&Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblStaffRegTableAdapter
            // 
            this.tblStaffRegTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStaffReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedLabSystemAllocation.Properties.Resources.cloud;
            this.ClientSize = new System.Drawing.Size(887, 586);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMarquee);
            this.MaximizeBox = false;
            this.Name = "FrmStaffReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Staff Report";
            this.Load += new System.EventHandler(this.FrmStaffReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStaffRegDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Button button3;
        private dbStaffRegDataSet dbStaffRegDataSet;
        private System.Windows.Forms.BindingSource tblStaffRegBindingSource;
        private dbStaffRegDataSetTableAdapters.tblStaffRegTableAdapter tblStaffRegTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffSchoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDepartmentDataGridViewTextBoxColumn;
    }
}