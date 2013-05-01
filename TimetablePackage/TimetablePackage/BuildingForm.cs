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
                int rowIndex = 0;
                int arraySize = ttpDataSet.Building.Rows.Count;
                int groupBoxNamer = arraySize;
                String[] groupBoxArray = new String[arraySize];
                DataRow[] groupArray = new DataRow[arraySize];

                GroupBox[] buildingGroup = new System.Windows.Forms.GroupBox[groupBoxNamer];
                for (rowIndex = 0; rowIndex < arraySize; rowIndex++)
                {
                    int groupBoxLocater = 0;
                    groupBoxArray[rowIndex] = ttpDataSet.Building.Rows[rowIndex]["Building_Name"].ToString();
                    buildingGroup[rowIndex] = new GroupBox();
                    buildingGroup[rowIndex].Name = groupBoxArray[rowIndex].ToString();
                    //buildingGroup[groupBoxNamer].BackColor = Color.;
                    //buildingGroup[groupBoxNamer].ForeColor = Color.Maroon;
                    buildingGroup[rowIndex].Text = groupBoxArray[rowIndex].ToString();
                    buildingGroup[rowIndex].Font = new Font("Georgia", 12);
                   // buildingGroup[rowIndex].location = new System.Drawing.Point(410, 32);
                    //   buildingGroup[groupBoxNamer].Visible = true;
                    buildingGroup[rowIndex].Location = new System.Drawing.Point(410, groupBoxLocater + 50);
                    this.Controls.Add(buildingGroup[rowIndex]);

                    groupBoxLocater = groupBoxLocater + 20;
                }

            /*    for (rowIndex = 0; rowIndex < arraySize; rowIndex++)
                {
                   

                    //buildingGroup[rowIndex].Name = groupBoxArray[rowIndex].ToString();
                   // buildingGroup[groupBoxNamer].BackColor = Color.;
                   // buildingGroup[groupBoxNamer].ForeColor = Color.Maroon;
                   // buildingGroup[rowIndex].Text = groupBoxArray[rowIndex].ToString();
                   // buildingGroup[rowIndex].Font = new Font("Georgia", 12);
                 //   buildingGroup.Location = new System.Drawing.Point(410, 32);
                 //   buildingGroup[groupBoxNamer].Visible = true;
                    this.Controls.Add(buildingGroup[rowIndex]);
              //      groupBoxNamer++;
                }*/
            }
          
        }
    }
}
