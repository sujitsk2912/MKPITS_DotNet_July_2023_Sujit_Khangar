using System;
using System.Text;
using System.Windows.Forms;

namespace Students_marks_and_its_average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal class Student
        {
            public string StudentName { get; set; }
            public int RollNumber { get; set; }
            public int SubjectMarks { get; set; }

        }

        Student[] sub = new Student[9];
        Student[] student = new Student[3];
        int[] total = new int[3];
        float [] avg = new float[3]; 

        int cnt = 0;
        int i = 0;

        
        private void button1_Click(object sender, EventArgs e)
        {

            if (cnt < 9)
            {
                sub[cnt].SubjectMarks = Convert.ToInt32(textBox3.Text);
                textBox3.Clear();
                textBox3.Focus();
                cnt++;

                if (cnt == 3)
                {
                    total[0] = sub[0].SubjectMarks + sub[1].SubjectMarks + sub[2].SubjectMarks;
                    avg[0] = total[0] / 3;
                    button1.Enabled = false;
                    button3.Enabled = true;
                }

                if (cnt == 6)
                {
                    total[1] = sub[3].SubjectMarks + sub[4].SubjectMarks + sub[5].SubjectMarks;
                    avg[1] = total[1] / 3;
                    button1.Enabled = false;
                    button3.Enabled = true;
                }

                if (cnt == 9)
                {
                    total[2] = sub[6].SubjectMarks + sub[7].SubjectMarks + sub[8].SubjectMarks;
                    avg[2] = total[2] / 3;
                    button1.Enabled = false;
                    button3.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            student[0] = new Student();
            student[1] = new Student();
            student[2] = new Student();

            sub[0] = new Student();
            sub[1] = new Student();
            sub[2] = new Student();
            sub[3] = new Student();
            sub[4] = new Student();
            sub[5] = new Student();
            sub[6] = new Student();
            sub[7] = new Student();
            sub[8] = new Student();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (i < 3)
            {
                student[i].StudentName = textBox1.Text;
                student[i].RollNumber = Convert.ToInt32(textBox2.Text);
                i++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                button3.Enabled = false;
                button1.Enabled = true;
            }

            if (i == 3)
            {
                button1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button2.Enabled = true;

                MessageBox.Show("You have entered 3 subject marks. Now click on the Submit button.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            for (i = 0; i < 3; i++)
            {
                int sum = i + 1;
                sb.Append("\n-------- Student " + sum + " Details --------\n\n");
                sb.AppendLine("Student Name: " + student[i].StudentName);
                sb.AppendLine("Roll No.: " + student[i].RollNumber);
                sb.AppendLine("Total Marks: " + total[i]);
                sb.AppendLine("Average: " + avg[i]);
            }
                label4.Text = sb.ToString();
        }
    }
}

