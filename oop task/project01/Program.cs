using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        private int _id;
        private double _salary;

        public int Id
        {
            get => _id;
            set { if (value > 0) _id = value; }
        }

        public double Salary
        {
            get => _salary;
            set { if (value >= 0) _salary = value; }
        }

        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;

        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; } = string.Empty;

        public override void Work()
        {
            Console.WriteLine("Developer is writing code");
        }
    }

    public class Designer : Employee
    {
        public string DesignTool { get; set; } = string.Empty;

        public override void Work()
        {
            Console.WriteLine("Designer is creating UI designs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Developer { Id = 1, Name = "Ahmed", Salary = 5000, ProgrammingLanguage = "C#" });
            employees.Add(new Designer { Id = 2, Name = "Sara", Salary = 4500, DesignTool = "Figma" });

            Console.WriteLine("--- System Output ---");
            foreach (var emp in employees)
            {
                emp.Work();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}