namespace TimetablePackage
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainTab = new System.Windows.Forms.RibbonTab();
            this.homePanel = new System.Windows.Forms.RibbonPanel();
            this.timetableTab = new System.Windows.Forms.RibbonTab();
            this.lecturersTab = new System.Windows.Forms.RibbonTab();
            this.buildingsTab = new System.Windows.Forms.RibbonTab();
            this.departmentTab = new System.Windows.Forms.RibbonTab();
            this.helpTab = new System.Windows.Forms.RibbonTab();
            this.Help = new System.Windows.Forms.RibbonPanel();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.Open = new System.Windows.Forms.RibbonButton();
            this.New = new System.Windows.Forms.RibbonButton();
            this.settingsButton = new System.Windows.Forms.RibbonButton();
            this.About_Button = new System.Windows.Forms.RibbonButton();
            this.userManualButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Panels.Add(this.homePanel);
            this.MainTab.Text = "Main";
            // 
            // homePanel
            // 
            this.homePanel.Items.Add(this.Open);
            this.homePanel.Items.Add(this.New);
            this.homePanel.Items.Add(this.settingsButton);
            this.homePanel.Text = "Home";
            // 
            // timetableTab
            // 
            this.timetableTab.Text = "Timetable";
            // 
            // lecturersTab
            // 
            this.lecturersTab.Text = "Lecturers";
            // 
            // buildingsTab
            // 
            this.buildingsTab.Text = "Buildings";
            // 
            // departmentTab
            // 
            this.departmentTab.Text = "Department";
            // 
            // helpTab
            // 
            this.helpTab.Panels.Add(this.Help);
            this.helpTab.Text = "Help";
            // 
            // Help
            // 
            this.Help.Items.Add(this.About_Button);
            this.Help.Items.Add(this.userManualButton);
            this.Help.Text = "Help";
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Enabled = false;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = global::TimetablePackage.Properties.Resources.flood_it;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonVisible = false;
            this.ribbon1.Size = new System.Drawing.Size(1008, 128);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.MainTab);
            this.ribbon1.Tabs.Add(this.timetableTab);
            this.ribbon1.Tabs.Add(this.lecturersTab);
            this.ribbon1.Tabs.Add(this.buildingsTab);
            this.ribbon1.Tabs.Add(this.departmentTab);
            this.ribbon1.Tabs.Add(this.helpTab);
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "RibbonControl";
            // 
            // Open
            // 
            this.Open.Image = global::TimetablePackage.Properties.Resources.open_folder;
            this.Open.MaximumSize = new System.Drawing.Size(0, 0);
            this.Open.MinimumSize = new System.Drawing.Size(0, 0);
            this.Open.SmallImage = ((System.Drawing.Image)(resources.GetObject("Open.SmallImage")));
            this.Open.Text = "Open";
            // 
            // New
            // 
            this.New.Image = global::TimetablePackage.Properties.Resources.document_empty;
            this.New.MaximumSize = new System.Drawing.Size(0, 0);
            this.New.MinimumSize = new System.Drawing.Size(0, 0);
            this.New.SmallImage = ((System.Drawing.Image)(resources.GetObject("New.SmallImage")));
            this.New.Text = "New";
            // 
            // settingsButton
            // 
            this.settingsButton.Image = global::TimetablePackage.Properties.Resources.setting_tools;
            this.settingsButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.settingsButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.settingsButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.SmallImage")));
            this.settingsButton.Text = "Settings";
            // 
            // About_Button
            // 
            this.About_Button.Image = global::TimetablePackage.Properties.Resources.information;
            this.About_Button.MaximumSize = new System.Drawing.Size(0, 0);
            this.About_Button.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.About_Button.MinimumSize = new System.Drawing.Size(0, 0);
            this.About_Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("About_Button.SmallImage")));
            this.About_Button.Text = "About";
            this.About_Button.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // userManualButton
            // 
            this.userManualButton.Image = global::TimetablePackage.Properties.Resources.book_picture;
            this.userManualButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.userManualButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.userManualButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.userManualButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.userManualButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("userManualButton.SmallImage")));
            this.userManualButton.Text = "User Manual";
            this.userManualButton.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Text = null;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.ribbon1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab MainTab;
        private System.Windows.Forms.RibbonTab timetableTab;
        private System.Windows.Forms.RibbonTab buildingsTab;
        private System.Windows.Forms.RibbonTab departmentTab;
        private System.Windows.Forms.RibbonTab helpTab;
        private System.Windows.Forms.RibbonPanel Help;
        private System.Windows.Forms.RibbonPanel homePanel;
        private System.Windows.Forms.RibbonButton About_Button;
        private System.Windows.Forms.RibbonButton userManualButton;
        private System.Windows.Forms.RibbonButton Open;
        private System.Windows.Forms.RibbonButton New;
        private System.Windows.Forms.RibbonButton settingsButton;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonTab lecturersTab;

    }
}