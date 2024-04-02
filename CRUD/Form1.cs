using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into student values (@RegisterationNumber, @Name,@Department,@Session,@CGPA,@Address)", con);
            cmd.Parameters.AddWithValue("@RegisterationNumber", registerationtxtBox.Text);
            cmd.Parameters.AddWithValue("@Name", nametxtBox.Text);
            cmd.Parameters.AddWithValue("@Department", DepttxtBox.Text);
            cmd.Parameters.AddWithValue("@Session", int.Parse(sessiontxtBox.Text));
            cmd.Parameters.AddWithValue("@CGPA", CGPAtxtBox.Text);
            cmd.Parameters.AddWithValue("@Address", adresstxtBox.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM student WHERE RegisterationNumber=@RegisterationNumber", con);
            cmd.Parameters.AddWithValue("@RegisterationNumber", registerationtxtBox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully deleted");
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE student SET Name=@Name,Department=@Department,Session=@Session,CGPA=@CGPA,Address=@Address WHERE RegisterationNumber=@RegisterationNumber", con);
            cmd.Parameters.AddWithValue("@RegisterationNumber", registerationtxtBox.Text);
            cmd.Parameters.AddWithValue("@Name", nametxtBox.Text);
            cmd.Parameters.AddWithValue("@Department", DepttxtBox.Text);
            cmd.Parameters.AddWithValue("@Session", int.Parse(sessiontxtBox.Text));
            cmd.Parameters.AddWithValue("@CGPA", CGPAtxtBox.Text);
            cmd.Parameters.AddWithValue("@Address", adresstxtBox.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated");
        }
    }
}
