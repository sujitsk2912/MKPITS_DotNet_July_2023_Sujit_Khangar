using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_diamentional_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] arry = new string[2, 2];
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            arry[0,0] = textBox1.Text;
            arry[0,1] = textBox2.Text;
            arry[1,0] = textBox3.Text;
            arry[1,1] = textBox4.Text;

            sb.AppendLine("Name: " + arry[0, 0]);
            sb.AppendLine("Surname: " + arry[0, 1]);
            sb.AppendLine("E-mail: " + arry[1, 0]);
            sb.AppendLine("Address: " + arry[1, 1]);

            richTextBox1.Text = sb.ToString();
        }
    }
}
