using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(TextBox1.Text);
            float num2 = Convert.ToSingle(TextBox2.Text);
            float Result = 0;

            Result = num1 + num2;

            Label1.Text = "Result: " +  Result.ToString();
            
        }
    }
}