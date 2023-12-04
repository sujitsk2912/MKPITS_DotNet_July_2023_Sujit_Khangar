using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_diamentional_array_for_multiple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        string[,] arry = new string[2,2];
        StringBuilder sb = new StringBuilder();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if( i < 3 )
            {
                arry[0, 0] = textBox1.Text;
                arry[0, 1] = textBox2.Text;
                arry[1, 0] = textBox3.Text;
                arry[1, 1] = textBox4.Text;

                sb.AppendLine("Name: " + arry[0, 0]);
                sb.AppendLine("Surname: " + arry[0, 1]);
                sb.AppendLine("Email: " + arry[1, 0]);
                sb.AppendLine("Address: " + arry[1, 1]);
                sb.AppendLine();

                i++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();

                if ( i == 3 )
                {
                    MessageBox.Show("Three Data are Enrolled succesfully");
                }
            }
            else
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = sb.ToString();
        }
    }
}
