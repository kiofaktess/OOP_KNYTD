using System;
using System.Text;

namespace OOP_Lab1
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

        public void Display()
        {
            Console.WriteLine($"Прізвище: {Surname}, Телефон: {Phone}, Оцінки: {Exam1}, {Exam2}, {Exam3}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Student st1 = new Student("Купиро", "0967112345", 80, 72, 82);
            Student st2 = new Student("Сугак", "0679876543", 83, 70, 80);

            st1.Display();
            st2.Display();
            Console.ReadLine();
        }
    }
}