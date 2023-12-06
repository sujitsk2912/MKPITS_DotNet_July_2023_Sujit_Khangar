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
using System.Windows.Forms.Design.Behavior;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace login_signup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUsername.Select();
            txtPassword.UseSystemPasswordChar = true;
            eyebuttonshow.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string uname = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            while (true)
            {
                // when user not fill the username and password

                if (uname == "" && pass == "")
                {
                    MessageBox.Show("Please Enter Username and Password");
                    break;
                }

                else if (uname == "")
                {
                    MessageBox.Show("Please enter Username");
                    break;
                }

                else if (pass == "")
                {
                    MessageBox.Show("Please enter Password");
                    break;
                }

                // IMPORTANT COMMANDS FOR DATA READING FROM SQL SERVER 


                // 1. address of SQL server and database
                string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

                // 2. establishing connection
                SqlConnection conn = new SqlConnection(ConnectionString);


                // 3. Open connection
                conn.Open();

                // 4. prepare query

                string Login_Signup = "SELECT * FROM Login_Signup WHERE USERNAME = '"+ txtUsername.Text +"' AND PASSWORD = '"+ txtPassword.Text +"'";

                // 5. execute query

                SqlDataAdapter sda = new SqlDataAdapter(Login_Signup, conn);

                DataTable data = new DataTable();

                sda.Fill(data);

                // 6.close connection
                conn.Close();

                //------------------------------------------------------------


                if (data.Rows.Count > 0)
                {
                     uname = txtUsername.Text.Trim();
                     pass = txtPassword.Text.Trim();

                    MessageBox.Show("Login successful...");
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    break;
                }

                else
                {
                    MessageBox.Show("Invalid username or password");
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    break;
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            eyebuttonshow.Visible = true;
            eyebuttonshow.Focus();
            eyebuttonhide.Focus();
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '\0';
            eyebuttonshow.Visible = false;
            eyebuttonhide.Visible = true;
            txtPassword.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
               
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void eyebuttonhide_Click(object sender, EventArgs e)
        {
            eyebuttonhide.Visible = true;
            eyebuttonhide.Focus();
            eyebuttonshow.Focus();
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '\0';
            eyebuttonhide.Visible= false;
            eyebuttonshow.Visible = true;
            txtPassword.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void forgetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
