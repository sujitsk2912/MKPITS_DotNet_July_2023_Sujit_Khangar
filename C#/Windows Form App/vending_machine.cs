using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chocolate_vending_machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int coin, rem;

            coin = Convert.ToInt32(textBox1.Text);

            if ( coin == 10 || coin >= 10 )
            {
                if (numericUpDown1.Value == 0)
                {

                }
                else if (numericUpDown1.Value == 1)
                {
                    label5.Text = "Selected Order: Chips";
                }
                else if (numericUpDown1.Value == 2)
                {
                    label5.Text = "Selected Order: Kurkure";
                }
                else if (numericUpDown1.Value == 3)
                {
                    label5.Text = "Selected Order: Frutee";
                }
                else if (numericUpDown1.Value == 4)
                {
                    label5.Text = "Selected Order: Smoothy";
                }
                else if (numericUpDown1.Value == 5)
                {
                    label5.Text = "Selected Order: Snickers";
                }
                else if (numericUpDown1.Value == 6)
                {
                    label5.Text = "Selected Order: 5Star";
                }
                else if (numericUpDown1.Value == 7)
                {
                    label5.Text = "Selected Order: Dairy Milk";
                }

                label4.Text = "Please Collect Your Order";
            }
            else
            {
                label4.Text = "Insufficient Amount, please insert Minimum 10.Rs";
            }
            

          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          
           

        }
    }
}
