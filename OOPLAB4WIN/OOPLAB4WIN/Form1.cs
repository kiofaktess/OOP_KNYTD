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
            if (string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtExam1.Text) ||
                string.IsNullOrWhiteSpace(txtExam2.Text) ||
                string.IsNullOrWhiteSpace(txtExam3.Text) ||
                string.IsNullOrWhiteSpace(txtGroup.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля!");
                return;
            }

            if (!int.TryParse(txtExam1.Text, out int e1) ||
                !int.TryParse(txtExam2.Text, out int e2) ||
                !int.TryParse(txtExam3.Text, out int e3) ||
                !int.TryParse(txtCourse.Text, out int course))
            {
                MessageBox.Show("Поля з оцінками та курсом повинні містити лише цифри!");
                return;
            }

            if (e1 < 1 || e1 > 100 || e2 < 1 || e2 > 100 || e3 < 1 || e3 > 100)
            {
                MessageBox.Show("Оцінки повинні бути у межах від 1 до 12!");
                return;
            }

            Student st = new Student(
                txtSurname.Text,
                txtPhone.Text,
                e1,
                e2,
                e3,
                txtGroup.Text,
                course
            );

            listBoxStudents.Items.Add(st);
            MessageBox.Show("✅ Студента успішно додано!");
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
