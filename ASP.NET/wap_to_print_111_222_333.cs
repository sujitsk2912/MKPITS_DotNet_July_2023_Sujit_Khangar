using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wap_to_print_111_222_333
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

            for(i = 1; i <= 3; i++)
            {
                for(j = 1; j <= 3; j++)
                {
                    sb.Append(i + " ");
                }
                sb.Append("<br>");
            }
            Label1.Text = sb.ToString();
        }
    }
}