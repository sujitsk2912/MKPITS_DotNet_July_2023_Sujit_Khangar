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

namespace Disconnect_environment_using_SqlDataAdapter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; Database = ADO.NET ";
       
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;
        SqlCommandBuilder sqlCommandBuilder;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                adapter = new SqlDataAdapter("select * from StudentDetails", conn);

                sqlCommandBuilder = new SqlCommandBuilder(adapter);

                adapter.Fill(ds, "GetData");

                dataGridView1.DataSource = ds.Tables["GetData"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                adapter.Update(ds.Tables["GetData"]);
                MessageBox.Show("Record Updated Successfully...");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
