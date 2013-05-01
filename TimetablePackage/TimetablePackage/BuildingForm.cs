using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DigitalRune.Windows.Docking;

namespace TimetablePackage
{
    public partial class BuildingForm : DockableForm
    {
        
        public BuildingForm()
        {
            InitializeComponent();
        }

        private void BuildingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttpDataSet.Building' table. You can move, or remove it, as needed.
            this.buildingTableAdapter.Fill(this.ttpDataSet.Building);


            

            if (ttpDataSet.Building.Rows.Count > 0)
            {
                int rowIndex = 0 ;
                int arraySize = ttpDataSet.Building.Rows.Count;
                String[] groupBoxArray = new String[arraySize];
                DataRow[] groupArray = new DataRow[arraySize];


                for ( rowIndex = 0 ; rowIndex < arraySize ;rowIndex++ )
                {
                   groupBoxArray[rowIndex] = ttpDataSet.Building.Rows[rowIndex]["Building_Name"].ToString();
                }

                for ( rowIndex = 0 ; rowIndex < arraySize ; rowIndex++)
                {
                    GroupBox buildingGroup = new GroupBox();
                    buildingGroup.Name = groupBoxArray[rowIndex].ToString();
                    buildingGroup.BackColor = Color.LightBlue;
                    buildingGroup.ForeColor = Color.Maroon;
                    buildingGroup.Text = "Author Details";
                    buildingGroup.Font = new Font("Georgia", 12);

                
               
                
            }
            else
            {
                MessageBox.Show("Empty");
            }
        }
    }
}
