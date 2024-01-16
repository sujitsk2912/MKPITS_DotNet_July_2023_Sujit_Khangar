using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace employee_salary_and_details_of_employee
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBox1.Text;
            string Designation = DropDownList1.Text;
            float Salary = Convert.ToSingle(TextBox3.Text);
            
            float HRA = 0;
            float DA = 0;
            float TotalSalary = 0;

            // using If, else if

            if (DropDownList1.SelectedValue == "Manager")
            {
                HRA = Salary * 0.45f;
                DA = Salary * 0.35f;
                TotalSalary = HRA + DA + Salary;
            }
            else if (DropDownList1.SelectedValue == "Peon")
            {
                HRA = Salary * 0.25f;
                DA = Salary * 0.15f;
                TotalSalary = HRA + DA + Salary;
            }

            // using case statement

            switch (Designation)
            {
                case "Manager":
                    HRA = Salary * 0.45f;
                    DA = Salary * 0.35f;
                    TotalSalary = HRA + DA + Salary;
                    break;

                case "Peon":
                    HRA = Salary * 0.25f;
                    DA = Salary * 0.15f;
                    TotalSalary = HRA + DA + Salary;
                    break;
            }

            Label1.Text = "HRA: " + HRA.ToString();
            Label2.Text = "DA: " + DA.ToString();
            Label3.Text = "Total Salary: " + TotalSalary.ToString();
        }
    }
}