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
using Microsoft.Win32;
using System.Net;

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
            btnsubmit.Enabled = false;
            txtdate.Text = DateTime.Now.ToString();

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
            string Date = txtdate.Text;

            if (txtbatch.Text == "Java")
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            conn.Open();

                            for (int i = 0; i < AttendanceRecordDataGridView.Rows.Count; i++)
                            {
                                string Query = "INSERT INTO AttendanceJavaByDate ([STUDENT ID], NAME, BATCH, PRESENT, ABSENT, LATE, DATE ) VALUES ('" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderID"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderName"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderBatch"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderPresent"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderAbsent"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderLate"].Value + "', '" +
                                    Date + "');";

                                comm.CommandText = Query;
                                comm.ExecuteNonQuery();
                            }
                            MessageBox.Show("Data Uploaded Successfully...");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.ToString());
                    }
                    finally 
                    { 
                        conn.Close();
                    }
                }

            }


            if (txtbatch.Text == "DotNet")
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            conn.Open();

                            for (int i = 0; i < AttendanceRecordDataGridView.Rows.Count; i++)
                            {
                                string Query = "INSERT INTO AttendanceDotNetByDate ([STUDENT ID], NAME, BATCH, PRESENT, ABSENT, LATE, DATE ) VALUES ('" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderID"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderName"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderBatch"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderPresent"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderAbsent"].Value + "', '" +
                                    AttendanceRecordDataGridView.Rows[i].Cells["HeaderLate"].Value + "', '" +
                                    Date + "');";

                                comm.CommandText = Query;
                                comm.ExecuteNonQuery();
                            }
                            MessageBox.Show("Data Uploaded Successfully...");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.ToString());
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

            if (txtbatch.Text == "Java")
            {
                GetDataFromJava();
            }

            if (txtbatch.Text == "DotNet")
            {
               GetDataFromDotNet();
            }

            btnsubmit.Enabled = true;
        }

        private void frmattendance_Activated(object sender, EventArgs e)
        {

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

        private void attendancepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnenter_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnsearchrecord_Click(object sender, EventArgs e)
        {

        }
    }
}
