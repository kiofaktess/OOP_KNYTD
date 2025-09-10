using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLAB2WIN
{

    public partial class Form1 : Form
    {
        class Student
        {
            private string surname;
            private string phone;
            public int Exam1;
            public int Exam2;
            public int Exam3;

            public Student(string s, string p, int e1, int e2, int e3)
            {
                surname = s;
                phone = p;
                Exam1 = e1;
                Exam2 = e2;
                Exam3 = e3;
            }
            public void SetSurname(string s) { surname = s; }
            public string GetSurname() { return surname; }

            public void SetPhone(string p) { phone = p; }
            public string GetPhone() { return phone; }

            public override string ToString()
            {
                return $"Прізвище: {surname}, Телефон: {phone}, Оцінки: {Exam1}, {Exam2}, {Exam3}";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student st = new Student("", "", 0, 0, 0);

            st.SetSurname(txtSurname.Text);
            st.SetPhone(txtPhone.Text);
            st.Exam1 = int.Parse(txtExam1.Text);
            st.Exam2 = int.Parse(txtExam2.Text);
            st.Exam3 = int.Parse(txtExam3.Text);

            listBoxStudents.Items.Add(st);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
        }
    }
}
