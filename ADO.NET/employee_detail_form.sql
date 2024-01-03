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

namespace CRUD_TABLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtEmployeeID.Select();
        }

        string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; database = ADO.NET ";


        private void btnInsert_Click(object sender, EventArgs e)
        {
            string Designation = txtDesignation.Text;
            string Gender = null;
            string City = txtCity.Text;

            if (txtDesignation.SelectedItem != null)
            {
                Designation = txtDesignation.SelectedItem.ToString();
            }

            if (btnMale.Checked == true)
            {
                Gender = "Male";
            }

            if (btnFemale.Checked == true)
            {
                Gender = "Female";
            }

            if (txtCity.SelectedItem != null)
            {
                City = txtCity.SelectedItem.ToString();
            }

            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                string Query = "Insert into EmployeeDetails values ('" + txtEmployeeID.Text + "','" + txtEmployeeName.Text + "','" + Designation + "','" + txtSalary.Text + "','" + Gender + "','" + City + "')";

                SqlCommand cmd = new SqlCommand(Query,conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully");

                txtEmployeeID.Clear();
                txtEmployeeName.Clear();
                txtSalary.Clear();
                btnMale.Checked = false;
                btnFemale.Checked = false;
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

        private void txtDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Could not Connect to Database", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Designation = txtDesignation.Text;
            string Gender = null;
            string City = txtCity.Text;

            if (txtDesignation.SelectedItem != null)
            {
                Designation = txtDesignation.SelectedItem.ToString();
            }

            if (btnMale.Checked == true)
            {
                Gender = "Male";
            }

            if (btnFemale.Checked == true)
            {
                Gender = "Female";
            }

            if (txtCity.SelectedItem != null)
            {
                City = txtCity.SelectedItem.ToString();
            }

            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                string Query = "update EmployeeDetails set EmployeeName = '" + txtEmployeeName.Text + "' , Designation = '" + Designation + "', Salary = '" + txtSalary.Text + "', Gender = '" + Gender + "', City = '" + City + "' where EmployeeID = '" + txtEmployeeID.Text + "'";

                SqlCommand cmd = new SqlCommand(Query,conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record updated Successfully");

                txtEmployeeID.Clear();
                txtEmployeeName.Clear();
                txtSalary.Clear();
                btnMale.Checked = false;
                btnFemale.Checked = false;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                string Query = "Delete EmployeeDetails where EmployeeID = '" + txtEmployeeID.Text + "'";
                SqlCommand cmd = new SqlCommand(Query,conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully");

                txtEmployeeID.Clear();
                txtEmployeeName.Clear();
                txtSalary.Clear();
                btnMale.Checked = false;
                btnFemale.Checked = false;

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                string Query = "Select * from EmployeeDetails where EmployeeID = '" + txtEmployeeID.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                int flag = 0;

                while (reader.Read())
                {
                    flag = 1;
                    txtEmployeeName.Text = reader["EmployeeName"].ToString();
                    txtDesignation.SelectedItem = reader["Designation"].ToString();
                    txtSalary.Text = reader["Salary"].ToString();

                    if (reader["Gender"].ToString() == "Male")
                    {
                        btnMale.Checked = true;
                    }
                    else if (reader["Gender"].ToString() == "Female")
                    {
                        btnFemale.Checked = true;
                    }

                    txtCity.SelectedItem = reader["City"].ToString();
                }
                
                reader.Close();

                if (flag == 0)
                {
                    MessageBox.Show("Record Not Found");
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
    }
}
