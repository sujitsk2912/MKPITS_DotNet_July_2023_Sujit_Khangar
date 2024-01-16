using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace number_is_prime_or_not
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int cnt = 2;
            int flag = 0;

            while(cnt < num)
            {
                if(num % cnt == 0)
                {
                    flag = 1;
                    break;
                }
                cnt++;
            }
            if(flag == 0)
            {
                Label1.Text = "Result: Prime";
            }
            else
            {
                Label1.Text = "Result: Not Prime";
            }
        }
    }
}