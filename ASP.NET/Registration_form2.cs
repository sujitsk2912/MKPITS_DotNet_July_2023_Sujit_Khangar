using MaterialDesignThemes.Wpf.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_form2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          if(RadioButton4.Checked)
            {
                float Amt = 1000;
                txtTotalAmt.Text = Amt.ToString();
            }

          else if(RadioButton5.Checked)
            {
                float Amt = 3000;

                txtTotalAmt.Text = Amt.ToString();
            }
           
            
        }

        protected void DropDownListCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCountry();
        }

       public void getCountry()
        {
            string Country = DropDownListCountry.SelectedValue;
            DropDownListState.Items.Clear();
            DropDownListCity.Items.Clear();

            if (DropDownListCountry.Text == "India")
            {
                DropDownListState.Items.Add("Maharashtra");
                DropDownListState.Items.Add("Gujarat");

            }
            else if (DropDownListCountry.Text == "United States")
            {
                DropDownListState.Items.Add("England");
                DropDownListState.Items.Add("New York");
            }
            else if (DropDownListCountry.Text == "Pakistan")
            {
                DropDownListState.Items.Add("Gaziyaabad");
                DropDownListState.Items.Add("Punjap");
            }
            getState();
        }

        public void getState()
        {
            string State = DropDownListState.SelectedValue;
            DropDownListCity.Items.Clear();

            // for india 

            if (DropDownListState.SelectedValue == "Maharashtra")
            {
                DropDownListCity.Items.Add("Nagpur");
                DropDownListCity.Items.Add("Bhandara");
            }
            else if (DropDownListState.Text == "Gujarat")
            {
                DropDownListCity.Items.Add("Gj");
            }

            // for united states

            if (DropDownListState.Text == "England")
            {
                DropDownListCity.Items.Add("En");
            }
            else if (DropDownListState.Text == "New York")
            {
                DropDownListCity.Items.Add("End");
            }

            // for pakistan

            if (DropDownListState.Text == "Gaziyaabad")
            {
                DropDownListCity.Items.Add("Gaziaa");
            }
            else if (DropDownListState.Text == "Punjap")
            {
                DropDownListCity.Items.Add("Pj");
            }

        }
        protected void DropDownListState_SelectedIndexChanged(object sender, EventArgs e)
        {
            getState();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtFullname.Text == "" )
            {
                Response.Write("Fullname cannot be blank");
            }
            else
            {
                GetData();
            }
        }

        public void GetData()
        {
            string Fullname = txtFullname.Text;

            // for gender

            string Gender = null;

            if (RadioButton1.Checked)
            {
                Gender = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                Gender = RadioButton2.Text;
            }
            else if (RadioButton3.Checked)
            {
                Gender = RadioButton3.Text;
            }

            // for category 

            string Category = null;

            if (RadioButton4.Checked)
            {
                Category = RadioButton4.Text;
            }
            else if (RadioButton5.Checked)
            {
                Category = RadioButton5.Text;
            }

            string Country = DropDownListCountry.SelectedValue;
            string State = DropDownListState.SelectedValue;
            string City = DropDownListCity.SelectedValue;
            string PaymentDate = txtPaymentDate.Text;
            string TotalAmt = txtTotalAmt.Text;
            string PaidAmt = txtPaidAmt.Text;
            string BalanceAmt = txtBalanceAmt.Text;

            StringBuilder sb = new StringBuilder();

            sb.Append("Fullname: " + Fullname + "<br>");
            sb.Append("Gender: " + Gender + "<br>");
            sb.Append("Category: " + Category + "<br>");
            sb.Append("Country: " + Country + "<br>");
            sb.Append("State: " + State + "<br>");
            sb.Append("City: " + City + "<br>");
            sb.Append("Payment Date: " + PaymentDate + "<br>");
            sb.Append("Total Amount: " + TotalAmt + "<br>");
            sb.Append("Paid Amount: " + PaidAmt + "<br>");
            sb.Append("Balance Amount: " + BalanceAmt + "<br>");

            Label1.Text = sb.ToString();
        }

        public void clear()
        {
           
        }
        float TotAmt, PAmt, BalAmt, Per;

        protected void RadioButton5_Load(object sender, EventArgs e)
        {
            
        }

        protected void RadioButton5_PreRender(object sender, EventArgs e)
        {

        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txtTotalAmt.Text = 3000.ToString();
            txtPaidAmt.Text = 0.ToString();
            txtBalanceAmt.Text = 0.ToString();
            Label1.Text = string.Empty;
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtTotalAmt.Text = 1000.ToString();
            txtPaidAmt.Text = 0.ToString();
            txtBalanceAmt.Text = 0.ToString();
            Label1.Text = string.Empty;

        }

        protected void txtPaidAmt_TextChanged(object sender, EventArgs e)
        {
            GetCalculateAmt();
            Label1.Text = string.Empty;
        }

        protected void txtTotalAmt_TextChanged(object sender, EventArgs e)
        {

        }

        public void GetCalculateAmt()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                if (RadioButton4.Checked)
                {
                    TotAmt = Convert.ToSingle(txtTotalAmt.Text);

                    PAmt = Convert.ToSingle(txtPaidAmt.Text);

                    Per = TotAmt * 0.5f;

                    BalAmt = TotAmt - PAmt;

                    if (PAmt < Per)
                    {
                        Response.Write("Minimum Amount should be : " + Per);
                        txtBalanceAmt.Text = Convert.ToSingle(0).ToString();
                    }
                    else
                    {
                        txtBalanceAmt.Text = BalAmt.ToString();
                    }


                }

                else if (RadioButton5.Checked)
                {
                    TotAmt = Convert.ToSingle(txtTotalAmt.Text);

                    PAmt = Convert.ToSingle(txtPaidAmt.Text);

                    Per = TotAmt * 0.8f;

                    BalAmt = TotAmt - PAmt;

                    if (PAmt < Per)
                    {
                        Response.Write("Minimum Amount should be : " + Per);
                        txtBalanceAmt.Text = Convert.ToSingle(0).ToString();
                    }
                    else
                    {
                        txtBalanceAmt.Text = BalAmt.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}