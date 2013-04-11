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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.homeTabToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripNewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBarMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimetableTab = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.LecturerTab = new System.Windows.Forms.TabPage();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SplitScreenLR = new System.Windows.Forms.SplitContainer();
            this.splitLSideTopBottom = new System.Windows.Forms.SplitContainer();
            this.LecterOptionPanel = new System.Windows.Forms.Panel();
            this.LecturerListPanel = new System.Windows.Forms.Panel();
            this.LecturerNameList = new System.Windows.Forms.DataGridView();
            this.LecturerInfoPanel = new System.Windows.Forms.Panel();
            this.BuildingsTab = new System.Windows.Forms.TabPage();
            this.statusStrip4 = new System.Windows.Forms.StatusStrip();
            this.AddBuildingBtn = new System.Windows.Forms.Button();
            this.HelpTab = new System.Windows.Forms.TabPage();
            this.statusStrip5 = new System.Windows.Forms.StatusStrip();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.supervisorNameLabel = new System.Windows.Forms.Label();
            this.supervisorTitleLabel = new System.Windows.Forms.Label();
            this.developersTitleLabel = new System.Windows.Forms.Label();
            this.developerNamesLabel = new System.Windows.Forms.Label();
            this.versionInfoLabel = new System.Windows.Forms.Label();
            this.licenceInfoLink = new System.Windows.Forms.LinkLabel();
            this.licenceInfo1 = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.licenseInfoLabel = new System.Windows.Forms.Label();
            this.statusStrip6 = new System.Windows.Forms.StatusStrip();
            this.HomeTabLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.MainTabImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Lec_NametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.InitialstextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.homeTabToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.TimetableTab.SuspendLayout();
            this.LecturerTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitScreenLR)).BeginInit();
            this.SplitScreenLR.Panel1.SuspendLayout();
            this.SplitScreenLR.Panel2.SuspendLayout();
            this.SplitScreenLR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLSideTopBottom)).BeginInit();
            this.splitLSideTopBottom.Panel1.SuspendLayout();
            this.splitLSideTopBottom.Panel2.SuspendLayout();
            this.splitLSideTopBottom.SuspendLayout();
            this.LecturerListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerNameList)).BeginInit();
            this.LecturerInfoPanel.SuspendLayout();
            this.BuildingsTab.SuspendLayout();
            this.HelpTab.SuspendLayout();
            this.AboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTabLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "tick.png");
            this.iconImageList.Images.SetKeyName(1, "question.png");
            this.iconImageList.Images.SetKeyName(2, "cross.png");
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.HomeTab);
            this.MainTabControl.Controls.Add(this.TimetableTab);
            this.MainTabControl.Controls.Add(this.LecturerTab);
            this.MainTabControl.Controls.Add(this.BuildingsTab);
            this.MainTabControl.Controls.Add(this.HelpTab);
            this.MainTabControl.Controls.Add(this.AboutTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ImageList = this.MainTabImageList;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1053, 610);
            this.MainTabControl.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.homeTabToolStrip);
            this.HomeTab.Controls.Add(this.statusStrip1);
            this.HomeTab.ImageIndex = 0;
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(1045, 567);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // homeTabToolStrip
            // 
            this.homeTabToolStrip.AutoSize = false;
            this.homeTabToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.homeTabToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.homeTabToolStrip.Location = new System.Drawing.Point(3, 3);
            this.homeTabToolStrip.Name = "homeTabToolStrip";
            this.homeTabToolStrip.Size = new System.Drawing.Size(1039, 55);
            this.homeTabToolStrip.Stretch = true;
            this.homeTabToolStrip.TabIndex = 2;
            this.homeTabToolStrip.Text = "toolStrip1";
            // 
            // toolStripNewButton
            // 
            this.toolStripNewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewButton.Image")));
            this.toolStripNewButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewButton.Name = "toolStripNewButton";
            this.toolStripNewButton.Size = new System.Drawing.Size(36, 52);
            this.toolStripNewButton.Text = "New";
            this.toolStripNewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripNewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripNewButton.ToolTipText = "New";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.Size = new System.Drawing.Size(40, 52);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(53, 52);
            this.toolStripButton2.Text = "Settings";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 52);
            this.toolStripButton3.Text = "Print";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarMessage});
            this.statusStrip1.Location = new System.Drawing.Point(3, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBarMessage
            // 
            this.StatusBarMessage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.StatusBarMessage.Name = "StatusBarMessage";
            this.StatusBarMessage.Size = new System.Drawing.Size(186, 17);
            this.StatusBarMessage.Text = ".:Welcome to Timetable Package:.";
            // 
            // TimetableTab
            // 
            this.TimetableTab.Controls.Add(this.statusStrip2);
            this.TimetableTab.ImageKey = "calendar.png";
            this.TimetableTab.Location = new System.Drawing.Point(4, 39);
            this.TimetableTab.Name = "TimetableTab";
            this.TimetableTab.Size = new System.Drawing.Size(1045, 567);
            this.TimetableTab.TabIndex = 3;
            this.TimetableTab.Text = "Timetable";
            this.TimetableTab.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 545);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1045, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // LecturerTab
            // 
            this.LecturerTab.Controls.Add(this.statusStrip3);
            this.LecturerTab.Controls.Add(this.panel1);
            this.LecturerTab.ImageKey = "group.png";
            this.LecturerTab.Location = new System.Drawing.Point(4, 39);
            this.LecturerTab.Name = "LecturerTab";
            this.LecturerTab.Padding = new System.Windows.Forms.Padding(3);
            this.LecturerTab.Size = new System.Drawing.Size(1045, 567);
            this.LecturerTab.TabIndex = 1;
            this.LecturerTab.Text = "Lecturer";
            this.LecturerTab.UseVisualStyleBackColor = true;
            // 
            // statusStrip3
            // 
            this.statusStrip3.Location = new System.Drawing.Point(3, 542);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip3.TabIndex = 2;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SplitScreenLR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 561);
            this.panel1.TabIndex = 0;
            // 
            // SplitScreenLR
            // 
            this.SplitScreenLR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitScreenLR.Location = new System.Drawing.Point(0, 0);
            this.SplitScreenLR.Name = "SplitScreenLR";
            // 
            // SplitScreenLR.Panel1
            // 
            this.SplitScreenLR.Panel1.Controls.Add(this.splitLSideTopBottom);
            // 
            // SplitScreenLR.Panel2
            // 
            this.SplitScreenLR.Panel2.Controls.Add(this.LecturerInfoPanel);
            this.SplitScreenLR.Size = new System.Drawing.Size(1039, 561);
            this.SplitScreenLR.SplitterDistance = 174;
            this.SplitScreenLR.TabIndex = 1;
            // 
            // splitLSideTopBottom
            // 
            this.splitLSideTopBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLSideTopBottom.Location = new System.Drawing.Point(0, 0);
            this.splitLSideTopBottom.Name = "splitLSideTopBottom";
            this.splitLSideTopBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLSideTopBottom.Panel1
            // 
            this.splitLSideTopBottom.Panel1.Controls.Add(this.LecterOptionPanel);
            // 
            // splitLSideTopBottom.Panel2
            // 
            this.splitLSideTopBottom.Panel2.Controls.Add(this.LecturerListPanel);
            this.splitLSideTopBottom.Size = new System.Drawing.Size(174, 561);
            this.splitLSideTopBottom.SplitterDistance = 89;
            this.splitLSideTopBottom.TabIndex = 0;
            // 
            // LecterOptionPanel
            // 
            this.LecterOptionPanel.BackColor = System.Drawing.Color.LightGray;
            this.LecterOptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LecterOptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecterOptionPanel.Location = new System.Drawing.Point(0, 0);
            this.LecterOptionPanel.Name = "LecterOptionPanel";
            this.LecterOptionPanel.Size = new System.Drawing.Size(174, 89);
            this.LecterOptionPanel.TabIndex = 1;
            // 
            // LecturerListPanel
            // 
            this.LecturerListPanel.AllowDrop = true;
            this.LecturerListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LecturerListPanel.Controls.Add(this.LecturerNameList);
            this.LecturerListPanel.Location = new System.Drawing.Point(0, 0);
            this.LecturerListPanel.Name = "LecturerListPanel";
            this.LecturerListPanel.Size = new System.Drawing.Size(174, 468);
            this.LecturerListPanel.TabIndex = 1;
            // 
            // LecturerNameList
            // 
            this.LecturerNameList.AllowUserToAddRows = false;
            this.LecturerNameList.AllowUserToDeleteRows = false;
            this.LecturerNameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerNameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecturerNameList.Location = new System.Drawing.Point(0, 0);
            this.LecturerNameList.Name = "LecturerNameList";
            this.LecturerNameList.ReadOnly = true;
            this.LecturerNameList.Size = new System.Drawing.Size(174, 468);
            this.LecturerNameList.TabIndex = 0;
            this.LecturerNameList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LecturerNameList_CellContentClick);
            // 
            // LecturerInfoPanel
            // 
            this.LecturerInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LecturerInfoPanel.Controls.Add(this.button2);
            this.LecturerInfoPanel.Controls.Add(this.button1);
            this.LecturerInfoPanel.Controls.Add(this.numericUpDown3);
            this.LecturerInfoPanel.Controls.Add(this.numericUpDown2);
            this.LecturerInfoPanel.Controls.Add(this.numericUpDown1);
            this.LecturerInfoPanel.Controls.Add(this.InitialstextBox);
            this.LecturerInfoPanel.Controls.Add(this.emailtextBox);
            this.LecturerInfoPanel.Controls.Add(this.Lec_NametextBox);
            this.LecturerInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecturerInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.LecturerInfoPanel.Name = "LecturerInfoPanel";
            this.LecturerInfoPanel.Size = new System.Drawing.Size(861, 561);
            this.LecturerInfoPanel.TabIndex = 0;
            // 
            // BuildingsTab
            // 
            this.BuildingsTab.Controls.Add(this.statusStrip4);
            this.BuildingsTab.Controls.Add(this.AddBuildingBtn);
            this.BuildingsTab.ImageKey = "building.png";
            this.BuildingsTab.Location = new System.Drawing.Point(4, 39);
            this.BuildingsTab.Name = "BuildingsTab";
            this.BuildingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BuildingsTab.Size = new System.Drawing.Size(1045, 567);
            this.BuildingsTab.TabIndex = 2;
            this.BuildingsTab.Text = "Buildings";
            this.BuildingsTab.UseVisualStyleBackColor = true;
            // 
            // statusStrip4
            // 
            this.statusStrip4.Location = new System.Drawing.Point(3, 542);
            this.statusStrip4.Name = "statusStrip4";
            this.statusStrip4.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip4.TabIndex = 1;
            this.statusStrip4.Text = "statusStrip4";
            // 
            // AddBuildingBtn
            // 
            this.AddBuildingBtn.Location = new System.Drawing.Point(23, 23);
            this.AddBuildingBtn.Name = "AddBuildingBtn";
            this.AddBuildingBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBuildingBtn.TabIndex = 0;
            this.AddBuildingBtn.Text = "Add";
            this.AddBuildingBtn.UseVisualStyleBackColor = true;
            this.AddBuildingBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // HelpTab
            // 
            this.HelpTab.Controls.Add(this.statusStrip5);
            this.HelpTab.ImageKey = "help.png";
            this.HelpTab.Location = new System.Drawing.Point(4, 39);
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Size = new System.Drawing.Size(1045, 567);
            this.HelpTab.TabIndex = 4;
            this.HelpTab.Text = "Help";
            this.HelpTab.UseVisualStyleBackColor = true;
            // 
            // statusStrip5
            // 
            this.statusStrip5.Location = new System.Drawing.Point(0, 545);
            this.statusStrip5.Name = "statusStrip5";
            this.statusStrip5.Size = new System.Drawing.Size(1045, 22);
            this.statusStrip5.TabIndex = 0;
            this.statusStrip5.Text = "statusStrip5";
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.supervisorNameLabel);
            this.AboutTab.Controls.Add(this.supervisorTitleLabel);
            this.AboutTab.Controls.Add(this.developersTitleLabel);
            this.AboutTab.Controls.Add(this.developerNamesLabel);
            this.AboutTab.Controls.Add(this.versionInfoLabel);
            this.AboutTab.Controls.Add(this.licenceInfoLink);
            this.AboutTab.Controls.Add(this.licenceInfo1);
            this.AboutTab.Controls.Add(this.projectNameLabel);
            this.AboutTab.Controls.Add(this.licenseInfoLabel);
            this.AboutTab.Controls.Add(this.statusStrip6);
            this.AboutTab.Controls.Add(this.HomeTabLogoPictureBox);
            this.AboutTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTab.ImageKey = "information.png";
            this.AboutTab.Location = new System.Drawing.Point(4, 39);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Size = new System.Drawing.Size(1045, 567);
            this.AboutTab.TabIndex = 5;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // supervisorNameLabel
            // 
            this.supervisorNameLabel.AutoSize = true;
            this.supervisorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorNameLabel.Location = new System.Drawing.Point(472, 374);
            this.supervisorNameLabel.Name = "supervisorNameLabel";
            this.supervisorNameLabel.Size = new System.Drawing.Size(102, 24);
            this.supervisorNameLabel.TabIndex = 11;
            this.supervisorNameLabel.Text = "David Kelly";
            // 
            // supervisorTitleLabel
            // 
            this.supervisorTitleLabel.AutoSize = true;
            this.supervisorTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorTitleLabel.ForeColor = System.Drawing.Color.Blue;
            this.supervisorTitleLabel.Location = new System.Drawing.Point(440, 340);
            this.supervisorTitleLabel.Name = "supervisorTitleLabel";
            this.supervisorTitleLabel.Size = new System.Drawing.Size(163, 24);
            this.supervisorTitleLabel.TabIndex = 10;
            this.supervisorTitleLabel.Text = "Project Supervisor";
            // 
            // developersTitleLabel
            // 
            this.developersTitleLabel.AutoSize = true;
            this.developersTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developersTitleLabel.ForeColor = System.Drawing.Color.Blue;
            this.developersTitleLabel.Location = new System.Drawing.Point(440, 249);
            this.developersTitleLabel.Name = "developersTitleLabel";
            this.developersTitleLabel.Size = new System.Drawing.Size(169, 24);
            this.developersTitleLabel.TabIndex = 9;
            this.developersTitleLabel.Text = "Project Developers";
            // 
            // developerNamesLabel
            // 
            this.developerNamesLabel.AutoSize = true;
            this.developerNamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerNamesLabel.Location = new System.Drawing.Point(405, 271);
            this.developerNamesLabel.Name = "developerNamesLabel";
            this.developerNamesLabel.Size = new System.Drawing.Size(233, 48);
            this.developerNamesLabel.TabIndex = 8;
            this.developerNamesLabel.Text = "Ayhan Sahin-C00145773\r\nThomas Nolan-C00146771";
            // 
            // versionInfoLabel
            // 
            this.versionInfoLabel.AutoSize = true;
            this.versionInfoLabel.Location = new System.Drawing.Point(567, 185);
            this.versionInfoLabel.Name = "versionInfoLabel";
            this.versionInfoLabel.Size = new System.Drawing.Size(68, 15);
            this.versionInfoLabel.TabIndex = 7;
            this.versionInfoLabel.Text = "Version 1.0";
            // 
            // licenceInfoLink
            // 
            this.licenceInfoLink.ActiveLinkColor = System.Drawing.Color.Red;
            this.licenceInfoLink.AutoSize = true;
            this.licenceInfoLink.Location = new System.Drawing.Point(392, 478);
            this.licenceInfoLink.Name = "licenceInfoLink";
            this.licenceInfoLink.Size = new System.Drawing.Size(426, 15);
            this.licenceInfoLink.TabIndex = 6;
            this.licenceInfoLink.TabStop = true;
            this.licenceInfoLink.Text = "Creative Commons Attribution-NonCommercial-NoDerivs 3.0 Ireland License.";
            this.licenceInfoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenceInfoLink_LinkClicked);
            // 
            // licenceInfo1
            // 
            this.licenceInfo1.AutoSize = true;
            this.licenceInfo1.Location = new System.Drawing.Point(227, 478);
            this.licenceInfo1.Name = "licenceInfo1";
            this.licenceInfo1.Size = new System.Drawing.Size(168, 15);
            this.licenceInfo1.TabIndex = 4;
            this.licenceInfo1.Text = "This work is licensed under a ";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(387, 137);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(397, 44);
            this.projectNameLabel.TabIndex = 3;
            this.projectNameLabel.Text = "Time Table Package ";
            // 
            // licenseInfoLabel
            // 
            this.licenseInfoLabel.AutoSize = true;
            this.licenseInfoLabel.Location = new System.Drawing.Point(436, 505);
            this.licenseInfoLabel.Name = "licenseInfoLabel";
            this.licenseInfoLabel.Size = new System.Drawing.Size(169, 30);
            this.licenseInfoLabel.TabIndex = 2;
            this.licenseInfoLabel.Text = "           Copyright 2013©\r\nInstitute of Technology Carlow";
            // 
            // statusStrip6
            // 
            this.statusStrip6.Location = new System.Drawing.Point(0, 545);
            this.statusStrip6.Name = "statusStrip6";
            this.statusStrip6.Size = new System.Drawing.Size(1045, 22);
            this.statusStrip6.TabIndex = 0;
            this.statusStrip6.Text = "statusStrip6";
            // 
            // HomeTabLogoPictureBox
            // 
            this.HomeTabLogoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeTabLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.HomeTabLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HomeTabLogoPictureBox.Image")));
            this.HomeTabLogoPictureBox.Location = new System.Drawing.Point(461, 3);
            this.HomeTabLogoPictureBox.Name = "HomeTabLogoPictureBox";
            this.HomeTabLogoPictureBox.Size = new System.Drawing.Size(122, 131);
            this.HomeTabLogoPictureBox.TabIndex = 1;
            this.HomeTabLogoPictureBox.TabStop = false;
            // 
            // MainTabImageList
            // 
            this.MainTabImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainTabImageList.ImageStream")));
            this.MainTabImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainTabImageList.Images.SetKeyName(0, "house.png");
            this.MainTabImageList.Images.SetKeyName(1, "calendar.png");
            this.MainTabImageList.Images.SetKeyName(2, "group.png");
            this.MainTabImageList.Images.SetKeyName(3, "building.png");
            this.MainTabImageList.Images.SetKeyName(4, "help.png");
            this.MainTabImageList.Images.SetKeyName(5, "information.png");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Lec_NametextBox
            // 
            this.Lec_NametextBox.Location = new System.Drawing.Point(92, 56);
            this.Lec_NametextBox.Name = "Lec_NametextBox";
            this.Lec_NametextBox.Size = new System.Drawing.Size(205, 20);
            this.Lec_NametextBox.TabIndex = 0;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(92, 108);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(205, 20);
            this.emailtextBox.TabIndex = 1;
            // 
            // InitialstextBox
            // 
            this.InitialstextBox.Location = new System.Drawing.Point(92, 82);
            this.InitialstextBox.Name = "InitialstextBox";
            this.InitialstextBox.Size = new System.Drawing.Size(205, 20);
            this.InitialstextBox.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(177, 134);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(177, 186);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(177, 160);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 610);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1069, 648);
            this.MinimumSize = new System.Drawing.Size(1069, 648);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timetable Package";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainTabControl.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.homeTabToolStrip.ResumeLayout(false);
            this.homeTabToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TimetableTab.ResumeLayout(false);
            this.TimetableTab.PerformLayout();
            this.LecturerTab.ResumeLayout(false);
            this.LecturerTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.SplitScreenLR.Panel1.ResumeLayout(false);
            this.SplitScreenLR.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitScreenLR)).EndInit();
            this.SplitScreenLR.ResumeLayout(false);
            this.splitLSideTopBottom.Panel1.ResumeLayout(false);
            this.splitLSideTopBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLSideTopBottom)).EndInit();
            this.splitLSideTopBottom.ResumeLayout(false);
            this.LecturerListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LecturerNameList)).EndInit();
            this.LecturerInfoPanel.ResumeLayout(false);
            this.LecturerInfoPanel.PerformLayout();
            this.BuildingsTab.ResumeLayout(false);
            this.BuildingsTab.PerformLayout();
            this.HelpTab.ResumeLayout(false);
            this.HelpTab.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeTabLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iconImageList;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage LecturerTab;
        private System.Windows.Forms.TabPage BuildingsTab;
        private System.Windows.Forms.Button AddBuildingBtn;
        private System.Windows.Forms.ImageList MainTabImageList;
        private System.Windows.Forms.TabPage TimetableTab;
        private System.Windows.Forms.TabPage HelpTab;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarMessage;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.StatusStrip statusStrip4;
        private System.Windows.Forms.StatusStrip statusStrip5;
        private System.Windows.Forms.StatusStrip statusStrip6;
        private System.Windows.Forms.ToolStrip homeTabToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripNewButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer SplitScreenLR;
        private System.Windows.Forms.SplitContainer splitLSideTopBottom;
        private System.Windows.Forms.Panel LecterOptionPanel;
        private System.Windows.Forms.Panel LecturerListPanel;
        private System.Windows.Forms.Panel LecturerInfoPanel;
        private System.Windows.Forms.PictureBox HomeTabLogoPictureBox;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label licenseInfoLabel;
        private System.Windows.Forms.LinkLabel licenceInfoLink;
        private System.Windows.Forms.Label licenceInfo1;
        private System.Windows.Forms.Label versionInfoLabel;
        private System.Windows.Forms.Label developerNamesLabel;
        private System.Windows.Forms.Label developersTitleLabel;
        private System.Windows.Forms.Label supervisorNameLabel;
        private System.Windows.Forms.Label supervisorTitleLabel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView LecturerNameList;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox InitialstextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox Lec_NametextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

