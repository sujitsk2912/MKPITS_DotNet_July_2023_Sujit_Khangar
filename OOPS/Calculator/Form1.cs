using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Op = null;
        decimal PreviousNo = 0;
        decimal Result = 0;
        private void equal_to_Click(object sender, EventArgs e)
        {
            switch (Op)
            {
                case "+":
                    Result = PreviousNo + Convert.ToInt32(DisplayResult.Text);
                    break;

                case "-":
                    Result = PreviousNo - Convert.ToInt32(DisplayResult.Text);
                    break;

                case "*":
                    Result = PreviousNo * Convert.ToInt32(DisplayResult.Text);
                    break;

                case "/":
                    Result = PreviousNo / Convert.ToInt32(DisplayResult.Text);
                    break;
            }

            DisplayResult.Text = Result.ToString();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            PreviousNo = Convert.ToInt32(DisplayResult.Text);
            DisplayResult.Text = "+";
            Op = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            PreviousNo = Convert.ToInt32(DisplayResult.Text);
            DisplayResult.Text = "-";
            Op = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            PreviousNo = Convert.ToInt32(DisplayResult.Text);
            DisplayResult.Text = "*";
            Op = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            PreviousNo = Convert.ToInt32(DisplayResult.Text);
            DisplayResult.Text = "/";
            Op = "/";
        }

        private void all_clear_Click(object sender, EventArgs e)
        {
            DisplayResult.Clear();
            DisplayResult.Focus();
        }

        private void One_Click(object sender, EventArgs e)
        {
            if(DisplayResult.Text == "")
            {
                DisplayResult.Text = "1";
            }
            else
            {
                if(Op != null)
                {
                    if(DisplayResult.Text == "+" ||  DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "1";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "1";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "1";
                }
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (DisplayResult.Text == "")
            {
                DisplayResult.Text = "2";
            }
            else
            {
                if (Op != null)
                {
                    if (DisplayResult.Text == "+" || DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "2";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "2";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "2";
                }
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (DisplayResult.Text == "")
            {
                DisplayResult.Text = "3";
            }
            else
            {
                if (Op != null)
                {
                    if (DisplayResult.Text == "+" || DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "3";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "3";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "3";
                }
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (DisplayResult.Text == "")
            {
                DisplayResult.Text = "4";
            }
            else
            {
                if (Op != null)
                {
                    if (DisplayResult.Text == "+" || DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "4";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "4";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "4";
                }
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (DisplayResult.Text == "")
            {
                DisplayResult.Text = "5";
            }
            else
            {
                if (Op != null)
                {
                    if (DisplayResult.Text == "+" || DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "5";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "5";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "5";
                }
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (DisplayResult.Text == "")
            {
                DisplayResult.Text = "6";
            }
            else
            {
                if (Op != null)
                {
                    if (DisplayResult.Text == "+" || DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "6";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "6";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "6";
                }
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (DisplayResult.Text == "")
            {
                DisplayResult.Text = "7";
            }
            else
            {
                if (Op != null)
                {
                    if (DisplayResult.Text == "+" || DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "7";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "7";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "7";
                }
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (DisplayResult.Text == "")
            {
                DisplayResult.Text = "8";
            }
            else
            {
                if (Op != null)
                {
                    if (DisplayResult.Text == "+" || DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "8";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "8";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "8";
                }
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (DisplayResult.Text == "")
            {
                DisplayResult.Text = "9";
            }
            else
            {
                if (Op != null)
                {
                    if (DisplayResult.Text == "+" || DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "9";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "9";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "9";
                }
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (DisplayResult.Text == "")
            {
                DisplayResult.Text = "0";
            }
            else
            {
                if (Op != null)
                {
                    if (DisplayResult.Text == "+" || DisplayResult.Text == "-" || DisplayResult.Text == "*" || DisplayResult.Text == "/")
                    {
                        DisplayResult.Clear();
                        DisplayResult.Text = DisplayResult.Text + "0";
                    }
                    else
                    {
                        DisplayResult.Text = DisplayResult.Text + "0";
                    }
                }
                else
                {
                    DisplayResult.Text = DisplayResult.Text + "0";
                }
            }

        }

        private void DisplayResult_TextChanged(object sender, EventArgs e)
        {
            
         }
    }
}
