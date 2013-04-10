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

namespace TimetablePackage
{
    public partial class SettingsForm : Form
    {
        //Main m_form;
        public SettingsForm()
        {
            
            InitializeComponent();
           // m_form = main;
        }
       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void settingsFormSaveButton_Click(object sender, EventArgs e)
        {
            //this.text = Settings.Default["MainTitle"].ToString;
            Settings.Default["MainTitle"] = insNameTextBox.Text;
            Properties.Settings.Default.Save();
        }



       
    }
}
