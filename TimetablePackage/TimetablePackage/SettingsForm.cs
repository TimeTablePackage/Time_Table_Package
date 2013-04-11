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
using System.Globalization;

namespace TimetablePackage
{
    public partial class SettingsForm : Form
    {
        Main m_form;
        public SettingsForm(Main main)
        {
            
            InitializeComponent();
            m_form = main;
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



            
            // Application.Run(new SettingsForm());
            // Application.Run(new Main());

            if (englishRadioButton.Checked == true )
            {
                Settings.Default["isDefault"] = true;
                Settings.Default["isTurkish"] = false;
                Settings.Default["isFrench"] = false;
                //SwitchTo("en");
               // Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en"); ;
               // Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en"); ;
            }
            else if (turkishRadioButton.Checked == true)
            {
              //  Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR"); ;
              //  Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR"); ;
                Settings.Default["isTurkish"] = true ;
                Settings.Default["isDefault"] = false;
                Settings.Default["isFrench"] = false;
                //SwitchTo("tr-TR");
            }
            else if (frenchRadioButton.Checked == true)
            {
                Settings.Default["isFrench"] = true ;
                Settings.Default["isTurkish"] = false;
                Settings.Default["isDefault"] = false;
                
               // Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR"); ;
               // Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR"); ;
               // SwitchTo("fr");
            }
            Properties.Settings.Default.Save();
            Application.ExitThread();
            Application.Run();
        }
            
        

        //private void SwitchTo(string selectedLang)
        //{
        //    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(selectedLang); ;
        //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(selectedLang); ;
        //    foreach (Form form in Application.OpenForms)
        //    {
        //       ComponentResourceManager resources = new ComponentResourceManager(m_form.GetType());
        //       // ComponentResourceManager resources = new ComponentResourceManager(typeof(Main));
        //        resources.ApplyResources(c, c.Name, new CultureInfo(selectedLang));
        //    }
        //}

        private void SettingsForm_Load(object sender, EventArgs e)
        {
             insNameTextBox.Text=Settings.Default["InstitutionName"].ToString();
            addLine1TextBox.Text= Settings.Default["AddressLine1"].ToString()  ;
             addLine2TextBox.Text=Settings.Default["AddressLine2"].ToString()  ;
             addLine3TextBox.Text=Settings.Default["AddressLine3"].ToString()  ;
            cityTextBox.Text =Settings.Default["CityName"].ToString()  ;
             countryComboBox.SelectedItem= Settings.Default["Country"]  ;
            websiteTextBox.Text =Settings.Default["WebSiteInfo"].ToString()  ;
            telephoneTextBox.Text = Settings.Default["Telephone"].ToString();
            academicYearTextBox.Text = Settings.Default["AcademicYearInfo"].ToString();
           // turkishRadioButton.Checked = Settings.Default["isTurkish"].ToString();
            if (Settings.Default["isTurkish"].Equals(true))
            {
                turkishRadioButton.Checked = true;
            }
            else if (Settings.Default["isDefault"].Equals(true))
            {
                englishRadioButton.Checked = true;
            }
            else
            {
                frenchRadioButton.Checked = true;
            }


        }



       
    }
}
