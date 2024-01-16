using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cal_total_marks_grade_per_of_stud
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float s1 = Convert.ToSingle(TextBox1.Text);
            float s2 = Convert.ToSingle(TextBox2.Text);
            float s3 = Convert.ToSingle(TextBox3.Text);

            float total = 0;
            float per = 0;
            string Grade = null;

            total = s1 + s2 + s3;
            per = total / 300 * 100;

            // using if else if

            if (per >= 90)
            {
                Grade = "A";
            }
            else if (per >= 75 && per < 90)
            {
                Grade = "B";
            }
            else if (per >= 55 && per < 75)
            {
                Grade = "C";
            }
            else
            {
                Grade = "Fail";
            }

            Label1.Text = "Total: " + total.ToString();
            Label2.Text = "Percentage: " + per.ToString();
            Label3.Text = "Grade: {0} " + Grade.ToString();
        }
    }
}