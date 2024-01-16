using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace factorial_of_number
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);

            int fact = 1;

            for(int i = num; i > 0 ; i--)
            {
               fact = fact * i;
            }

            Label1.Text = "Factorial: " +  fact.ToString();
        }
    }
}