using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_form
{
    public partial class frmadmission : Form
    {
        public frmadmission()
        {
            InitializeComponent();
            txtuser.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtuser.Text;
            string Email = txtmail.Text;
            string Phone = txtphone.Text;
            string Fees = txtfees.Text;
            string Address = txtaddress.Text;

            if (Name == "" && Email == "" && Phone == "" && Fees == "" && Address == "" && (btnmale.Checked == false && btnfemale.Checked == false))
            {
                MessageBox.Show("Please fill all fields...");
            }
            else if (Name == "")
            {
                MessageBox.Show("Please Enter Name");
                txtuser.Focus();
            }
            else if (Email == "")
            {
                MessageBox.Show("Please Enter Email");
                txtmail.Focus();
            }
            else if (Phone == "")
            {
                MessageBox.Show("Please Enter Phone number");
                txtphone.Focus();
            }
            else if (Fees == "")
            {
                MessageBox.Show("Please Enter Fees");
                txtfees.Focus();
            }
            else if (Address == "")
            {
                MessageBox.Show("Please Enter Address");
                txtaddress.Focus();
            }
            else if (btnmale.Checked == false && btnfemale.Checked == false)
            {
                MessageBox.Show("Please Select Gender");
            }
            else
            {
                MessageBox.Show("Form Submitted Succesfully...");
            }
        }

        private void frmjava_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
