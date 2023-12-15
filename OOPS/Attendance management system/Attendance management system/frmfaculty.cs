using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmfaculty : Form
    {
        public frmfaculty()
        {
            InitializeComponent();
            txtfacultyid.Select();
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

        public void VariableDeclaration()
        {
            int FacultyId = Convert.ToInt32(txtfacultyid.Text);
            string FacultyName = txtname.Text;
            string Batch = txtbatch.Text;
            string Address = txtaddress.Text;
            string Email = txtemail.Text;
            decimal Phone = Convert.ToDecimal(txtphone.Text);

        }
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            string FacultyId = txtfacultyid.Text;
            string FacultyName = txtname.Text;
            string Batch = txtbatch.Text;
            string Address = txtaddress.Text;
            string Email = txtemail.Text;
            string Phone = txtphone.Text;

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "INSERT INTO Faculty_Registration ([FACULTY ID],[FACULTY NAME],BATCH, ADDRESS, EMAIL, PHONE) VALUES ('" + FacultyId + "','" + FacultyName + "','" + Batch + "','" + Address + "','" + Email + "','" + Phone + "')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Submited Successfully");
                GetDataFromDataBase();
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

        private void frmfaculty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sujitdbDataSet2.Faculty_Registration' table. You can move, or remove it, as needed.
            this.faculty_RegistrationTableAdapter.Fill(this.sujitdbDataSet2.Faculty_Registration);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetDataFromDataBase()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT * FROM Faculty_Registration";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                FacultyRecordDataGridView.DataSource = dt;
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

        private void frmfaculty_Activated(object sender, EventArgs e)
        {
            GetDataFromDataBase();

            /*SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT * FROM Faculty_Registration";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                FacultyRecordDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }*/
        }

        private void FacultyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
