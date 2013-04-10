using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetablePackage
{
    public partial class Main : Form
    {
        public String buildingName;
        public Int16 noOfRooms;

        public Main()
        {
            InitializeComponent();
            this.pictureBox00.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox01.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox02.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox03.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox04.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox05.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox06.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox07.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox08.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox10.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox11.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox12.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox13.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox14.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox15.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox16.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox17.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox18.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox20.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox21.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox22.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox23.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox24.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox25.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox26.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox27.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox28.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox30.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox31.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox32.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox33.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox34.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox35.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox36.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox37.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox38.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox40.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox41.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox42.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox43.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox44.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox45.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox46.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox47.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox48.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox50.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox51.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox52.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox53.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox54.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox55.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox56.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox57.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox58.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox60.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox61.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox62.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox63.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox64.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox65.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox66.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox67.Click += new System.EventHandler(this.changeIcon);
            this.pictureBox68.Click += new System.EventHandler(this.changeIcon);

            
           

        }
        /// <summary>
        /// An on click method for the pictureboxes to change the icon displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeIcon(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox) sender;
            if (temp.Tag.Equals("Tick"))
            {
                temp.Image = iconImageList.Images[1];
                temp.Tag = "Question";
            }
            else if (temp.Tag.Equals("Question"))
            {
                temp.Image = iconImageList.Images[2];
                temp.Tag = "Cross";
            }
            else if (temp.Tag.Equals("Cross"))
            {
                temp.Image = iconImageList.Images[0];
                temp.Tag = "Tick";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void licenceInfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {// The application will launch the text file that is located on the application start up path. 
         //The text file contains the licensing information.
            System.Diagnostics.Process.Start(Application.StartupPath + "\\licenceInfo.txt");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();


        }

       
    
        


    }
}
