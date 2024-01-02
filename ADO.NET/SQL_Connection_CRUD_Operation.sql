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

namespace ADO_Login_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            // creating a connection string
            string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; database = ADO.NET ";

            //using sqlconnection class connect server to database
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                string Query = "Insert Into LoginData Values ('" + txtUsername.Text + "','" + txtPassword.Text + "')";

                SqlCommand cmd = new SqlCommand(Query,conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Inserted Successfully");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
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

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            // creating a connection string
            string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; database = ADO.NET ";

            //using sqlconnection class connect server to database
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(connection);
                conn.Open();
                MessageBox.Show("Connection Established successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not Connect to Database" , ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // creating a connection string
            string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; database = ADO.NET ";

            //using sqlconnection class connect server to database
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn .Open();
                string Query = "Update LoginData Set Password = '" + txtPassword.Text + "' where Username = '" + txtUsername.Text + "'";
                SqlCommand cmd = new SqlCommand (Query,conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // creating a connection string
            string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; database = ADO.NET ";

            //using sqlconnection class connect server to database
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                string Query = "Delete from LoginData where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Deleted Successfully");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // creating a connection string
            string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; database = ADO.NET ";

            //using sqlconnection class connect server to database
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                string Query = "Select * from LoginData where Username = '" + txtUsername.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                int flag = 0;
                while (reader.Read())
                {
                    flag = 1;
                    txtPassword.Text = reader["Password"].ToString();
                }
                reader.Close();

                if(flag == 0)
                {
                    MessageBox.Show("Record Not Found");
                }
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
}
