using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calender_control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           Label1.Text = Calendar1.SelectedDate.ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text.ToString();
        }
    }
}