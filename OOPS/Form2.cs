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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtnamefrom2.Select();
        }
        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
           // f1.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            

        }

        private void createactbutton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

            }

            else
            {
                MessageBox.Show("Please agree terms and conditions");
            }
        }
    }
}
