﻿using System;
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

namespace Attendance_management_system
{
    public partial class frmadmission : Form
    {
        public frmadmission()
        {
            InitializeComponent();
            txtresgister.Select();
        }
        string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            // VARIABLE DECLARATION ..................

            string Register = txtresgister.Text;
            string StudentId = txtstudentid.Text;
            string Name = txtname.Text;
            string Phone = txtphone.Text;
            string Parent = txtparent.Text;
            string Address = txtaddress.Text;
            string DOB = txtDOB.Text;
            string Gender = null;
            string DOA = txtDOA.Text;
            string Course = txtcourse.Text;
            string Fees = txtfees.Text;
            string Duration = txtduration.Text;

            if (Register == "" || StudentId == "" || Name == "" || Phone == "" || Parent == "" || Address == "" || Fees == "" || (btnMale.Checked == false && btnfemale.Checked == false))
            {
                MessageBox.Show("Please fill all fields");
            }

            else
            {
                if (btnMale.Checked)
                {
                    Gender = "Male";
                }
                else if (btnfemale.Checked)
                {
                    Gender = "Female";
                }

                //----------------------------------------------

                //  CONNCTING TO SQL DATABASE----------------------


                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                if (Course == "Java")
                {
                    try
                    {
                        string Query = "INSERT INTO Admission_Java ([REG NO.],[STUDENT ID], FULLNAME, PHONE, [PARENTS PHONE], ADDRESS, DOB, GENDER, [ADMISSION DATE], COURSE, FEES, DURATION ) VALUES ('" + Register + "','" + StudentId + "','" + Name + "','" + Phone + "','" + Parent + "','" + Address + "','" + DOB + "','" + Gender + "','" + DOA + "','" + Course + "','" + Fees + "','" + Duration + "')";
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Submited Successfully");
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


                if (Course == "DotNet")
                {
                    try
                    {
                        string Query = "INSERT INTO Admission_DotNet ([REG NO.],[STUDENT ID], FULLNAME, PHONE, [PARENTS PHONE], ADDRESS, DOB, GENDER, [ADMISSION DATE], COURSE, FEES, DURATION ) VALUES ('" + Register + "','" + StudentId + "','" + Name + "','" + Phone + "','" + Parent + "','" + Address + "','" + DOB + "','" + Gender + "','" + DOA + "','" + Course + "','" + Fees + "','" + Duration + "')";
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        conn.Close();
                        MessageBox.Show("Data Submited Successfully");
                    }
                }

                //---------------------------------------------------

                /* txtresgister.Clear();
                 txtstudentid.Clear();
                 txtname.Clear();
                 txtphone.Clear();
                 txtparent.Clear();
                 txtaddress.Clear();
                 txtDOB.Text = DateTime.Now.ToString();
                 txtDOA.Text = DateTime.Now.ToString();
                 btnMale.Checked = false;
                 btnfemale.Checked = false;
                 txtcourse.ResetText();
                 txtfees.Clear();
                 txtduration.ResetText();
                 txtresgister.Focus();*/
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            frminvoice invoice = new frminvoice();

            invoice.Reciept = txtresgister.Text;
            invoice.StudentId= txtstudentid.Text;
            invoice.Name = txtname.Text;
            invoice.Course = txtcourse.Text;
            invoice.Phone = txtphone.Text;
            invoice.Address = txtaddress.Text;
            invoice.Date = txtDOA.Text;
            invoice.Fees = txtfees.Text;
            invoice.ShowDialog();

        }

        private void frmadmission_Activated(object sender, EventArgs e)
        {
            txtDOB.Text = DateTime.Now.ToString();
            txtDOA.Text = DateTime.Now.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GetDataFromJava()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [STUDENT ID],FULLNAME,COURSE FROM Admission_Java";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
              //  AttendanceRecordDataGridView.DataSource = dt;

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

        private void GetDataFromDotNet()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                string Query = "SELECT [STUDENT ID],FULLNAME,COURSE FROM Admission_DotNet";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                //AttendanceRecordDataGridView.DataSource = dt;

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

    }
}
