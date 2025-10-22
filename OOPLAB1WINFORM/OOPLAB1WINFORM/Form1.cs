using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLAB1WINFORM
{
    public partial class Form1 : Form
    {
        class Student
        {
            public string Surname;
            public string Phone;
            public int Exam1;
            public int Exam2;
            public int Exam3;

            public Student(string surname, string phone, int exam1, int exam2, int exam3)
            {
                Surname = surname;
                Phone = phone;
                Exam1 = exam1;
                Exam2 = exam2;
                Exam3 = exam3;
            }

            public override string ToString()
            {
                return $"Прізвище: {Surname}, Телефон: {Phone}, Оцінки: {Exam1}, {Exam2}, {Exam3}";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string surname = txtSurname.Text;
            string phone = txtPhone.Text;
            int exam1 = int.Parse(txtExam1.Text);
            int exam2 = int.Parse(txtExam2.Text);
            int exam3 = int.Parse(txtExam3.Text);

            Student st = new Student(surname, phone, exam1, exam2, exam3);
            listBoxStudents.Items.Add(st.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
        }

    }
}
