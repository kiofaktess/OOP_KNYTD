using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2
{
    class Student
    {
        private string surname;
        private string phone;
        public int Exam1;
        public int Exam2;
        public int Exam3;

        public void SetSurname(string s) { surname = s; }
        public string GetSurname() { return surname; }

        public void SetPhone(string p) { phone = p; }
        public string GetPhone() { return phone; }

        public override string ToString()
        {
            return $"Прізвище: {surname}, Телефон: {phone}, Оцінки: {Exam1}, {Exam2}, {Exam3}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Student st1 = new Student();
            st1.SetSurname("Купиро");
            st1.SetPhone("0967113412");
            st1.Exam1 = 80;
            st1.Exam2 = 72;
            st1.Exam3 = 82;

            Student st2 = new Student();
            st2.SetSurname("Сугак");
            st2.SetPhone("0679876543");
            st2.Exam1 = 83;
            st2.Exam2 = 70;
            st2.Exam3 = 80;

            Console.WriteLine(st1.ToString());
            Console.WriteLine(st2.ToString());
            Console.ReadLine();
        }
    }
}