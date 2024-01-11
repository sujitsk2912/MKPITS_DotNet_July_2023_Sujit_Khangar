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

namespace Fendahl_Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtFullName.Select();
        }

        string connection = "Server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; Database = FendahlMT2";
        SqlConnection conn;
        DataSet dataset;
        SqlDataAdapter adapter;


        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Value < DateTime.Today)
            {
                MessageBox.Show("Date should not be less than today's date", "Date time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker.Value = DateTime.Today;
            }
        }

        public enum Nationality { INDIAN, NRI };

        Nationality Nat;

        public void GetProductCategory()
        {
            conn = new SqlConnection(connection);

            try
            {
                adapter = new SqlDataAdapter("Select * from TableProductCategory order by Product_Category_ID ", conn);
                DataSet dataset = new DataSet();
                
                adapter.Fill(dataset, "tableproductcategory");

                comboBoxCategory.DataSource = dataset.Tables["tableproductcategory"];
                comboBoxCategory.DisplayMember = "Product_Type_Name";
                comboBoxCategory.ValueMember = "Product_Category_ID";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void GetProduct()
        {
            if (comboBoxCategory.SelectedValue != null && comboBoxCategory.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                conn = new SqlConnection(connection);

                try
                {
                    adapter = new SqlDataAdapter("Select * from TableProduct where Product_Category_ID = @Product_Category_ID", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Product_Category_ID", comboBoxCategory.SelectedValue);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "tableproduct");

                    comboBoxProduct.DataSource = dataSet.Tables["tableproduct"];
                    comboBoxProduct.DisplayMember = "ProductName";
                    comboBoxProduct.ValueMember = "ProductID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void GetProductPrice()
        {
            if(comboBoxProduct.SelectedValue != null && comboBoxProduct.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                conn = new SqlConnection(connection);
                try
                {
                    adapter = new SqlDataAdapter("Select ProductPrice from TableProduct where ProductID = @ProductID", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProductID", comboBoxProduct.SelectedValue);

                    DataSet dataset = new DataSet();

                    adapter.Fill(dataset, "productprice");

                    foreach(DataRow dr in dataset.Tables["productprice"].Rows)
                    {
                        txtPrice.Text = dr["productprice"].ToString();
                    }
                }

                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Character can allow", "Character Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            txtQuantity.Text = 0.ToString();

            GetProductCategory();
            GetProduct();
            GetProductPrice();
            GetGSTPercent();
            CalculateAmount();
            GetGST();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can allow", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProduct();
            GetGSTPercent();
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductPrice();
            CalculateAmount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text == "")
            {
                MessageBox.Show("FullName Required","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txtPhone.Text == "")
            {
                MessageBox.Show("Phone number Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(btnIndian.Checked)
                {
                    Nat = Nationality.INDIAN;
                }
                else if(btnNRI.Checked)
                {
                    Nat = Nationality.NRI;
                }

                MessageBox.Show("Nationality: " + Nat);

                MessageBox.Show("Data Inserted Successfully");
            }
        }

        public void GetGSTPercent()
        {
            string cat = comboBoxCategory.Text;

            if (comboBoxCategory.SelectedValue != null && comboBoxCategory.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                conn = new SqlConnection(connection);

                try
                {
                    adapter = new SqlDataAdapter("Select * from TableProductGSTDetails where GST_Detail_Name = @GST_Detail_Name", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@GST_Detail_Name", cat);

                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "ProductGST");

                    foreach (DataRow DR in dataSet.Tables["ProductGST"].Rows)
                    {
                        txtCGST_per.Text = DR["CGST"].ToString();
                        txtSGST_per.Text = DR["SGST"].ToString();
                        txtIGST_per.Text = DR["IGST"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void GetGST()
        {
            string cat = comboBoxCategory.Text;

            if (comboBoxCategory.SelectedValue != null && comboBoxCategory.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                conn = new SqlConnection(connection);

                try
                {
                    adapter = new SqlDataAdapter("Select * from TableProductGSTDetails where GST_Detail_Name = @GST_Detail_Name", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@GST_Detail_Name", cat);

                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "ProductGST");

                    foreach (DataRow DR in dataSet.Tables["ProductGST"].Rows)
                    {
                        txtCGST_per.Text = DR["CGST"].ToString();
                        txtSGST_per.Text = DR["SGST"].ToString();
                        txtIGST_per.Text = DR["IGST"].ToString();
                    }

                   float CGST = Convert.ToSingle(txtTotalAmt.Text) / Convert.ToSingle(txtCGST_per.Text);
                   float SGST = Convert.ToSingle(txtTotalAmt.Text) / Convert.ToSingle(txtSGST_per.Text);
                   float IGST = Convert.ToSingle(txtTotalAmt.Text) / Convert.ToSingle(txtIGST_per.Text);

                    txtCGST.Text = CGST.ToString();
                    txtSGST.Text = SGST.ToString();
                    txtIGST.Text = IGST.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        public void CalculateAmount()
        {
            try
            {
                if (txtQuantity.Text == "")
                {
                    float Q = 0.0f;
                    float T = 0.0f;

                    txtTotalAmt.Text = T.ToString();
                }

                else
                {
                    decimal Total = 0;

                   Total = Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtQuantity.Text);

                    txtTotalAmt.Text = Convert.ToDecimal(Total).ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CalculateNetAmount()
        {
            if(btnIndian.Checked)
            {
                Nat = Nationality.INDIAN;
                float IndGST = Convert.ToSingle(txtCGST.Text) + Convert.ToSingle(txtSGST.Text);
                float IndTotal = Convert.ToSingle(txtTotalAmt.Text) + IndGST;

                txtNetAmt.Text = IndTotal.ToString();
            }
            else if(btnNRI.Checked)
            {
                Nat = Nationality.NRI;
                float NriGST = Convert.ToSingle(txtIGST.Text);
                float NriTotal = Convert.ToSingle(txtTotalAmt.Text) + NriGST;

                txtNetAmt.Text = NriTotal.ToString();
            }
        }

        private void txtTotalAmt_TextChanged(object sender, EventArgs e)
        {
            GetGST();
            CalculateNetAmount();
        }

        private void btnIndian_CheckedChanged(object sender, EventArgs e)
        {
            CalculateNetAmount() ;
        }

        private void btnNRI_CheckedChanged(object sender, EventArgs e)
        {
            CalculateNetAmount();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can allow", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
