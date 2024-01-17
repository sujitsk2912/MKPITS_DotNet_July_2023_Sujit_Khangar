using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wap_to_print_123_12_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            int j = 1;

            StringBuilder sb = new StringBuilder();

            for (i = j; i <= 1; i--)
            {
                for(j = 1; j <= i; j++)
                {
                    sb.Append(j + " ");
                }

               sb.Append("<br>");
            }

            Label1.Text = sb.ToString();
        }
    }
}