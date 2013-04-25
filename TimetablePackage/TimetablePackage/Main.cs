using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DigitalRune.Windows.Docking;

namespace TimetablePackage
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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

       

        
    }
}
