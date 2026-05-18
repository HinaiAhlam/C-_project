using System;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Student & Course Management System ===\n");

            Console.Write("Enter Student Name: ");
            string inputName = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter Student Age: ");
            int inputAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course Name: ");
            string inputCourse = Console.ReadLine() ?? "General Course";

            AppDbcontext db = new AppDbcontext();
            Students s1 = new Students();

            s1.Age = inputAge;
            s1.Name = inputName;


              

                db.Students.Add(s1);

                db.SaveChanges();
           
            Console.WriteLine("\n✅ Saved Successfully! Check your SSMS tables now.");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}