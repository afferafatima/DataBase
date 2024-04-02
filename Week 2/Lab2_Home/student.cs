using CRUD_Operations;
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

namespace Lab2_Home
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void StAdd_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Student values (@RegisterationNumber, @Name,@Department,@Session,@Address)", con);
            cmd.Parameters.AddWithValue("@RegisterationNumber", RegSt.Text);
            cmd.Parameters.AddWithValue("@Name", NameSt.Text);
            cmd.Parameters.AddWithValue("@Department", DepSt.Text);
            cmd.Parameters.AddWithValue("@Session", int.Parse(SessionSt.Text));
            cmd.Parameters.AddWithValue("@Address", AddSt.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Added!");
        }

        private void stdel_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (RegistrationNumberExists(RegSt.Text, con))
            {
                // Registration number exists, proceed with deletion
                SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE RegisterationNumber = @RegisterationNumber", con);
                cmd.Parameters.AddWithValue("@RegisterationNumber", RegSt.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
            }
            else
            {
                // Registration number does not exist, show a message or take appropriate action
                MessageBox.Show("Registration number not found. Deletion failed.");
            }
        }

        private void stupdate_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            
            SqlCommand cmd = new SqlCommand("UPDATE Student SET Name = @Name, Department = @Department, Session = @Session, Address = @Address WHERE RegisterationNumber = @RegisterationNumber", con);
            
            cmd.Parameters.AddWithValue("@RegisterationNumber", RegSt.Text);
            cmd.Parameters.AddWithValue("@Name", NameSt.Text);
            cmd.Parameters.AddWithValue("@Department", DepSt.Text);
            cmd.Parameters.AddWithValue("@Session", int.Parse(SessionSt.Text));
            cmd.Parameters.AddWithValue("@Address", AddSt.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated!");
        }

        private void stshow_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private bool RegistrationNumberExists(string registrationNumber, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegisterationNumber = @RegisterationNumber", connection);
            cmd.Parameters.AddWithValue("@RegisterationNumber", registrationNumber);

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
