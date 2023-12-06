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

namespace SideBar_Layout
{
    public partial class frmsignin : Form
    {
        public frmsignin()
        {
            InitializeComponent();
            txtusername.Select();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string name = txtusername.Text;
            string email = txtemail.Text;
            string pass = txtpassword.Text;

            while (true)
            {
                // when user not fill the username , email and password
                if (name == "" && pass == "" && email == "")
                {
                    MessageBox.Show("Please Enter Username, Email and Password");
                    break;
                }

                else if (name == "")
                {
                    MessageBox.Show("Please Enter Username");
                    break;
                }

                else if (email == "")
                {
                    MessageBox.Show("Please enter Email");
                    break;
                }

                else if (pass == "")
                {
                    MessageBox.Show("Please enter Password");
                    break;
                }

                if (checkBox2.Checked == true)
                {
                    MessageBox.Show("Account created successfully");
                    break;
                }

                else
                {
                    MessageBox.Show("Please agree terms and conditions");
                    break;

                }

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
