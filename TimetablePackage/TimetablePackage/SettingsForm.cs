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
        public SettingsForm()
        {
            InitializeComponent();
        }
        private Main mainForm = null;
        public SettingsForm(Form callingForm)
        {
            mainForm = callingForm as Main; 
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void settingsFormSaveButton_Click(object sender, EventArgs e)
        {
            //this.text = Settings.Default["MainTitle"].ToString;
            this.mainForm.Text = insNameTextBox.Text;
            Properties.Settings.Default.Save();
        }



       
    }
}
