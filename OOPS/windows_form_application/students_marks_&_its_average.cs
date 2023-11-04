using System;
using System.Windows.Forms;

namespace Students_marks_and_its_average
{
    public partial class Form1 : Form
    {
        internal class Student
        {
            public string StudentName { get; set; }
            public int RollNumber { get; set; }
            public int SubjectMarks { get; set; }


        }
        public Form1()
        {
            InitializeComponent();
        }

        Student[] stud = new Student[3];
        int[] total = new int[3];
        int cnt = 0;
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                if (i < 3)
                {
                    int subjectMarks;
                    if (int.TryParse(textBox3.Text, out subjectMarks))
                    {
                        stud[i].SubjectMarks = subjectMarks;
                        textBox3.Clear();
                        textBox3.Focus();
                        i++;
                    }
                }

                if (i == 3)
                {
                    button1.Enabled = false;
                    button3.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new Student();
            stud[1] = new Student();
            stud[2] = new Student();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                if (i < 3)
                {
                    stud[i].StudentName = textBox1.Text;
                    int rollNumber;
                    if (int.TryParse(textBox2.Text, out rollNumber))
                    {
                        stud[i].RollNumber = rollNumber;
                        i++;
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox1.Focus();
                        button3.Enabled = false;
                        button1.Enabled = true;
                    }
                }

                if (i == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;

                    MessageBox.Show("You have entered 3 subject marks. Now click on the result button.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int totalMarks = 0;
            foreach (var student in stud)
            {
                totalMarks += student.SubjectMarks;
            }

            double average = (double)totalMarks / stud.Length;

            MessageBox.Show($"Average marks for the students: {average:F2}");
        }
    }
}

