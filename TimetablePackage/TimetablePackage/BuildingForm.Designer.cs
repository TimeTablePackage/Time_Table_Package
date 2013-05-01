namespace TimetablePackage
{
    partial class BuildingForm
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
            this.CourseGroupBox = new System.Windows.Forms.GroupBox();
            this.CourseDataGridView = new System.Windows.Forms.DataGridView();
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.BuildingTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseGroupBox
            // 
            this.CourseGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseGroupBox.Controls.Add(this.CourseDataGridView);
            this.CourseGroupBox.Location = new System.Drawing.Point(114, 12);
            this.CourseGroupBox.Name = "CourseGroupBox";
            this.CourseGroupBox.Size = new System.Drawing.Size(173, 308);
            this.CourseGroupBox.TabIndex = 9;
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
            this.buildingNameDataGridViewTextBoxColumn});
            this.CourseDataGridView.DataSource = this.buildingBindingSource;
            this.CourseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.CourseDataGridView.Location = new System.Drawing.Point(3, 16);
            this.CourseDataGridView.MultiSelect = false;
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.ReadOnly = true;
            this.CourseDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CourseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CourseDataGridView.RowTemplate.ReadOnly = true;
            this.CourseDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGridView.Size = new System.Drawing.Size(167, 289);
            this.CourseDataGridView.TabIndex = 1;
            // 
            // ttpDataSet
            // 
            this.ttpDataSet.DataSetName = "ttpDataSet";
            this.ttpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataMember = "Building";
            this.buildingBindingSource.DataSource = this.ttpDataSet;
            // 
            // buildingTableAdapter
            // 
            this.buildingTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // buildingNameDataGridViewTextBoxColumn
            // 
            this.buildingNameDataGridViewTextBoxColumn.DataPropertyName = "Building_Name";
            this.buildingNameDataGridViewTextBoxColumn.HeaderText = "Building Name";
            this.buildingNameDataGridViewTextBoxColumn.Name = "buildingNameDataGridViewTextBoxColumn";
            this.buildingNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.Controls.Add(this.CourseGroupBox);
            this.Name = "BuildingForm";
            this.Text = "BuildingForm";
            this.Load += new System.EventHandler(this.BuildingForm_Load);
            this.CourseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CourseGroupBox;
        private System.Windows.Forms.DataGridView CourseDataGridView;
        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private ttpDataSetTableAdapters.BuildingTableAdapter buildingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNameDataGridViewTextBoxColumn;
    }
}