using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideBar_Layout
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            txtUsername.Select();
            txtPassword.UseSystemPasswordChar = true;
            eyebuttonshow.Focus();
        }

        private void eyebuttonhide_Click(object sender, EventArgs e)
        {
            eyebuttonhide.Visible = true;
            eyebuttonhide.Focus();
            eyebuttonshow.Focus();
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '\0';
            eyebuttonhide.Visible = false;
            eyebuttonshow.Visible = true;
            txtPassword.Focus();
        }

       

        private void eyebuttonshow_Click_1(object sender, EventArgs e)
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

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void forgetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
