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

namespace Dicsconnected_Env.CRUD
{
    public partial class Form1 : Form
    {
        string connection = "Server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; database = ADO.NET ";
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        DataSet dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
            txtEmployeeID.Select();
            adapter = new SqlDataAdapter("select * from Employee", connection);
            builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dataSet, "Emp");
        }

        
        private void btnInsert_Click(object sender, EventArgs e)
        {
             adapter = new SqlDataAdapter("select * from Employee", connection);
             builder = new SqlCommandBuilder(adapter);
             DataSet dataSet = new DataSet();
             adapter.Fill(dataSet, "Emp");

            try
            {
                DataRow DR = dataSet.Tables["Emp"].NewRow();

                DR[0] = Convert.ToInt32(txtEmployeeID.Text);
                DR[1] = txtEmployeeName.Text;
                DR[2] = txtDOJ.Value.ToShortDateString();
                DR[3] = Convert.ToInt32(txtAge.Text);
                DR[4] = txtCityComboBox.Text;
                DR[5] = Convert.ToInt32(txtMobile.Text);
                DR[6] = Convert.ToDecimal(txtSalary.Text);

                dataSet.Tables["Emp"].Rows.Add(DR);

                adapter.Update(dataSet.Tables["Emp"]);

                MessageBox.Show("Record Inserted Successfully..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            EmployeeRecorddataGridView.DataSource = dataSet.Tables["Emp"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
           foreach(DataRow DR in dataSet.Tables["Emp"].Rows)
            {
                if (DR[0].ToString() == txtEmployeeID.Text)
                {
                    try
                    {
                        DR[0] = Convert.ToInt32(txtEmployeeID.Text);
                        DR[1] = txtEmployeeName.Text;
                        DR[2] = txtDOJ.Text;
                        DR[3] = Convert.ToInt32(txtAge.Text);
                        DR[4] = txtCityComboBox.Text;
                        DR[5] = Convert.ToInt32(txtMobile.Text);
                        DR[6] = Convert.ToDecimal(txtSalary.Text);

                        adapter.Update(dataSet.Tables["Emp"]);
                        MessageBox.Show("Record Updated Successfull...");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void EmployeeRecorddataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = EmployeeRecorddataGridView[0, e.RowIndex].Value.ToString();
            txtEmployeeName.Text = EmployeeRecorddataGridView[1, e.RowIndex].Value.ToString();
            txtDOJ.Text = EmployeeRecorddataGridView[2, e.RowIndex].Value.ToString();
            txtAge.Text = EmployeeRecorddataGridView[3, e.RowIndex].Value.ToString();
            txtCityComboBox.Text = EmployeeRecorddataGridView[4, e.RowIndex].Value.ToString();
            txtMobile.Text = EmployeeRecorddataGridView[5, e.RowIndex].Value.ToString();
            txtSalary.Text = EmployeeRecorddataGridView[6, e.RowIndex].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataRow DR in dataSet.Tables["Emp"].Rows)
            {
                if (DR[0].ToString() == txtEmployeeID.Text)
                {
                    try
                    {
                        DR.Delete();

                        adapter.Update(dataSet.Tables["Emp"]);
                        dataSet.Tables["Emp"].AcceptChanges();
                        MessageBox.Show("Record Deleted Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }

        }

        private void txtEmployeeIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string EmpID = txtEmployeeIDComboBox.Text;

            SqlConnection conn = new SqlConnection(connection);

            conn.Open();

            try
            {
                string Query = "select * from Employee where EmployeeID = '"+ EmpID +"'";

                SqlCommand cmd = new SqlCommand(Query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtEmployeeID.Text = reader["EmployeeID"].ToString();
                    txtEmployeeName.Text = reader["EmployeeName"].ToString();
                    txtDOJ.Text = reader["DOJ"].ToString();
                    txtAge.Text = reader["Age"].ToString();
                    txtCityComboBox.SelectedItem = reader["City"].ToString();
                    txtMobile.Text = reader["Mobile"].ToString();
                    txtSalary.Text = reader["Salary"].ToString();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEmployeeIDComboBox.DataSource = dataSet.Tables["Emp"];
            txtEmployeeIDComboBox.DisplayMember = "EmployeeID";
        }
    }
}
