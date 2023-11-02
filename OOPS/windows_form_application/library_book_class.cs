using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Form1 : Form
    {
        internal class LibraryBook
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public bool IsAvailable { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        LibraryBook[] book = new LibraryBook[3];
        int cnt = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------- AVAILABLE BOOKS --------\n");
            for ( int i = 0; i < 3; i++)
            {
                if (book[i].IsAvailable == true)
                {
                    sb.Append("--------------------------\n");
                    sb.Append("Title: " + book[i].Title + "\n");
                    sb.Append("Author: " + book[i].Author + "\n");
                    sb.Append("--------------------------\n");
                }
                label3.Text = sb.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( cnt < 3 )
            {
                book[cnt].Title = textBox1.Text;
                book[cnt].Author = textBox2.Text;
                if ( checkBox1.Checked)
                {
                    book[cnt].IsAvailable = true;
                }
               
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

                if( cnt == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    checkBox1.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("3 books data are submited, now click on Submit ");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            book[0] = new LibraryBook();
            book[1] = new LibraryBook();
            book[2] = new LibraryBook();
        }
    }
}
