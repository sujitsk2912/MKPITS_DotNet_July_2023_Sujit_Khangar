using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

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

        string username = "Admin";
        string password = "Admin123";
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

                // when user enter correct or invalid password

                if (uname == username && pass == password)
                {
                    MessageBox.Show("Login successful...");
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    return;
                }

                else
                {
                    MessageBox.Show("Invalid username or password");
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    return;
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
            //f2.Hide();
        }
    }
}
