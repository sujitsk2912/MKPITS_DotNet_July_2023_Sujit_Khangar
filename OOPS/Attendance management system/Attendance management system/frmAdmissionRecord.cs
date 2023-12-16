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
    public partial class frmAttendanceRecord : Form
    {
        public frmAttendanceRecord()
        {
            InitializeComponent();
        }

        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            string Date = txtdate.Text;

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            
            if(txtbatch.Text == "DotNet")
            {
                try
                {
                    string Query = "SELECT [STUDENT ID], NAME, BATCH, PRESENT, ABSENT, LATE, DATE FROM AttendanceDotNetByDate WHERE DATE = '" + Date + "' ORDER BY [STUDENT ID], NAME, BATCH, PRESENT, ABSENT, LATE, DATE";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    AttendanceRecordDataGridView1.DataSource = dt;
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

            if(txtbatch.Text == "Java")
            {
                try
                {
                    string Query = "SELECT [STUDENT ID], NAME, BATCH, PRESENT, ABSENT, LATE, DATE FROM AttendanceJavaByDate WHERE DATE = '" + Date + "' ORDER BY [STUDENT ID], NAME, BATCH, PRESENT, ABSENT, LATE, DATE";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    AttendanceRecordDataGridView1.DataSource = dt;
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
           
        }

        private void frmAttendanceRecord_Activated(object sender, EventArgs e)
        {
            txtdate.Text = DateTime.Now.ToString();
        }

        private void AttendanceRecordDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void attendancepanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
