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
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.buildingTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.BuildingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataMember = "Building";
            this.buildingBindingSource.DataSource = this.ttpDataSet;
            // 
            // ttpDataSet
            // 
            this.ttpDataSet.DataSetName = "ttpDataSet";
            this.ttpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingTableAdapter
            // 
            this.buildingTableAdapter.ClearBeforeFill = true;
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.DockAreas = ((DigitalRune.Windows.Docking.DockAreas)((((((DigitalRune.Windows.Docking.DockAreas.Float | DigitalRune.Windows.Docking.DockAreas.Left) 
            | DigitalRune.Windows.Docking.DockAreas.Right) 
            | DigitalRune.Windows.Docking.DockAreas.Top) 
            | DigitalRune.Windows.Docking.DockAreas.Bottom) 
            | DigitalRune.Windows.Docking.DockAreas.Document)));
            this.Name = "BuildingForm";
            this.TabText = "BuildingForm";
            this.Text = "BuildingForm";
            this.Load += new System.EventHandler(this.BuildingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private ttpDataSetTableAdapters.BuildingTableAdapter buildingTableAdapter;
    }
}