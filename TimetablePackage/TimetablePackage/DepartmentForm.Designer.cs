namespace TimetablePackage
{
    partial class DepartmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteCourseButton = new System.Windows.Forms.Button();
            this.editCourseButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.CourseGroupBox = new System.Windows.Forms.GroupBox();
            this.CourseDataGridView = new System.Windows.Forms.DataGridView();
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.DepartmentTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CourseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteCourseButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourseButton.Image = global::TimetablePackage.Properties.Resources.delete;
            this.deleteCourseButton.Location = new System.Drawing.Point(554, 32);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(103, 43);
            this.deleteCourseButton.TabIndex = 15;
            this.deleteCourseButton.Text = "Remove";
            this.deleteCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            // 
            // editCourseButton
            // 
            this.editCourseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editCourseButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCourseButton.Image = global::TimetablePackage.Properties.Resources.bullet_edit;
            this.editCourseButton.Location = new System.Drawing.Point(445, 32);
            this.editCourseButton.Name = "editCourseButton";
            this.editCourseButton.Size = new System.Drawing.Size(103, 43);
            this.editCourseButton.TabIndex = 14;
            this.editCourseButton.Text = "Edit";
            this.editCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editCourseButton.UseVisualStyleBackColor = true;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addCourseButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Image = global::TimetablePackage.Properties.Resources.add;
            this.addCourseButton.Location = new System.Drawing.Point(336, 32);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(103, 43);
            this.addCourseButton.TabIndex = 13;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCourseButton.UseVisualStyleBackColor = true;
            // 
            // CourseGroupBox
            // 
            this.CourseGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseGroupBox.Controls.Add(this.CourseDataGridView);
            this.CourseGroupBox.Location = new System.Drawing.Point(21, 73);
            this.CourseGroupBox.Name = "CourseGroupBox";
            this.CourseGroupBox.Size = new System.Drawing.Size(690, 267);
            this.CourseGroupBox.TabIndex = 12;
            this.CourseGroupBox.TabStop = false;
            this.CourseGroupBox.Text = "Courses";
            // 
            // CourseDataGridView
            // 
            this.CourseDataGridView.AllowUserToAddRows = false;
            this.CourseDataGridView.AllowUserToDeleteRows = false;
            this.CourseDataGridView.AllowUserToResizeColumns = false;
            this.CourseDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CourseDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseDataGridView.AutoGenerateColumns = false;
            this.CourseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.CourseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.CourseDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CourseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CourseDataGridView.ColumnHeadersHeight = 21;
            this.CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CourseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.CourseDataGridView.DataSource = this.departmentBindingSource;
            this.CourseDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.CourseDataGridView.Location = new System.Drawing.Point(17, 13);
            this.CourseDataGridView.MultiSelect = false;
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.ReadOnly = true;
            this.CourseDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CourseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CourseDataGridView.RowTemplate.ReadOnly = true;
            this.CourseDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGridView.Size = new System.Drawing.Size(177, 248);
            this.CourseDataGridView.TabIndex = 0;
            // 
            // ttpDataSet
            // 
            this.ttpDataSet.DataSetName = "ttpDataSet";
            this.ttpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.ttpDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "Dept_Name";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "Dept_Name";
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptNameDataGridViewTextBoxColumn.Width = 89;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn.Width = 50;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.Controls.Add(this.deleteCourseButton);
            this.Controls.Add(this.editCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.CourseGroupBox);
            this.Name = "DepartmentForm";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.CourseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteCourseButton;
        private System.Windows.Forms.Button editCourseButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.GroupBox CourseGroupBox;
        private System.Windows.Forms.DataGridView CourseDataGridView;
        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private ttpDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
    }
}