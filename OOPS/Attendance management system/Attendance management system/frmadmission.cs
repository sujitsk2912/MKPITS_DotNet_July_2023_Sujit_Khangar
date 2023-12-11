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

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            // VARIABLE DECLARATION ..................

            string Register = txtresgister.Text;
            string Enrollment = txtenrollment.Text;
            string Name = txtname.Text;
            string Phone = txtphone.Text;
            string Parent = txtparent.Text;
            string Address = txtaddress.Text;
            string DOB = txtDOB.Text;
            string Gender = null;
            string DOA = txtDOA.Text;
            string Class = txtclass.Text;
            string Section = txtsection.Text;
            string Category = txtcategory.Text;
            string Fees = txtfees.Text;

            if(btnMale.Checked)
            {
                Gender = "Male";
            }
            else if(btnfemale.Checked)
            {
                Gender = "Female";
            }
           

            //----------------------------------------------

            //  CONNCTING TO SQL DATABASE----------------------

            string ConnectionString = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string Query = "INSERT INTO Student_Admission_data_new ([REG NO.],ENROLLMENT, FULLNAME, PHONE, [PARENTS PHONE], ADDRESS, DOB, GENDER, [ADMISSION DATE], CLASS, SECTION, CATEGORY, FEES ) VALUES ('" + Register + "','"+ Enrollment +"','" + Name + "','" + Phone + "','" + Parent + "','" + Address + "','" + DOB + "','"+ Gender+"','"+DOA+"','"+Class+"','"+Section+"','"+Category+"','"+Fees+"')";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            //---------------------------------------------------

            MessageBox.Show("Data Submited Successfully");

            /*txtresgister.Clear();
            txtenrollment.Clear();
            txtname.Clear();
            txtphone.Clear();
            txtparent.Clear();
            txtaddress.Clear();
            txtDOB.Text = DateTime.Now.ToString();
            txtDOA.Text = DateTime.Now.ToString();
            btnMale.Checked = false;
            btnfemale.Checked = false;
            txtclass.ResetText();
            txtsection.ResetText();
            txtcategory.ResetText();
            txtfees.Clear();
            txtresgister.Focus();*/

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            frminvoice invoice = new frminvoice();

            invoice.Reciept = txtresgister.Text;
            invoice.Enrollment = txtenrollment.Text;
            invoice.Name = txtname.Text;
            invoice.Class = txtclass.Text;
            invoice.Phone = txtphone.Text;
            invoice.Address = txtaddress.Text;
            invoice.Date = txtDOA.Text;
            invoice.Fees = txtfees.Text;
            invoice.ShowDialog();

        }
    }
}