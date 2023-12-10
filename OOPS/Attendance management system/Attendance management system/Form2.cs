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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Attendance_management_system
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin f1 = new frmLogin();
            f1.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Password = txtpassword.Text;
            string Confirm = txtconfirm.Text;

            successful.Visible = false;
            successicon.Visible = false;

            while (true)
            {
                if (Username == "" && Password == "" && Confirm == "")
                {
                    MessageBox.Show("Please fill all fields");
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
                else if (Confirm == "")
                {
                    MessageBox.Show("Please confirm Password");
                    break;
                }

                if (Confirm != Password)
                {
                    MessageBox.Show("Password doesn't match ! ");
                    break;
                }

                else
                {
                    string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

                    // 2. establishing connection
                    SqlConnection conn = new SqlConnection(ConnectionString);


                    // 3. Open connection
                    conn.Open();

                    // 4. prepare query

                    string Query = "INSERT INTO Attendance_Managment_Login_server (USERNAME, PASSWORD, CONFIRM) VALUES ('" + Username + "','" + Password + "','" + Confirm + "')";

                    // 5. execute query

                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();

                    // 6.close connection
                    conn.Close();


                    // --------------------------------------------
                    successful.Visible = true;
                    successicon.Visible = true;
                    break;
                    //  MessageBox.Show("Sign Up successfull, please Login Now...");
                }
            }
        }
    }
}
