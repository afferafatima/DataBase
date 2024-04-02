using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Home
{
    public partial class enrollment : Form
    {
        public enrollment()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();

            if (courseExists(courseNametxtbox.Text, con) && studentExists(RegNotxtbox.Text, con))
            {

                SqlCommand cmd = new SqlCommand("Insert into Enrollments values (@StudentRegNo,@CourseName)", con);
                cmd.Parameters.AddWithValue("@StudentRegNo", RegNotxtbox.Text);
                cmd.Parameters.AddWithValue("@CourseName", courseNametxtbox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added!");
            }
            else
            {
                // Registration number does not exist, show a message or take appropriate action
                MessageBox.Show("Invalid Input.\nFailed!.");
            }
        }
    

        private void delbtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (courseExists(courseNametxtbox.Text, con) && studentExists(RegNotxtbox.Text, con))
            {
                SqlCommand cmd = new SqlCommand("DELETE  FROM Enrollments WHERE RegisterationNumber = @RegisterationNumber", con);
                cmd.Parameters.AddWithValue("@RegisterationNumber", RegNotxtbox.Text);
                cmd.Parameters.AddWithValue("@Course", courseNametxtbox.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Invalid Ianput.\nDeletion failed.");
            }

        }
        private bool courseExists(string coursename, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Course WHERE  Name= @Name", connection);
            cmd.Parameters.AddWithValue("@Name", coursename);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        private bool studentExists(string registerationNumber, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegisterationNumber = @RegisterationNumber", connection);
            cmd.Parameters.AddWithValue("@RegisterationNumber", registerationNumber);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        private bool dataExists(string coursename,string registerationNumber, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Enrollments WHERE  RegisterationNumber= @RegisterationNumber,Course=@Course", connection);
            cmd.Parameters.AddWithValue("@Name", coursename);


            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        private void showbtn_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Enrollments", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }
    }
}
