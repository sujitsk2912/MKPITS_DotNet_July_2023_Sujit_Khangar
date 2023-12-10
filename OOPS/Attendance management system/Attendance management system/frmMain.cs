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

        frmstudents students = null;
        frmfaculty faculty = null;
        frmLogin login = null;
        frmSignup signup = null;
        frmattendance attendance = null;
        frmadmission admission = null;
        
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
            Environment.Exit(0);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            faculty = new frmfaculty();

            if (attendance != null && students != null && admission != null)
            {
                attendance.Close();
                students.Close();
                admission.Close();
                attendance = null;
                admission = null;
                students = null;
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
            students = new frmstudents();

            if (attendance != null && faculty != null && admission != null)
           {
               attendance.Close();
               faculty.Close();
               admission.Close();
               attendance = null;
               admission = null;
               faculty = null;
           }

           students.TopLevel = false;
           students.Dock = DockStyle.Fill;
           students.WindowState = FormWindowState.Maximized;
           DashboardPanel.Controls.Add(students);
           students.Show();
        }

        private void btnadmission_Click(object sender, EventArgs e)
        {

        }

        private void btnattendance_Click(object sender, EventArgs e)
        {

            attendance = new frmattendance();

            if (students != null && faculty != null && admission != null)
            {
                students.Close();
                faculty.Close();
                admission.Close();
                students = null;
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

            if (students != null && faculty != null && attendance != null)
            {
                students.Close();
                faculty.Close();
                attendance.Close();
                faculty = null;
                attendance = null;
                students = null;
            }

            admission.TopLevel = false;
            admission.Dock = DockStyle.Fill;
            admission.WindowState = FormWindowState.Maximized;
            DashboardPanel.Controls.Add(admission);
            admission.Show();

        }
    }
}
