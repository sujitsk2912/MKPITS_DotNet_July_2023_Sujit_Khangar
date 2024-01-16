using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sample3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
                float num1 = Convert.ToSingle(TextBox6.Text);
                float num2 = Convert.ToSingle(TextBox7.Text);
                char op = Convert.ToChar(TextBox8.Text);
                float Result = 0;

                if (op == '+')
                    Result = num1 + num2;
                else if (op == '-')
                    Result = num1 - num2;
                else if (op == '*')
                    Result = num1 * num2;
                else if (op == '/')
                    Result = num1 / num2;
                else
                    Response.Write("Invalid Operator");

                Label1.Text = "Result: " + Result.ToString();
        }
    }
}