using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetablePackage.Properties;
using System.Threading;
using System.Data.OleDb;

namespace TimetablePackage
{
    public partial class Main : Form
    {

        private DataBase myDataBase = new DataBase();
       
        public Main()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
        }
        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
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
            SettingsForm settings;
            settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = Settings.Default["MainTitle"].ToString();
            LecturerNameList.DataSource = myDataBase.GetTableData("SELECT Lec_name FROM Lecturer");

        }

        private void LecturerNameList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string sql = "SELECT * FROM Lecturer WHERE Lec_Name LIKE '"+LecturerNameList.CurrentCell.Value.ToString()+"'";
            string datastring = myDataBase.GetData(sql);
            Lec_NametextBox.Text = datastring.Substring(0,datastring.IndexOf('$'));
            datastring = datastring.Substring(datastring.IndexOf('$') + 1);
            InitialstextBox.Text = datastring.Substring(0, datastring.IndexOf('$'));
            datastring = datastring.Substring(datastring.IndexOf('$') + 1);
            emailtextBox.Text = datastring.Substring(0, datastring.IndexOf('$'));
            datastring = datastring.Substring(datastring.IndexOf('$') + 1);
            //Lec_Name,Initials,Email
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

       
    
        


    }
}
