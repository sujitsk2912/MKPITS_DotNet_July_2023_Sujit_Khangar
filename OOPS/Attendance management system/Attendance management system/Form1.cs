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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtusername.Select();
            
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignup f2 = new frmSignup();
            f2.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Password = txtpassword.Text;
            erroricon.Visible = false;
            errormsg.Visible = false;

            while (true)
            {
                if (Username == "" && Password == "")
                {
                    MessageBox.Show("Please enter Username & Password");
                    break;
                }
                else if (Username == "")
                {
                    MessageBox.Show("Please enter Username");
                    break;
                }
                else if (Password == "")
                {
                    MessageBox.Show("Please enter Password");
                    break;
                }
                else
                {
                    // 1. address of SQL server and database
                    string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

                    // 2. establishing connection
                    SqlConnection conn = new SqlConnection(ConnectionString);


                    // 3. Open connection
                    conn.Open();

                    // 4. prepare query

                    string Attendance_Managment_Login_server = "SELECT * FROM Attendance_Managment_Login_server WHERE USERNAME = '" + txtusername.Text + "' AND PASSWORD = '" + txtpassword.Text + "'";

                    // 5. execute query

                    SqlDataAdapter sda = new SqlDataAdapter(Attendance_Managment_Login_server, conn);

                    DataTable data = new DataTable();

                    sda.Fill(data);

                    // 6.close connection
                    conn.Close();

                    if (data.Rows.Count > 0)
                    {
                        Username = txtusername.Text.Trim();
                        Password = txtpassword.Text.Trim();

                        MessageBox.Show("Login successful...");
                        frmMain main = new frmMain();
                        main.Show();
                        this.Hide();
                        MessageBoxButtons ok = MessageBoxButtons.OK;
                        break;

                    }

                    else
                    {
                        erroricon.Visible = true;
                        errormsg.Visible = true;
                        break;
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
