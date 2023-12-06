using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_signup
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void link_backtologin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void forgetButton_Click(object sender, EventArgs e)
        {
            string User = txtUsername.Text;
            string Pass = txtpassword.Text;
            string Confpass = txtconfirmpass.Text;

            if (User == "" || Pass == "" || Confpass == "")
            {
                if (User == "")
                {
                    MessageBox.Show("Please enter email or phone");
                }
                else if (Pass == "")
                {
                    MessageBox.Show("Please enter password");
                }
                else if (Confpass== "")
                {
                    MessageBox.Show("Please confirm password");
                }

                // link with database

            }
            else
            {
                MessageBox.Show("Password changed succesfully...");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
