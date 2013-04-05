namespace TimetablePackage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.TimeTableTab = new System.Windows.Forms.TabPage();
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.TimeTableTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.HomeTab);
            this.MainTabControl.Controls.Add(this.TimeTableTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Enabled = false;
            this.MainTabControl.ImageList = this.iconImageList;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1053, 610);
            this.MainTabControl.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(1045, 567);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // TimeTableTab
            // 
            this.TimeTableTab.Controls.Add(this.button1);
            this.TimeTableTab.Location = new System.Drawing.Point(4, 39);
            this.TimeTableTab.Name = "TimeTableTab";
            this.TimeTableTab.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTableTab.Size = new System.Drawing.Size(1045, 567);
            this.TimeTableTab.TabIndex = 1;
            this.TimeTableTab.Text = "Timetable";
            this.TimeTableTab.UseVisualStyleBackColor = true;
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "house.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 610);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Form1";
            this.Text = "Timetable Package";
            this.MainTabControl.ResumeLayout(false);
            this.TimeTableTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage TimeTableTab;
        private System.Windows.Forms.ImageList iconImageList;
        private System.Windows.Forms.Button button1;
    }
}

