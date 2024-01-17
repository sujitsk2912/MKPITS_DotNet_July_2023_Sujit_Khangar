using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace User_Registration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;

            DropDownList2.Items.Clear();

            if (DropDownList1.Text == "India")
            {
                DropDownList2.Items.Add("Nagpur");
                DropDownList2.Items.Add("Nagpur");
                DropDownList2.Items.Add("Delhi");
                DropDownList2.Items.Add("Bhandara");
            }
            else if (DropDownList1.Text == "United States")
            {
                DropDownList2.Items.Add("America");
                DropDownList2.Items.Add("Sandiago");
            }
            else if (DropDownList1.Text == "Pakistan")
            {
                DropDownList2.Items.Add("Afganistan");
                DropDownList2.Items.Add("Lahore");
                DropDownList2.Items.Add("Gaziabaad");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Username = TextBox1.Text;
            string Password = TextBox2.Text;
            string Address = TextBox3.Text;

            // gender
            string Gender = null;

            if(RadioButton1.Checked)
            {
                Gender = RadioButton1.Text;
            }
            else if(RadioButton2.Checked)
            {
                Gender = RadioButton2.Text;
            }

            // Hobby 
            string Hobby = null;

            if (CheckBox1.Checked && CheckBox2.Checked)
            {
                Hobby = CheckBox1.Text + " , " + CheckBox2.Text;
            }
            else if (CheckBox1.Checked)
            {
                Hobby = CheckBox1.Text;
            }
            else if (CheckBox2.Checked)
            {
                Hobby = CheckBox2.Text;
            }
            else
            {
                Hobby = " ";
            }

            string Country = DropDownList1.SelectedItem.ToString();
            string City = DropDownList2.SelectedItem.ToString();

            //courses

            string Courses = ListBox1.SelectedValue;

            //courses1

            string Courses1 = null;

            StringBuilder sb = new StringBuilder();

           
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if(li.Selected)
                {
                    sb.Append(Courses1 = li.Text);
                }
                sb.Append(" , ");
            }

            // Output

            Label1.Text = "Username: " + Username + "<br>" ;
            Label2.Text = "Password: " + Password + "<br>" ;
            Label3.Text = "Address: " + Address  + "<br>" ;
            Label4.Text = "Gender: " + Gender + "<br>" ;
            Label5.Text = "Hobby: " + Hobby + "<br>" ;
            Label6.Text = "Country: " + Country + "<br>" ;
            Label7.Text = "City: " + City + "<br>" ;
            Label8.Text = "Courses: " + Courses + "<br>";
            Label9.Text = "Courses: " + sb.ToString() + "<br>";

        }
    }
}