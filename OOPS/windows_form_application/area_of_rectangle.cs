using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rectangle_claass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal class Rectangle
        {
            public int length { get; set; }
            public int width { get; set; }

            public int area { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();


            int length = Convert.ToInt32(textBox1.Text);

            int width = Convert.ToInt32(textBox2.Text);

            rect.area = length * width;

            StringBuilder sb = new StringBuilder();
            sb.Append("Area of rectangle: " + rect.area);

            label3.Text = sb.ToString();

        }
    }
}
