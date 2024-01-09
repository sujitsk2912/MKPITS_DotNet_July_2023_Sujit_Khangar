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

namespace Fendal_Machine_Test1
{
    public partial class Form1 : Form
    {
        string connection = "Server = LAPTOP-CNVSH31R\\SQLEXPRESS01; Integrated Security = true; Database = CourseRegistration";

        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet dataSet;

        public Form1()
        {
            InitializeComponent();
        }

        public enum Category { Student, IT_Proffesional }
        public enum Gender { Male, Female, Others }

        Category c;
        Gender g;

        private void Form1_Load(object sender, EventArgs e)
        {
            GetNation();
            GetState();
            GetCity();

            if (btnStudent.Checked)
            {
                txtTotalAmt.Text = "1000";
                txtFeesPaid.Text = "0";
                txtBalanceAmt.Text = "0";
            }
            else if (btnITProfestional.Checked)
            {
                txtTotalAmt.Text = "3000";
                txtFeesPaid.Text = "0";
                txtBalanceAmt.Text = "0";
            }

            dateTimePicker.Text = DateTime.Now.ToString();
        }

        float TotalFeesPaid = 0;
        float BalanceAmt = 0;

        public void Calculate()
        {
            if (btnStudent.Checked)
            {
                txtTotalAmt.Text = "1000";

                float TotalAmt = Convert.ToSingle(txtTotalAmt.Text);

                 TotalFeesPaid = TotalAmt * 0.5f;

                if(Convert.ToSingle(txtFeesPaid.Text) < TotalFeesPaid)
                {
                    MessageBox.Show("Minimum amount should be : " + TotalFeesPaid);
                    txtBalanceAmt.Text = "0";
                }    
                else
                {
                     BalanceAmt = TotalAmt - Convert.ToSingle(txtFeesPaid.Text);
                     txtBalanceAmt.Text = BalanceAmt.ToString();
                }
            }

            else if (btnITProfestional.Checked)
            {
                txtTotalAmt.Text = "3000";

                float TotalAmt = Convert.ToSingle(txtTotalAmt.Text);

                 TotalFeesPaid = TotalAmt * 0.8f;

                if (Convert.ToSingle(txtFeesPaid.Text) < TotalFeesPaid)
                {
                    MessageBox.Show("Minimum amount should be : " + TotalFeesPaid);
                    txtBalanceAmt.Text = "0";
                }
                else
                {
                     BalanceAmt = TotalAmt - Convert.ToSingle(txtFeesPaid.Text);
                     txtBalanceAmt.Text = BalanceAmt.ToString();
                }
            }
        }
        public void GetNation()
        {
            try
            {
                conn = new SqlConnection(connection);
                adapter = new SqlDataAdapter("Select * from TableNation Order by NationID", conn);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "tablenation");

                comboBoxNation.DataSource = dataSet.Tables["tablenation"];
                comboBoxNation.DisplayMember = "NationName";
                comboBoxNation.ValueMember = "NationID";

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetState()
        {
            if (comboBoxNation.SelectedValue != null && comboBoxNation.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                try
                {
                    adapter = new SqlDataAdapter("SELECT * FROM TableState WHERE NationID = @NationID", conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@NationID", comboBoxNation.SelectedValue);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "tablestate");

                    comboBoxState.DataSource = dataSet.Tables["tablestate"];
                    comboBoxState.DisplayMember = "StateName";
                    comboBoxState.ValueMember = "StateID";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void GetCity()
        {
            if (comboBoxState.SelectedValue != null && comboBoxState.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                try
                {
                    adapter = new SqlDataAdapter("SELECT * FROM TableCity WHERE StateID = @StateID", conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@StateID", comboBoxState.SelectedValue);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "tablecity");

                    comboBoxCity.DataSource = dataSet.Tables["tablecity"];
                    comboBoxCity.DisplayMember = "CityName";
                    comboBoxCity.ValueMember = "CityID";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void comboBoxNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetState();
        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
           GetCity();
        }

        private void btnStudent_CheckedChanged(object sender, EventArgs e)
        {
            ButtonStudent();
        }

        public void ButtonStudent()
        {
            if (btnStudent.Checked)
            {
                txtTotalAmt.Text = "1000";
                txtFeesPaid.Text = "0";
                txtBalanceAmt.Text = "0";
            }
        }

        public void ButtonITProffesional()
        {
            if (btnITProfestional.Checked)
            {
                txtTotalAmt.Text = "3000";
                txtFeesPaid.Text = "0";
                txtBalanceAmt.Text = "0";
            }
        }
        private void btnITProfestional_CheckedChanged(object sender, EventArgs e)
        {
            ButtonITProffesional();
        }

        private void txtFeesPaid_Leave(object sender, EventArgs e)
        {
            Calculate();
        }

        public void InsertCourseRegDetails(Category cat, Gender gen)
        {
           
            conn = new SqlConnection(connection);

            try 
            {
                conn.Open();
                string Query = "Insert into TableCourseRegDetail values (@CategoryInd, @FullName, @GenderInd)";
                SqlCommand cmd = new SqlCommand(Query,conn);
                cmd.Parameters.AddWithValue("@CategoryInd", Convert.ToInt32(cat));
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@GenderInd", Convert.ToInt32(gen));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Details Inserted");
                InsertRegAddress();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close(); 
            }


        }
        public void InsertRegAddress()
        {
            conn = new SqlConnection (connection);

            try
            {
                conn.Open();
                string Query1 = "Select Max(CourseregID) from TableCourseRegDetail";
                SqlCommand cmd1 = new SqlCommand(Query1,conn);

                int MaxCourseRegID = Convert.ToInt32(cmd1.ExecuteScalar());
                
                string Query2 = "Insert into TableRegAddress values (@CourseregID, @NationID, @StateID, @CityID) ";
                SqlCommand cmd2 = new SqlCommand(Query2,conn);
                cmd2.Parameters.Add("@CourseregID",SqlDbType.Int).Value = MaxCourseRegID;
                cmd2.Parameters.Add("@NationID", SqlDbType.Int).Value = comboBoxNation.SelectedValue;
                cmd2.Parameters.Add("@StateID", SqlDbType.Int).Value = comboBoxState.SelectedValue;
                cmd2.Parameters.Add("@CityID", SqlDbType.Int).Value = comboBoxCity.SelectedValue;
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Register Details Inserted");
                InsertFeeDetails();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
        public void InsertFeeDetails()
        {

            conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                string Query1 = "Select Max(CourseRegID) from TableCourseRegDetail";
                SqlCommand cmd1 = new SqlCommand(Query1,conn);

                int MaxCourseRegID = Convert.ToInt32(cmd1.ExecuteScalar());

                string Query2 = "Insert into TableFeeDetail values (@CourseRegID, @TotalAmount, @MinPer, @PaidAmount, @BalAmount, @PaidDate)";
                SqlCommand cmd2 = new SqlCommand(Query2,conn);
                cmd2.Parameters.Add("@CourseRegID",SqlDbType.Int).Value = MaxCourseRegID;
                cmd2.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = txtTotalAmt.Text;
                cmd2.Parameters.Add("@MinPer", SqlDbType.Decimal).Value = TotalFeesPaid;
                cmd2.Parameters.Add("@PaidAmount", SqlDbType.Decimal).Value = txtFeesPaid.Text;
                cmd2.Parameters.Add("@BalAmount", SqlDbType.Decimal).Value = txtBalanceAmt.Text;
                cmd2.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker.Value;
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Fees Details Inserted");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // DateTime

            DateTime selectDate = dateTimePicker.Value;

            if( selectDate < DateTime.Today)
            {
                MessageBox.Show("Please select a payment date that is on or after today's date.","DateTime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //FullName not Blank

            else if(txtFullName.Text == "")
            {
                MessageBox.Show("Fullname can'not be blank");
            }

            else
            {
                // Category

                if(btnStudent.Checked)
                {
                    c = Category.Student;
                }
                else if(btnITProfestional.Checked)
                {
                    c = Category.IT_Proffesional;
                }
                MessageBox.Show("Category: " + c.ToString());

                // Gender

                if(btnMale.Checked)
                {
                    g = Gender.Male;
                }
                else if(btnFemale.Checked)
                {
                    g = Gender.Female;
                }
                else if(btnOthers.Checked)
                {
                    g = Gender.Others;
                }
                MessageBox.Show("Gender: " +  g.ToString());

                InsertCourseRegDetails(c, g);

                MessageBox.Show("Data Inserted Successfully..");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStudent.Select();
            btnMale.Select();
            txtFullName.Clear();

            if(btnStudent.Checked)
            {
                ButtonStudent();
            }
            else if( btnITProfestional.Checked)
            {
                ButtonITProffesional();
            }

            dateTimePicker.Value = DateTime.Now;
        }
    }
}
