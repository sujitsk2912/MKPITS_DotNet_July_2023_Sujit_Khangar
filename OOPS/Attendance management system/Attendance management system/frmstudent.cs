using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system
{
    public partial class frmstudent : Form
    {
        public frmstudent()
        {
            InitializeComponent();
          //  txtstudentid.Select();
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

        private void btnenter_Click(object sender, EventArgs e)
        {
            
        }

        private void GetStudentsRecord()
        {
            // GetStudentsRecord method is Isert Data into tables on the click of Submit button
            // 
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from [student data (8A)]", conn);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            StudentRecordDataGridView.DataSource = dt;
        }

        private void StudentRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentRecordDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnenter_Click_1(object sender, EventArgs e)
        {
           
        }

        private void attendancepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnenter_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btnenter_Click_3(object sender, EventArgs e)
        {
            string StudentID = txtstudentid.Text;
            string Fullname = txtfullname.Text;
            string Lastname = txtfullname.Text;
            string Class = txtclass.Text;
            string Section = txtsection.Text;

            // Create a connection for Uploading the data into SQL data base

            string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string Query = "INSERT INTO [student data (8A)] ([STUDENT ID], NAME, CLASS, SECTION) VALUES ('" + StudentID + "','" + Fullname + "','" + Lastname + "','" + Class + "', '" + Section + "')";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Student Data Uploaded");

            // this commands clear the all text boxes after data uploaded......

            txtfullname.Clear();
            txtstudentid.Clear();
            txtfullname.Clear();
            txtfullname.Focus();

            GetStudentsRecord(); // call this function to show data into datagridview instantly........

        }
    }
}
