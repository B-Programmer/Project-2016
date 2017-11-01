namespace ComputerizedCareerGuidanceMIS
{
    partial class FrmViewUserLog
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
            this.CmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.careerDbDataSet = new ComputerizedCareerGuidanceMIS.CareerDbDataSet();
            this.careerDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.careerDbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.careerDbDataSet1 = new ComputerizedCareerGuidanceMIS.CareerDbDataSet1();
            this.tblUserLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserLogTableAdapter = new ComputerizedCareerGuidanceMIS.CareerDbDataSet1TableAdapters.TblUserLogTableAdapter();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLogInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Location = new System.Drawing.Point(594, 454);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(180, 44);
            this.CmdCancel.TabIndex = 21;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(245, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "Report of all Users\' Log";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMarquee
            // 
            this.lblMarquee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMarquee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarquee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarquee.Location = new System.Drawing.Point(81, 13);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(711, 28);
            this.lblMarquee.TabIndex = 19;
            this.lblMarquee.Text = "Computerized Career Guidance Information Management System for Secondary School S" +
                "tudents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userTypeDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.dateLogInDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUserLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 314);
            this.dataGridView1.TabIndex = 22;
            // 
            // careerDbDataSet
            // 
            this.careerDbDataSet.DataSetName = "CareerDbDataSet";
            this.careerDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // careerDbDataSetBindingSource
            // 
            this.careerDbDataSetBindingSource.DataSource = this.careerDbDataSet;
            this.careerDbDataSetBindingSource.Position = 0;
            // 
            // careerDbDataSetBindingSource1
            // 
            this.careerDbDataSetBindingSource1.DataSource = this.careerDbDataSet;
            this.careerDbDataSetBindingSource1.Position = 0;
            // 
            // careerDbDataSet1
            // 
            this.careerDbDataSet1.DataSetName = "CareerDbDataSet1";
            this.careerDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserLogBindingSource
            // 
            this.tblUserLogBindingSource.DataMember = "TblUserLog";
            this.tblUserLogBindingSource.DataSource = this.careerDbDataSet1;
            // 
            // tblUserLogTableAdapter
            // 
            this.tblUserLogTableAdapter.ClearBeforeFill = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "User_Type";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User_Type";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User_Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // dateLogInDataGridViewTextBoxColumn
            // 
            this.dateLogInDataGridViewTextBoxColumn.DataPropertyName = "Date_Log_In";
            this.dateLogInDataGridViewTextBoxColumn.HeaderText = "Date_Log_In";
            this.dateLogInDataGridViewTextBoxColumn.Name = "dateLogInDataGridViewTextBoxColumn";
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "Time_In";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "Time_In";
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "Time_Out";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "Time_Out";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            // 
            // FrmViewUserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerizedCareerGuidanceMIS.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(872, 597);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMarquee);
            this.Name = "FrmViewUserLog";
            this.Text = "View User Log Report";
            this.Load += new System.EventHandler(this.FrmViewUserLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource careerDbDataSetBindingSource;
        private CareerDbDataSet careerDbDataSet;
        private System.Windows.Forms.BindingSource careerDbDataSetBindingSource1;
        private CareerDbDataSet1 careerDbDataSet1;
        private System.Windows.Forms.BindingSource tblUserLogBindingSource;
        private CareerDbDataSet1TableAdapters.TblUserLogTableAdapter tblUserLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLogInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
    }
}