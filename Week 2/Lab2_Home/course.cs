using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Home
{
    public partial class course : Form
    {
        public course()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (!codeExists(codetxtbox.Text, con))
            {
                SqlCommand cmd = new SqlCommand("Insert into Course values (@Name,@Code)", con);
                cmd.Parameters.AddWithValue("@Name", Nametxtbox.Text);
                cmd.Parameters.AddWithValue("@Code",codetxtbox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added!");
            }
            else
            {
                // Registration number does not exist, show a message or take appropriate action
                MessageBox.Show("Course already added./n Failed!.");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (codeExists(codetxtbox.Text, con))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Course SET Name = @Name WHERE Code = @Code ", con);

                cmd.Parameters.AddWithValue("@Name", Nametxtbox.Text);
                cmd.Parameters.AddWithValue("@Code", codetxtbox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated!");
            }
            else
            {
                MessageBox.Show("Course doesn't  exists./n Failed!.");
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (codeExists(codetxtbox.Text, con))
            {
                // Registration number exists, proceed with deletion
                SqlCommand cmd = new SqlCommand("DELETE FROM Course WHERE Code = @Code", con);
                cmd.Parameters.AddWithValue("@Code", codetxtbox.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
            }
            else
            {
                // Registration number does not exist, show a message or take appropriate action
                MessageBox.Show("Registration number not found. Deletion failed.");
            }
        }
        private void showbtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Course", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private bool codeExists(string code, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Course WHERE  Code= @Code", connection);
            cmd.Parameters.AddWithValue("@Code", code);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }
    }
}
