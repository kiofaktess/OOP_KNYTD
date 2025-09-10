using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLAB3WIN
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

            // Конструктор без параметрів
            public Student()
            {
                surname = "Невідомий";
                phone = "0000000000";
                exam1 = exam2 = exam3 = 0;
            }

            // Конструктор з 2 параметрами
            public Student(string s, string p)
            {
                surname = s;
                phone = p;
                exam1 = exam2 = exam3 = 0;
            }

            // Конструктор з усіма параметрами
            public Student(string s, string p, int e1, int e2, int e3)
            {
                surname = s;
                phone = p;
                exam1 = e1;
                exam2 = e2;
                exam3 = e3;
            }

            public override string ToString()
            {
                return $"Прізвище: {surname}, Телефон: {phone}, Оцінки: {exam1}, {exam2}, {exam3}";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student st;

            // Якщо все порожнє → конструктор без параметрів
            if (string.IsNullOrWhiteSpace(txtSurname.Text) &&
                string.IsNullOrWhiteSpace(txtPhone.Text) &&
                string.IsNullOrWhiteSpace(txtExam1.Text) &&
                string.IsNullOrWhiteSpace(txtExam2.Text) &&
                string.IsNullOrWhiteSpace(txtExam3.Text))
            {
                st = new Student();
            }
            // Якщо тільки Прізвище і Телефон → конструктор з 2 параметрами
            else if (!string.IsNullOrWhiteSpace(txtSurname.Text) &&
                     !string.IsNullOrWhiteSpace(txtPhone.Text) &&
                     string.IsNullOrWhiteSpace(txtExam1.Text) &&
                     string.IsNullOrWhiteSpace(txtExam2.Text) &&
                     string.IsNullOrWhiteSpace(txtExam3.Text))
            {
                st = new Student(txtSurname.Text, txtPhone.Text);
            }
            // Якщо є всі поля → повний конструктор
            else if (!string.IsNullOrWhiteSpace(txtSurname.Text) &&
                     !string.IsNullOrWhiteSpace(txtPhone.Text) &&
                     !string.IsNullOrWhiteSpace(txtExam1.Text) &&
                     !string.IsNullOrWhiteSpace(txtExam2.Text) &&
                     !string.IsNullOrWhiteSpace(txtExam3.Text))
            {
                st = new Student(
                    txtSurname.Text,
                    txtPhone.Text,
                    int.Parse(txtExam1.Text),
                    int.Parse(txtExam2.Text),
                    int.Parse(txtExam3.Text)
                );
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть або всі поля, або тільки Прізвище+Телефон, або залиште все пустим!");
                return;
            }

            listBoxStudents.Items.Add(st);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
        }
    }
}
