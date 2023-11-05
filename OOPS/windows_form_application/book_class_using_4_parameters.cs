using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_class_using_parameterized_constructor
{
    public partial class Form1 : Form
    {
        internal class Book
        {
            int BookId;
            string Title;
            string Author;
            int Price;

            public Book(int BookId, string Title, string Author, int Price)
            {
                this.BookId = BookId;
                this.Title = Title;
                this.Author = Author;
                this.Price = Price;
            }
        }
            public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(textBox1.Text);
            string title = textBox2.Text;
            string author = textBox3.Text;
            int price = Convert.ToInt32(textBox4.Text);

            Book book = new Book(bookid, title, author, price);

            StringBuilder sb = new StringBuilder();

            sb.Append("Book ID: " + bookid + "\n");
            sb.Append("Title: " + title + "\n");
            sb.Append("Author: " + author + "\n");
            sb.Append("Price: " + price + "\n");

            label5.Text = sb.ToString();

        }
    }
}
