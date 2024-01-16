using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prime_no_from_1_to_20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            int num = 20;
            int cnt = 2;
            int flag = 0;

            StringBuilder sb = new StringBuilder();

            for(i = 1; i <= num; i++)
            {
                cnt = 2;

                while (cnt < i)
                {
                    if (i % cnt == 0)
                    {
                        flag = 1;
                        break;
                    }
                    cnt++;
                }
                if (i == cnt)
                {
                    sb.Append(i + " ");
                }
            }

            Label1.Text = sb.ToString();
        }
    }
}