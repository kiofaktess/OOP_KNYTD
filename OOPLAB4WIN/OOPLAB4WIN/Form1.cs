using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLAB4WIN
{
    public partial class Form1 : Form
    {
        class Student
        {
            private string surname;
            private string phone;
            private int exam1;
            private int exam2;
            private int exam3;

            // Властивості
            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }

            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }

            // Автоматичні властивості
            public string Group { get; set; }
            public int Course { get; set; }

            // Властивість тільки для читання
            public double Average
            {
                get { return (exam1 + exam2 + exam3) / 3.0; }
            }

            // Конструктор з усіма параметрами
            public Student(string s, string p, int e1, int e2, int e3, string g, int c)
            {
                Surname = s;
                Phone = p;
                exam1 = e1;
                exam2 = e2;
                exam3 = e3;
                Group = g;
                Course = c;
            }

            // Метод з ref
            public void ChangePhone(ref string newPhone)
            {
                Phone = newPhone;
            }

            public override string ToString()
            {
                return $"Прізвище: {Surname}, Телефон: {Phone}, " +
                       $"Оцінки: {exam1}, {exam2}, {exam3}, " +
                       $"Група: {Group}, Курс: {Course}, ";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student st = new Student(
                txtSurname.Text,
                txtPhone.Text,
                int.Parse(txtExam1.Text),
                int.Parse(txtExam2.Text),
                int.Parse(txtExam3.Text),
                txtGroup.Text,
                int.Parse(txtCourse.Text)
            );

            listBoxStudents.Items.Add(st);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem is Student st)
            {
                MessageBox.Show($"Середній бал студента {st.Surname}: {st.Average:F2}");
            }
            else
            {
                MessageBox.Show("Виберіть студента у списку!");
            }
        }
    }
}
