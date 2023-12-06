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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login_signup
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtnamefrom2.Select();
        }

        
        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            

        }

        private void createactbutton_Click(object sender, EventArgs e)
        {
            string name = txtnamefrom2.Text;
            string email = txtemailform2.Text;
            string pass = txtpassform2.Text;

            while (true)
            {
                // when user not fill the username , email and password
                if (name =="" && pass == "" && email == "")
                {
                    MessageBox.Show("Please Enter Username, Email and Password");
                    break;
                }

               else if (name == "")
                {
                    MessageBox.Show("Please Enter Username");
                    break;
                }

                else if (email == "")
                {
                    MessageBox.Show("Please enter Email");
                    break;
                }

                else if (pass == "")
                {
                    MessageBox.Show("Please enter Password");
                    break;
                }

                // terms and condtions section 

                if (checkBox1.Checked == true)
                {

                    // IMPORTANT COMMANDS FOR DATA UPLOADING ON SQL SERVER 

                    // 1. address of SQL server and database
                    string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

                    // 2. establishing connection
                    SqlConnection conn = new SqlConnection(ConnectionString);


                    // 3. Open connection
                    conn.Open();

                    // 4. prepare query
                 
                    string Query = "INSERT INTO Login_Signup (USERNAME, EMAIL, PASSWORD) VALUES ('" + name + "','" + email + "','" + pass + "')";

                    // 5. execute query

                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();

                    // 6.close connection
                    conn.Close();

                    //------------------------------------------------------------

                    MessageBox.Show("Data saved successfully");
                    break;
                }

                else
                {
                    MessageBox.Show("Please agree terms and conditions");
                    break;

                }

            }
           
        }
    }
}
