using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Home
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void stbutton_Click(object sender, EventArgs e)
        {
            student student = new student();
            student.Show();
            this.Hide();

        }

        private void crbutton_Click(object sender, EventArgs e)
        {
            course course = new course();
            course.Show();
            this.Hide();

        }

        private void Enrolbut_Click(object sender, EventArgs e)
        {
            enrollment enrollment = new enrollment();   
            enrollment.Show();
            this.Hide();
        }

        private void attbuttom_Click(object sender, EventArgs e)
        {
            attendance attendance = new attendance();
            attendance.Show();
            this.Hide();
        }
    }
}
