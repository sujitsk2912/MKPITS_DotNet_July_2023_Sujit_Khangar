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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        frmsettings fset = new frmsettings();
        frmabout fabout = new frmabout();
        frmadmin fadm = new frmadmin();
        frmsignin fsin = new frmsignin();
        frmlogin flog = new frmlogin();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebartransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebartransition.Stop();
                   /* panel3.Width = sidebar.Width;
                    btnsetting.Width = sidebar.Width;
                    btnlogin.Width = sidebar.Width;
                    btnadmin.Width = sidebar.Width;
                    btnabout.Width = sidebar.Width;*/
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 230)
                {
                    sidebarExpand = true;
                    sidebartransition.Stop();
                   /* panel3.Width = sidebar.Width;
                    btnsetting.Width = sidebar.Width;
                    btnlogin.Width = sidebar.Width;
                    btnadmin.Width = sidebar.Width;
                    btnabout.Width = sidebar.Width;*/
                }
            }
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            fset.Hide();
            fabout.Hide();
            fsin.Hide();
            flog.Hide();
            fadm.TopLevel = false;
            fadm.TopMost = true;
            fadm.AutoScroll = true;
            this.frmloadpanel.Controls.Add(fadm);
            fadm.Dock = DockStyle.Fill;
            fadm.Show();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            fset.Hide();
            fadm.Hide();
            fsin.Hide();
            flog.Hide();
            fabout.TopLevel = false;
            fabout.TopMost = true;
            fabout.AutoScroll = true;
            this.frmloadpanel.Controls.Add(fabout);
            fabout.Dock = DockStyle.Fill;
            fabout.Show();

        }

        private void frmadminpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fabout.Hide();
            fadm.Hide();
            fsin.Hide();
            flog.Hide();
            fset.TopLevel = false;
            fset.TopMost = true;
            fset.AutoScroll = true;
            this.frmloadpanel.Controls.Add(fset);
            fset.Dock = DockStyle.Fill;
            fset.Show();
        }

        private void btnadmin_Click_1(object sender, EventArgs e)
        {
            fset.Hide();
            fabout.Hide();
            fsin.Hide();
            flog.Hide();
            fadm.TopLevel = false;
            fadm.TopMost = true;
            fadm.AutoScroll = true;
            this.frmloadpanel.Controls.Add(fadm);
            fadm.Dock = DockStyle.Fill;
            fadm.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            fset.Hide();
            fadm.Hide();
            fabout.Hide();
            fsin.Hide();
            flog.TopLevel = false;
            flog.TopMost = true;
            flog.AutoScroll = true;
            this.frmloadpanel.Controls.Add(flog);
            flog.Dock = DockStyle.Fill;
            flog.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fset.Hide();
            fadm.Hide();
            fsin.Hide();
            flog.Hide();
            fabout.TopLevel = false;
            fabout.TopMost = true;
            fabout.AutoScroll = true;
            this.frmloadpanel.Controls.Add(fabout);
            fabout.Dock = DockStyle.Fill;
            fabout.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fabout.Hide();
            fadm.Hide();
            fsin.Hide();
            flog.Hide();
            fset.TopLevel = false;
            fset.TopMost = true;
            fset.AutoScroll = true;
            this.frmloadpanel.Controls.Add(fset);
            fset.Dock = DockStyle.Fill;
            fset.Show();
        }

        private void btncreateact_Click(object sender, EventArgs e)
        {
            fset.Hide();
            fabout.Hide();
            fadm.Hide();
            flog.Hide();
            fsin.TopLevel = false;
            fsin.TopMost = true;
            fsin.AutoScroll = false;
            this.frmloadpanel.Controls.Add(fsin);
            fsin.Dock = DockStyle.Fill;
            fsin.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fset.Hide();
            fabout.Hide();
            fadm.Hide();
            flog.Hide();
            fsin.TopLevel = false;
            fsin.TopMost = true;
            fsin.AutoScroll = true;
            this.frmloadpanel.Controls.Add(fsin);
            fsin.Dock = DockStyle.Fill;
            fsin.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fset.Hide();
            fadm.Hide();
            fabout.Hide();
            fsin.Hide();
            flog.TopLevel = false;
            flog.TopMost = true;
            flog.AutoScroll = true;
            this.frmloadpanel.Controls.Add(flog);
            flog.Dock = DockStyle.Fill;
            flog.Show();
        }
    }
}
