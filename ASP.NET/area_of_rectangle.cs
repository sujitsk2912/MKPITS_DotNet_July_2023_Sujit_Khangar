using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sample5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float length = Convert.ToSingle(TextBox1.Text);
            float breadth = Convert.ToSingle(TextBox2.Text);
            float area = 0;

            area = length * breadth;

            Label1.Text = "Area of Rectangle:   " + area.ToString();
        }
    }
}