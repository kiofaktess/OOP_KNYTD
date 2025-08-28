using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    class Student
    {
        private string surname;
        private string phone;
        private int exam1;
        private int exam2;
        private int exam3;

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

        public string Group { get; set; }
        public int Course { get; set; }

        public double Average
        {
            get { return (exam1 + exam2 + exam3) / 3.0; }
        }

        public Student()
        {
            Surname = "Невідомий";
            Phone = "0000000000";
            exam1 = 0; exam2 = 0; exam3 = 0;
            Group = "N/A"; Course = 0;
        }

        public Student(string s, string p, int e1, int e2, int e3)
        {
            Surname = s; Phone = p;
            exam1 = e1; exam2 = e2; exam3 = e3;
            Group = "Default"; Course = 1;
        }

        public void SetExams(int e1, int e2, int e3)
        {
            exam1 = e1; exam2 = e2; exam3 = e3;
        }

        public void ChangePhone(ref string newPhone)
        {
            Phone = newPhone;
        }

        public override string ToString()
        {
            return $"Прізвище: {Surname}, Телефон: {Phone}, Оцінки: {exam1}, {exam2}, {exam3}, " +
                   $"Група: {Group}, Курс: {Course}, Середній бал: {Average:F2}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Student st = new Student("Купиро", "0501234567", 80, 72, 82);
            st.Group = "БІП-1-24";
            st.Course = 2;

            string newPhone = "0931112233";
            st.ChangePhone(ref newPhone);

            Console.WriteLine(st);
            Console.ReadLine();
        }
    }
}