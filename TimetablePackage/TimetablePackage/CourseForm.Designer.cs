namespace TimetablePackage
{
    partial class CourseForm
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
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.courseTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.CourseTableAdapter();
            this.CourseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
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
            this.deleteCourseButton.TabIndex = 11;
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
            this.editCourseButton.TabIndex = 10;
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
            this.addCourseButton.TabIndex = 9;
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
            this.CourseGroupBox.Size = new System.Drawing.Size(951, 267);
            this.CourseGroupBox.TabIndex = 8;
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
            this.codeDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.numOfStudentsDataGridViewTextBoxColumn,
            this.deptIDDataGridViewTextBoxColumn});
            this.CourseDataGridView.DataSource = this.courseBindingSource;
            this.CourseDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.CourseDataGridView.Location = new System.Drawing.Point(244, 16);
            this.CourseDataGridView.MultiSelect = false;
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.ReadOnly = true;
            this.CourseDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CourseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CourseDataGridView.RowTemplate.ReadOnly = true;
            this.CourseDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGridView.Size = new System.Drawing.Size(462, 248);
            this.CourseDataGridView.TabIndex = 0;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Course Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 93;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseNameDataGridViewTextBoxColumn.Width = 96;
            // 
            // numOfStudentsDataGridViewTextBoxColumn
            // 
            this.numOfStudentsDataGridViewTextBoxColumn.DataPropertyName = "NumOfStudents";
            this.numOfStudentsDataGridViewTextBoxColumn.HeaderText = "Number of Students";
            this.numOfStudentsDataGridViewTextBoxColumn.Name = "numOfStudentsDataGridViewTextBoxColumn";
            this.numOfStudentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numOfStudentsDataGridViewTextBoxColumn.Width = 126;
            // 
            // deptIDDataGridViewTextBoxColumn
            // 
            this.deptIDDataGridViewTextBoxColumn.DataPropertyName = "DeptID";
            this.deptIDDataGridViewTextBoxColumn.HeaderText = "Department ID";
            this.deptIDDataGridViewTextBoxColumn.Name = "deptIDDataGridViewTextBoxColumn";
            this.deptIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptIDDataGridViewTextBoxColumn.Width = 101;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.ttpDataSet;
            // 
            // ttpDataSet
            // 
            this.ttpDataSet.DataSetName = "ttpDataSet";
            this.ttpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.Controls.Add(this.deleteCourseButton);
            this.Controls.Add(this.editCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.CourseGroupBox);
            this.DockAreas = ((DigitalRune.Windows.Docking.DockAreas)((((((DigitalRune.Windows.Docking.DockAreas.Float | DigitalRune.Windows.Docking.DockAreas.Left) 
            | DigitalRune.Windows.Docking.DockAreas.Right) 
            | DigitalRune.Windows.Docking.DockAreas.Top) 
            | DigitalRune.Windows.Docking.DockAreas.Bottom) 
            | DigitalRune.Windows.Docking.DockAreas.Document)));
            this.Name = "CourseForm";
            this.TabText = "Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.CourseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteCourseButton;
        private System.Windows.Forms.Button editCourseButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.GroupBox CourseGroupBox;
        private System.Windows.Forms.DataGridView CourseDataGridView;
        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private ttpDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIDDataGridViewTextBoxColumn;
    }
}