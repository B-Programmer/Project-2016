namespace ComputerizedLabSystemAllocation
{
    partial class FrmStudentReports
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
            this.label8 = new System.Windows.Forms.Label();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentMatricNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSchoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmeOfStudyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbStudentRegDataSet = new ComputerizedLabSystemAllocation.dbStudentRegDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.tblStudentRegTableAdapter = new ComputerizedLabSystemAllocation.dbStudentRegDataSetTableAdapters.tblStudentRegTableAdapter();
            this.tblStudentRegBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbStudentRegReportDataSet1 = new ComputerizedLabSystemAllocation.dbStudentRegReportDataSet1();
            this.tblStudentRegBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentRegTableAdapter1 = new ComputerizedLabSystemAllocation.dbStudentRegReportDataSet1TableAdapters.tblStudentRegTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentRegDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentRegBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentRegReportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentRegBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(296, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 36);
            this.label8.TabIndex = 33;
            this.label8.Text = "Student Report";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMarquee
            // 
            this.lblMarquee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMarquee.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarquee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarquee.Location = new System.Drawing.Point(90, 9);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(718, 28);
            this.lblMarquee.TabIndex = 32;
            this.lblMarquee.Text = "A Computerized Laboratory System Allocation Software";
            this.lblMarquee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentMatricNoDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSexDataGridViewTextBoxColumn,
            this.studentLevelDataGridViewTextBoxColumn,
            this.studentSchoolDataGridViewTextBoxColumn,
            this.studentDepartmentDataGridViewTextBoxColumn,
            this.programmeOfStudyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentRegBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(19, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 444);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentMatricNoDataGridViewTextBoxColumn
            // 
            this.studentMatricNoDataGridViewTextBoxColumn.DataPropertyName = "Student_Matric_No";
            this.studentMatricNoDataGridViewTextBoxColumn.HeaderText = "Student_Matric_No";
            this.studentMatricNoDataGridViewTextBoxColumn.Name = "studentMatricNoDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSexDataGridViewTextBoxColumn
            // 
            this.studentSexDataGridViewTextBoxColumn.DataPropertyName = "Student_Sex";
            this.studentSexDataGridViewTextBoxColumn.HeaderText = "Student_Sex";
            this.studentSexDataGridViewTextBoxColumn.Name = "studentSexDataGridViewTextBoxColumn";
            // 
            // studentLevelDataGridViewTextBoxColumn
            // 
            this.studentLevelDataGridViewTextBoxColumn.DataPropertyName = "Student_Level";
            this.studentLevelDataGridViewTextBoxColumn.HeaderText = "Student_Level";
            this.studentLevelDataGridViewTextBoxColumn.Name = "studentLevelDataGridViewTextBoxColumn";
            // 
            // studentSchoolDataGridViewTextBoxColumn
            // 
            this.studentSchoolDataGridViewTextBoxColumn.DataPropertyName = "Student_School";
            this.studentSchoolDataGridViewTextBoxColumn.HeaderText = "Student_School";
            this.studentSchoolDataGridViewTextBoxColumn.Name = "studentSchoolDataGridViewTextBoxColumn";
            // 
            // studentDepartmentDataGridViewTextBoxColumn
            // 
            this.studentDepartmentDataGridViewTextBoxColumn.DataPropertyName = "Student_Department";
            this.studentDepartmentDataGridViewTextBoxColumn.HeaderText = "Student_Department";
            this.studentDepartmentDataGridViewTextBoxColumn.Name = "studentDepartmentDataGridViewTextBoxColumn";
            // 
            // programmeOfStudyDataGridViewTextBoxColumn
            // 
            this.programmeOfStudyDataGridViewTextBoxColumn.DataPropertyName = "Programme_Of_Study";
            this.programmeOfStudyDataGridViewTextBoxColumn.HeaderText = "Programme_Of_Study";
            this.programmeOfStudyDataGridViewTextBoxColumn.Name = "programmeOfStudyDataGridViewTextBoxColumn";
            // 
            // tblStudentRegBindingSource
            // 
            this.tblStudentRegBindingSource.DataMember = "tblStudentReg";
            this.tblStudentRegBindingSource.DataSource = this.dbStudentRegDataSet;
            // 
            // dbStudentRegDataSet
            // 
            this.dbStudentRegDataSet.DataSetName = "dbStudentRegDataSet";
            this.dbStudentRegDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(707, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 33);
            this.button3.TabIndex = 70;
            this.button3.Text = "&Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblStudentRegTableAdapter
            // 
            this.tblStudentRegTableAdapter.ClearBeforeFill = true;
            // 
            // tblStudentRegBindingSource1
            // 
            this.tblStudentRegBindingSource1.DataMember = "tblStudentReg";
            this.tblStudentRegBindingSource1.DataSource = this.dbStudentRegDataSet;
            // 
            // dbStudentRegReportDataSet1
            // 
            this.dbStudentRegReportDataSet1.DataSetName = "dbStudentRegReportDataSet1";
            this.dbStudentRegReportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentRegBindingSource2
            // 
            this.tblStudentRegBindingSource2.DataMember = "tblStudentReg";
            this.tblStudentRegBindingSource2.DataSource = this.dbStudentRegReportDataSet1;
            // 
            // tblStudentRegTableAdapter1
            // 
            this.tblStudentRegTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmStudentReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedLabSystemAllocation.Properties.Resources.cloud;
            this.ClientSize = new System.Drawing.Size(880, 579);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMarquee);
            this.MaximizeBox = false;
            this.Name = "FrmStudentReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Reports";
            this.Load += new System.EventHandler(this.FrmStudentReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentRegDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentRegBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStudentRegReportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentRegBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbStudentRegDataSet dbStudentRegDataSet;
        private System.Windows.Forms.BindingSource tblStudentRegBindingSource;
        private dbStudentRegDataSetTableAdapters.tblStudentRegTableAdapter tblStudentRegTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentMatricNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSchoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programmeOfStudyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblStudentRegBindingSource1;
        private dbStudentRegReportDataSet1 dbStudentRegReportDataSet1;
        private System.Windows.Forms.BindingSource tblStudentRegBindingSource2;
        private dbStudentRegReportDataSet1TableAdapters.tblStudentRegTableAdapter tblStudentRegTableAdapter1;
    }
}