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

namespace Student_details_with_ADO.NET_and_class
{
    public partial class Form1 : Form
    {
        class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public string Gender { get; set; }
            public string City { get; set; }
            public string Hobbies { get; set; }
            public string DOB { get; set; }

            public Student(int StudentID, string StudentName, string Gender, string City, string Hobbies, string DOB)
            {
                this.StudentID = StudentID;
                this.StudentName = StudentName;
                this.Gender = Gender;
                this.City = City;
                this.Hobbies = Hobbies;
                this.DOB = DOB;
            }

        }

        class StudentsInfo
        {
            string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; database = ADO.NET ";

            public string InsertData(int StudentID, string StudentName, string Gender, string City, string Hobbies, string DOB)
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {

                    conn.Open();

                    string Query = "Insert into StudentDetails Values (@StudentID, @StudentName, @Gender, @City, @Hobbies, @DOB)";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@StudentName", StudentName);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@City", City);
                        cmd.Parameters.AddWithValue("@Hobbies", Hobbies);
                        cmd.Parameters.AddWithValue("DOB", DOB);

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        return "Record Inserted Successfully";

                    }
                }
            }

            public string UpdateData(int StudentID, string StudentName, string Gender, string City, string Hobbies, string DOB)
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string Query = "Update StudentDetails Set StudentName = @StudentName , Gender = @Gender, City = @City, Hobbies = @Hobbies, DOB = @DOB where StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentName", StudentName);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@City", City);
                        cmd.Parameters.AddWithValue("@Hobbies", Hobbies);
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        return "Record Updated Successfully";

                    }
                }
            }

            public string DeleteData(int StudentID, string StudentName)
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string Query = "Delete from  StudentDetails where StudentID = @StudentID or StudentName = @StudentName ";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@StudentName", StudentName);

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        return "Record Deleted Successfully";

                    }
                }
            }

            public List<Student> SearchData(int StudentID)
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string Query = "Select * from StudentDetails where StudentID = @StudentID ";

                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);

                        SqlDataReader reader;

                        reader = cmd.ExecuteReader();

                        List<Student> li = new List<Student>();

                        while (reader.Read())
                        {
                            li.Add(new Student(Convert.ToInt32(reader["StudentID"].ToString()), reader["StudentName"].ToString(), reader["Gender"].ToString(), reader["City"].ToString(), reader["Hobbies"].ToString(), reader["DOB"].ToString()));
                        }

                        reader.Close();

                        return li;

                        conn.Close();

                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        string connection = "server = LAPTOP-CNVSH31R\\SQLEXPRESS01; integrated security = true; database = ADO.NET ";

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

        public void Clear()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            btnMale.Checked = false;
            btnFemale.Checked = false;
            txtCity.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            txtDate.Value = DateTime.Now;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtStudentID.Text);
            string Name = txtStudentName.Text;
            string GENDER = null;
            string CITY = txtCity.Text;
            string Hobbies = null;
            string DOB = txtDate.Value.ToShortDateString();

            // gender

            if(btnMale.Checked)
            {
                GENDER = "Male";
            }
            if(btnFemale.Checked)
            {
                GENDER = "Female";
            }

            // hobbies

            if(checkBox1.Checked)
            {
                Hobbies = "Dancing";
            }

            if(checkBox2.Checked)
            {
                if(checkBox1.Checked != null)
                {
                    Hobbies = Hobbies + " Reading";
                }
                else
                {
                    Hobbies = "Reading";
                }
            }

            StudentsInfo stud = new StudentsInfo();

            string Result = stud.InsertData(ID,Name,GENDER,CITY,Hobbies,DOB);

            MessageBox.Show(Result);

            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtStudentID.Text);
            string Name = txtStudentName.Text;
            string GENDER = null;
            string CITY = txtCity.Text;
            string Hobbies = null;
            string DOB = txtDate.Value.ToShortDateString();

            // gender

            if (btnMale.Checked)
            {
                GENDER = "Male";
            }
            if (btnFemale.Checked)
            {
                GENDER = "Female";
            }

            // hobbies

            if (checkBox1.Checked)
            {
                Hobbies = "Dancing";
            }

            if (checkBox2.Checked)
            {
                if (checkBox1.Checked != null)
                {
                    Hobbies = Hobbies + " Reading";
                }
                else
                {
                    Hobbies = "Reading";
                }
            }

            StudentsInfo stud = new StudentsInfo();

            string Result = stud.UpdateData(ID,Name,GENDER,CITY, Hobbies,DOB);

            MessageBox.Show(Result);
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtStudentID.Text);
            string Name = txtStudentName.Text;

            StudentsInfo stud = new StudentsInfo();

            string Result = stud.DeleteData(ID, Name);

            MessageBox.Show(Result);
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Student> li = new List<Student>();
            StudentsInfo stud = new StudentsInfo();
            li = stud.SearchData(Convert.ToInt32(txtStudentID.Text));

            txtStudentName.Text = li[0].StudentName;

            // Gender 

            string Gender = li[0].Gender;

            if(Gender == "Male")
            {
                btnMale.Checked = true;
            }

            if (Gender == "Female")
            {
                btnFemale.Checked = true;
            }

            txtCity.Text = li[0].City;

            // Hobbies 

            string Hobbies = li[0].Hobbies;

            if(Hobbies == "Dancing" && Hobbies == "Reading")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }

            if(Hobbies == "Dancing")
            {
                checkBox1.Checked= true;
            }

            if(Hobbies == "Reading")
            {
                checkBox2.Checked= true;
            }

            // DOB

            txtDate.Text = li[0].DOB;

        }
    }
}
