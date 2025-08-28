using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    class Student
    {
        private string surname;
        private string phone;
        private int exam1;
        private int exam2;
        private int exam3;

        public Student()
        {
            surname = "Невідомий";
            phone = "0000000000";
            exam1 = 0; exam2 = 0; exam3 = 0;
        }

        public Student(string s, string p)
        {
            surname = s; phone = p;
            exam1 = 0; exam2 = 0; exam3 = 0;
        }

        public Student(string s, string p, int e1, int e2, int e3)
        {
            surname = s; phone = p;
            exam1 = e1; exam2 = e2; exam3 = e3;
        }

        public override string ToString()
        {
            return $"Прізвище: {surname}, Телефон: {phone}, Оцінки: {exam1}, {exam2}, {exam3}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Student st1 = new Student();
            Student st2 = new Student("Купиро", "0967113412");
            Student st3 = new Student("Сугак", "0679876543", 82, 70, 80);

            Console.WriteLine(st1);
            Console.WriteLine(st2);
            Console.WriteLine(st3);
            Console.ReadLine();
        }
    }
}