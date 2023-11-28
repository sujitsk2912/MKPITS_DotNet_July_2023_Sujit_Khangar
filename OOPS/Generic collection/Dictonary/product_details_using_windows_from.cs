using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_details_dictonary__using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total = 0, amount, quntity;

        Dictionary<int, Product> pro = new Dictionary<int, Product>();
        Product p;
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<int, Product> kvp in pro)
            {
                amount = kvp.Value.Price * kvp.Value.Quantity;
                total = total + amount;

                sb.Append("Product ID: " + kvp.Key + "\n" + "Product Name: " + kvp.Value.ProductName + "\n" + "Price: " + kvp.Value.Price + "\n" + "Quantity: " + kvp.Value.Quantity + "\n" + "Amount: " + amount + "\n" + "\n");
            }

            richTextBox1.Text = sb.ToString();

            MessageBox.Show("total of all products is : " + total);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            p = new Product(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            pro.Add(Convert.ToInt32(textBox1.Text),p);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
    }
}
