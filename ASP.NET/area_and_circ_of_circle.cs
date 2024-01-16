using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cal_area_and_circ_od_circle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float Radius = Convert.ToSingle(TextBox1.Text);
            float area = 0;
            float circ = 0;

            circ = Convert.ToSingle(2 * 3.14 * Radius);
            area = Convert.ToSingle(3.14 * (Radius * Radius));


            Label2.Text = "Area of circle: " + area.ToString();
            Label3.Text = "Circumference of circle: " + circ.ToString();

        }
    }
}