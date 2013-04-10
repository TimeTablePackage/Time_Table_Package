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
            
            Settings.Default["MainTitle"] = insNameTextBox.Text;

            Settings.Default["InstitutionName"] = insNameTextBox.Text;
            Settings.Default["AddressLine1"] = addLine1TextBox.Text;
            Settings.Default["AddressLine2"] = addLine2TextBox.Text;
            Settings.Default["AddressLine3"] = addLine3TextBox.Text;
            Settings.Default["CityName"] = cityTextBox.Text;
            Settings.Default["Country"] = countryComboBox.SelectedIndex.ToString();
            Settings.Default["WebSiteInfo"] = websiteTextBox.Text;
            Settings.Default["Telephone"] = telephoneTextBox.Text;
            Settings.Default["AcademicYearInfo"] = academicYearTextBox.Text;



            Properties.Settings.Default.Save();
           // Application.Run(new SettingsForm());
           // Application.Run(new Main());
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
             insNameTextBox.Text=Settings.Default["InstitutionName"].ToString();
            addLine1TextBox.Text= Settings.Default["AddressLine1"].ToString()  ;
             addLine2TextBox.Text=Settings.Default["AddressLine2"].ToString()  ;
             addLine3TextBox.Text=Settings.Default["AddressLine3"].ToString()  ;
            cityTextBox.Text =Settings.Default["CityName"].ToString()  ;
             countryComboBox.SelectedItem.ToString()= Settings.Default["Country"]  ;
            websiteTextBox.Text =Settings.Default["WebSiteInfo"].ToString()  ;
            telephoneTextBox.Text = Settings.Default["Telephone"].ToString();
            academicYearTextBox.Text = Settings.Default["AcademicYearInfo"].ToString();
        }



       
    }
}
