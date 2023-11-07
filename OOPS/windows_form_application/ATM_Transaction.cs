using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Transaction_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Balance = 50000;
        float Deposite = 0;
        float Withdraw = 0;
        float Total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
           int PIN = Convert.ToInt32(textBox1.Text);

            if(PIN == 1234)
            {
               // MessageBox.Show("PIN IS Correct");
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                button4.Visible = true;
            }

            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button4.Visible = false;

                label4.Hide();
                label5.Hide();
                label2.Visible = false;
                textBox2.Visible = false;
                button2.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;
                button3.Visible = false;
                MessageBox.Show("Incorrect PIN, Please Enter Correct PIN");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Account Number: 123456");
                sb.AppendLine("Account Holder Name: Sujit Khangar");
                sb.AppendLine("Available Balance: " + Balance);

                
                label4.Text = sb.ToString();
                label4.Visible = true;

                // hiding other content except radiobutton1 content

                label5.Hide();
                label2.Visible = false;
                textBox2.Visible = false;
                button2.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;
                button3.Visible = false;
            }

            if (radioButton2.Checked)
            {
                // MessageBox.Show("Button 4 clicked");
                
                textBox2.Clear();
                label2.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;

                // hiding other content except radiobutton2 content

                label4.Hide();
                label3.Visible = false;
                textBox3.Visible = false;
                button3.Visible = false;
                label5.Hide();
            }

            if (radioButton3.Checked)
            {
                label4.Hide();
                label5.Hide();
                textBox3.Clear();
                label3.Visible = true;
                textBox3.Visible = true;
                button3.Visible = true;
                
                // hiding other content except radiobutton3 content

                label2.Visible = false;
                textBox2.Visible = false;
                button2.Visible = false;
            }

            if (radioButton4.Checked)
            {
                textBox1.Clear();
                textBox1.Focus();
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button4.Visible = false;

                // hiding other content except radiobutton4 content

                label2.Visible = false;
                textBox2.Visible = false;
                button2.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;
                button3.Visible = false;
                label4.Hide();
                label5.Hide();

                MessageBox.Show("THANKS FOR USING OUR ATM SERVICE");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            label5.Visible = true;

            Deposite = Convert.ToSingle(textBox2.Text);

            Total = Balance + Deposite;

            sb.AppendLine("Amount Deposited Succesfully");
            sb.AppendLine();
            sb.AppendLine("Total Balance: " + Total);
            sb.AppendLine();
            sb.AppendLine("THANKS FOR USING OUR ATM SERVICE");

            label5.Text = sb.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            label5.Visible = true;

            Withdraw = Convert.ToSingle(textBox3.Text);

            Total = Balance - Withdraw;

            sb.AppendLine("Please Collect Your Money");
            sb.AppendLine();
            sb.AppendLine("Remaining Balance: " + Total);
            sb.AppendLine();
            sb.AppendLine("THANKS FOR USING OUR ATM SERVICE");

            label5.Text = sb.ToString();
        }
    }
}
