using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;
using System.Security.Cryptography;

namespace Attendance_management_system
{
    public partial class frmattendance : Form
    {
        public frmattendance()
        {
            InitializeComponent();

        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";
        private void bunifuButton7_Click(object sender, EventArgs e)
        {

        }

        private void frmattendance_Load(object sender, EventArgs e)
        {
            // Linking Combobox (Faculty Name) with DATABASE

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [FACULTY NAME] FROM Faculty_Registration";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader reader = cmd.ExecuteReader(); ;
                DataTable dt = new DataTable();
                dt.Columns.Add("FACULTY NAME", typeof(string));
                dt.Load(reader);
                txtfacultyname.ValueMember = "FACULTY NAME";
                txtfacultyname.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            string Batch = txtbatch.Text;

            if(Batch == "Java")
            {
                GetDataFromJava();
            }

            if(Batch == "DotNet")
            {
                GetDataFromDotNet();
            }



        }

        private void frmattendance_Activated(object sender, EventArgs e)
        {

            txtdate.Text = DateTime.Now.ToString();

            /* DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
             check.HeaderText = "CheakBox";
             AttendanceRecordDataGridView.Columns.Add(check);*/

        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GetDataFromJava()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [STUDENT ID],FULLNAME,COURSE FROM Admission_Java";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttendanceRecordDataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void GetDataFromDotNet()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [STUDENT ID],FULLNAME,COURSE FROM Admission_DotNet";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttendanceRecordDataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AttendanceRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
