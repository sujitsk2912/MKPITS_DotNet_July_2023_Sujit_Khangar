using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtusername.Select();
            eyebuttonshow.Focus();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsignup fsign = new frmsignup();
            fsign.MdiParent = this;
            fsign.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text.Trim();
            string Password = txtpassword.Text.Trim();

            if (Username == "" && Password == "")
                {
                    MessageBox.Show("Please enter Username and Passwword");
                }
                else if (Username == "")
                {
                    MessageBox.Show("Please enter Username");
                }
                else if (Password == "")
                {
                    MessageBox.Show("Please enter Password");
                }

                else
                {
                    if (Username == "Admin" && Password == "Admin123")
                    {
                        MessageBox.Show("Login Seccesfull...");
                        admissionmenu.Enabled = true;
                        aboutmenu.Enabled = true;
                        arrangeFormsToolStripMenuItem.Enabled = true;   
                        contactmenu.Enabled = true;
                        frm1_LoginPanel.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Invalid Credentials ! ");
                    }
                }
                
        }

        private void registerNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsignup fsign = new frmsignup();
            fsign.MdiParent = this;
            fsign.Show();
            frm1_LoginPanel.Hide();
        }

        private void homemenu_Click(object sender, EventArgs e)
        {
            frm1_LoginPanel.Show();
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void eyebuttonhide_Click(object sender, EventArgs e)
        {
            eyebuttonhide.Visible = true;
            eyebuttonhide.Focus();
            eyebuttonshow.Focus();
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.PasswordChar = '\0';
            eyebuttonhide.Visible = false;
            eyebuttonshow.Visible = true;
            txtpassword.Focus();
        }

        private void eyebuttonshow_Click(object sender, EventArgs e)
        {
            eyebuttonshow.Visible = true;
            eyebuttonshow.Focus();
            eyebuttonhide.Focus();
            txtpassword.UseSystemPasswordChar = false;
            txtpassword.PasswordChar = '\0';
            eyebuttonshow.Visible = false;
            eyebuttonhide.Visible = true;
            txtpassword.Focus();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void admissionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void admissionFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmadmission fadd = new frmadmission();
            fadd.MdiParent = this;
            fadd.Show();
            frm1_LoginPanel.Hide();
        }

        private void contacToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
