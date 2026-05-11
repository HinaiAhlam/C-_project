using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Student
    {
        public string name;
    }

    class Classroom
    {
        public string className;

        public List<Student> students;

        public Classroom(string name)
        {
            className = name;

            students = new List<Student>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { name = "Noor" };
            Student s2 = new Student { name = "Ahmed" };

            Classroom c1 = new Classroom("Grade 10");

            c1.students.Add(s1);
            c1.students.Add(s2);

            Console.WriteLine(c1.className);

            foreach (var x in c1.students)
            {
                Console.WriteLine(x.name);
            }
        }
    }
}