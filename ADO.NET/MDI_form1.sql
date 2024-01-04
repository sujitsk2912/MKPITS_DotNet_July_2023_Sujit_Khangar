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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm;

        string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; Database = ADO.NET ";
        SqlConnection conn;
        SqlCommand cmd;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            try
            {
                conn.Open();

                string Query = "Select count(*) from SqlServerLogin where USERNAME = @Username and PASSWORD = @Password";

                cmd = new SqlCommand(Query, conn);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Login Successfull...");

                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();

                    PanelLogin.Visible = false;
                    menuStrip1.Visible = true;

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelLogin.Visible = true;
            menuStrip1.Visible = false;
            frm.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);

            try
            {
                conn.Open();

                string Query = "Insert Into SqlServerLogin Values (@Username, @Password)";
                cmd = new SqlCommand(Query, conn);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Inserted Successfully...");

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                conn.Close();
            }
        }

        private void dataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new Form2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
