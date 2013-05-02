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
<<<<<<< HEAD:TimetablePackage/TimetablePackage/LecturerForm.cs
    public partial class LecturerForm : Form
=======
    public partial class Lecturer : DockableForm
>>>>>>> origin/Ayhan123:TimetablePackage/TimetablePackage/Lecturer.cs
    {
        public LecturerForm()
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

        private void addLecturerButton_Click(object sender, EventArgs e)
        {
            Add_Lecturer add_Lecturer = new Add_Lecturer();
            add_Lecturer.Show();
        }
    }
}
