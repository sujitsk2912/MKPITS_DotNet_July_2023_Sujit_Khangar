using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            btndashboard.Focus();
            btndashboard.Select();
        }

        frmstudent student = null;
        frmfaculty faculty = null;
        frmnewlogin login = null;
        frmnewsignup signup = null;
        frmattendance attendance = null;
        frmadmission admission = null;
        frmresults results = null;
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            login = new frmnewlogin();
            login.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            faculty = new frmfaculty();

            if (results != null && attendance != null && student != null && admission != null)
            {
                attendance.Close();
                student.Close();
                admission.Close();
                results.Close();
                results = null;
                attendance = null;
                admission = null;
                student = null;
            }

            faculty.TopLevel = false;
            faculty.Dock = DockStyle.Fill;
            faculty.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(faculty);
            faculty.Show();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            student = new frmstudent();

            if (attendance != null && faculty != null && admission != null && results != null)
           {
               attendance.Close();
               faculty.Close();
               admission.Close();
                results.Close();
               results = null;
               attendance = null;
               admission = null;
               faculty = null;
           }

           student.TopLevel = false;
           student.Dock = DockStyle.Fill;
           student.WindowState = FormWindowState.Maximized;
           DashboardPanel.Controls.Add(student);
           student.Show();
        }

        private void btnadmission_Click(object sender, EventArgs e)
        {

        }

        private void btnattendance_Click(object sender, EventArgs e)
        {

            attendance = new frmattendance();

            if (results != null && student != null && faculty != null && admission != null)
            {
                student.Close();
                faculty.Close();
                admission.Close();
                results.Close();
                results = null;
                student = null;
                admission = null;
                faculty = null;
            }

            attendance.TopLevel = false;
            attendance.Dock = DockStyle.Fill;
            attendance.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(attendance);
            attendance.Show();
        }

        private void btnadmission_Click_1(object sender, EventArgs e)
        {
            admission = new frmadmission();

            if (results != null && student != null && faculty != null && attendance != null)
            {
                student.Close();
                faculty.Close();
                attendance.Close();
                results.Close();
                results = null;
                faculty = null;
                attendance = null;
                student  = null;
            }

            admission.TopLevel = false;
            admission.Dock = DockStyle.Fill;
            admission.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(admission);
            admission.Show();

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            results = new frmresults();

            if (attendance != null && student != null && admission != null && faculty != null)
            {
                attendance.Close();
                student.Close();
                admission.Close();
                faculty.Close();
                attendance = null;
                admission = null;
                student = null;
                faculty= null;
            }

            results.TopLevel = false;
            results.Dock = DockStyle.Fill;
            results.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(results);
            results.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
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
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
