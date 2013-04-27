using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DigitalRune.Windows.Docking;
using System.Threading;


namespace TimetablePackage
{
    public partial class Main : Form
    {
        public Main()
        {
            Thread t = new Thread(new ThreadStart(Splashscreen));
            t.Start();
            Thread.Sleep(2500);
            InitializeComponent();
            t.Abort();
        }

        public void Splashscreen()
        {
            Application.Run(new SplashScreen());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timetable  document = new timetable();

            // Show document
            if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
            {
                document.MdiParent = this;
                document.Show();
            }
            else
            {
                document.Show(dockPanel1);
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            about aboutbox = new about();

            aboutbox.Show();
        }

       

        
    }
}
