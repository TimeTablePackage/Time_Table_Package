using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimetablePackage
{
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttpDataSet.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.ttpDataSet.Lecturer);

        }
    }
}
