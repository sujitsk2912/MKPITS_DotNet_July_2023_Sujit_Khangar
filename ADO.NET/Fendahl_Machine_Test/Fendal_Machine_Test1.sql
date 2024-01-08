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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        enum Category { Student, IT_Proffesional }
        enum Gender { Male, Female, Others }

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

        public void Calculate()
        {
            if (btnStudent.Checked)
            {
                txtTotalAmt.Text = "1000";

                float TotalAmt = Convert.ToSingle(txtTotalAmt.Text);

                float TotalFeesPaid = TotalAmt * 0.5f;

                if(Convert.ToSingle(txtFeesPaid.Text) < TotalFeesPaid)
                {
                    MessageBox.Show("Minimum amount should be : " + TotalFeesPaid);
                }    
                else
                {
                    float Total = TotalAmt - Convert.ToSingle(txtFeesPaid.Text);
                    txtBalanceAmt.Text = Total.ToString();
                }
            }

            else if (btnITProfestional.Checked)
            {
                txtTotalAmt.Text = "3000";

                float TotalAmt = Convert.ToSingle(txtTotalAmt.Text);

                float TotalFeesPaid = TotalAmt * 0.8f;

                if (Convert.ToSingle(txtFeesPaid.Text) < TotalFeesPaid)
                {
                    MessageBox.Show("Minimum amount should be : " + TotalFeesPaid);
                }
                else
                {
                    float Total = TotalAmt - Convert.ToSingle(txtFeesPaid.Text);
                    txtBalanceAmt.Text = Total.ToString();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void txtFeesPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text == "")
            {
                MessageBox.Show("Fullname cannot be blank");
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
