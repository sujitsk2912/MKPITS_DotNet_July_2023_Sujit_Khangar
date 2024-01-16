using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sample4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int i = 1;

            StringBuilder sb = new StringBuilder();

            // using while loop

            while (i <= num)
            {
                sb.Append(i + "<br>");
                i++;
            }

            Label1.Text = sb.ToString();

            // using do while loop

            do
            {
                sb.Append(i + "<br>");
                i++;
            }
            while (i <= num);
            {
                Label1.Text = sb.ToString();
            }

            // using for loop

            for (i = 1; i <= num; i++)
            {
                sb.Append(i + "<br>");
            }

            Label1.Text = sb.ToString();

            // using nested for loop 

            for (i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++) 
                {
                    sb.Append(j + " ");
                }
                sb.Append("<br>");
            }

            Label1.Text = sb.ToString();
        }
    }
}