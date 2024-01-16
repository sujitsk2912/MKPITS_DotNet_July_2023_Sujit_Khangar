using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sample2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(TextBox3.Text);
            float num2 = Convert.ToSingle(TextBox4.Text);
            float Result = 0;

            char op = Convert.ToChar(TextBox5.Text);

            switch (op)
            {
                case '+':
                    Result = num1 + num2;
                    break;

                case '-':
                    Result = num1 - num2;
                    break;
                
                case '*':
                    Result = num1 * num2;
                    break;
                
                case '/':
                    Result = num1 / num2;
                    break;

                default:
                    Response.Write("Invalid Operator");
                    break;
            }

            Label1.Text = "Result: " + Result.ToString();
        }
    }
}