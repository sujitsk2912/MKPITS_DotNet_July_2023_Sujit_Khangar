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

        }

        

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {


        }

        private void frmattendance_Activated(object sender, EventArgs e)
        {
            GetDataFromDatabase();
            txtdate.Text = DateTime.Now.ToString();
        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GetDataFromDatabase()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT * FROM [student data (8A)]";
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
