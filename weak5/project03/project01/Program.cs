using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
                SeedData(context);

                bool exit = false;
                while (!exit)
                {
                    Console.ResetColor();
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("=================================================");
                    Console.WriteLine("=== Student Course Management System (EF Core) ===");
                    Console.WriteLine("=================================================");
                    Console.ResetColor();

                    Console.WriteLine("1- Add New Student");
                    Console.WriteLine("2- Update Student");
                    Console.WriteLine("3- Delete Student");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("4- View All Students (Colored Table)");
                    Console.ResetColor();

                    Console.WriteLine("5- Search Student");
                    Console.WriteLine("6- Run LINQ Requirements Queries");
                    Console.WriteLine("7- View Advanced Department Report");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("8- Exit");
                    Console.ResetColor();
                    Console.WriteLine("-------------------------------------------------");
                    Console.Write("Select an option: ");

                    string? choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            AddStudent(context);
                            break;
                        case "2":
                            UpdateStudent(context);
                            break;
                        case "3":
                            DeleteStudent(context);
                            break;
                        case "4":
                            GetAllStudents(context);
                            break;
                        case "5":
                            SearchStudent(context);
                            break;
                        case "6":
                            RunLinqRequirements(context);
                            break;
                        case "7":
                            ViewAdvancedReport(context);
                            break;
                        case "8":
                            exit = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Invalid option! Press Enter to try again.");
                            Console.ReadLine();
                            break;
                    }
                }
            }
        }

        // 1. Add Student
        private static void AddStudent(AppDbContext context)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Add New Student ---");
            Console.ResetColor();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "Unknown";
            Console.Write("Enter Age: ");
            string? ageInput = Console.ReadLine();
            int age = int.TryParse(ageInput, out int resAge) ? resAge : 20;
            Console.Write("Enter Email: ");
            string email = Console.ReadLine() ?? "";

            var depts = context.Departments.ToList();
            Console.WriteLine("\nAvailable Departments:");
            foreach (var d in depts)
            {
                Console.WriteLine($"ID: {d.Id} - Department: {d.Name}");
            }
            Console.Write("Enter Department ID: ");
            string? deptInput = Console.ReadLine();
            int deptId = int.TryParse(deptInput, out int resDept) ? resDept : depts.First().Id;

            var student = new Student { Name = name, Age = age, Email = email, DepartmentId = deptId };
            context.Students.Add(student);
            context.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student added successfully! Press Enter.");
            Console.ReadLine();
        }

        // 2. Update Student
        private static void UpdateStudent(AppDbContext context)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Update Student ---");
            Console.ResetColor();

            Console.Write("Enter Student ID to update: ");
            string? idInput = Console.ReadLine();
            if (!int.TryParse(idInput, out int id)) return;

            var student = context.Students.Find(id);
            if (student != null)
            {
                Console.Write($"Enter New Name ({student.Name}): ");
                string? name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name)) student.Name = name;

                Console.Write($"Enter New Age ({student.Age}): ");
                string? ageStr = Console.ReadLine();
                if (!string.IsNullOrEmpty(ageStr) && int.TryParse(ageStr, out int newAge)) student.Age = newAge;

                Console.Write($"Enter New Email ({student.Email}): ");
                string? email = Console.ReadLine();
                if (!string.IsNullOrEmpty(email)) student.Email = email;

                context.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student updated successfully! Press Enter.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student not found! Press Enter.");
            }
            Console.ReadLine();
        }

        // 3. Delete Student
        private static void DeleteStudent(AppDbContext context)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--- Delete Student ---");
            Console.ResetColor();

            Console.Write("Enter Student ID to delete: ");
            string? idInput = Console.ReadLine();
            if (!int.TryParse(idInput, out int id)) return;

            var student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student deleted successfully! Press Enter.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student not found! Press Enter.");
            }
            Console.ReadLine();
        }

        // 4. Get All Students 
        private static void GetAllStudents(AppDbContext context)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("                                        STUDENTS DATA TABLE                                          ");
            Console.WriteLine("=====================================================================================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Format("| {0,-4} | {1,-20} | {2,-5} | {3,-25} | {4,-30} |", "ID", "Student Name", "Age", "Department", "Registered Courses"));
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.ResetColor();

            var students = context.Students
                .Include(s => s.Department)
                .Include(s => s.Courses)
                .ToList();

            foreach (var s in students)
            {
                string deptName = s.Department != null ? s.Department.Name : "No Department";
                string courseTitles = s.Courses.Any() ? string.Join(", ", s.Courses.Select(c => c.Title)) : "No Courses Registered";

                if (s.Id % 2 == 0) Console.ForegroundColor = ConsoleColor.White;
                else Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine(string.Format("| {0,-4} | {1,-20} | {2,-5} | {3,-25} | {4,-30} |", s.Id, s.Name, s.Age, deptName, courseTitles));
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("\nPress Enter to return to main menu.");
            Console.ReadLine();
        }

        // 5. Search Student
        private static void SearchStudent(AppDbContext context)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Search Student ---");
            Console.ResetColor();

            Console.Write("Enter Name or part of name to search (or leave empty): ");
            string? nameQuery = Console.ReadLine();
            Console.Write("Enter Age to search (or leave 0 to skip): ");
            string? ageInput = Console.ReadLine();
            int ageQuery = int.TryParse(ageInput, out int res) ? res : 0;

            var query = context.Students.AsQueryable();

            if (!string.IsNullOrEmpty(nameQuery))
                query = query.Where(s => s.Name.Contains(nameQuery));

            if (ageQuery > 0)
                query = query.Where(s => s.Age == ageQuery);

            var results = query.ToList();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nFound {results.Count} result(s):");
            Console.ResetColor();

            foreach (var s in results)
            {
                Console.WriteLine($"ID: {s.Id} | Name: {s.Name} | Age: {s.Age} | Email: {s.Email}");
            }
            Console.ReadLine();
        }

        // Part 8: Specific LINQ Requirements
        private static void RunLinqRequirements(AppDbContext context)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--- Executing Part 8 LINQ Requirements --- \n");
            Console.ResetColor();

            var localList = context.Students.ToList();

            if (!localList.Any())
            {
                Console.WriteLine("No student data available. Press Enter.");
                Console.ReadLine();
                return;
            }

            // 1. Where()
            var olderThan20 = localList.Where(s => s.Age > 20).ToList();
            Console.WriteLine($"1. Students Older Than 20 (Count): {olderThan20.Count}");

            // 2. Select()
            var namesOnly = localList.Select(s => s.Name).ToList();
            Console.WriteLine($"2. Student Names Only: {string.Join(", ", namesOnly)}");

            // 3. OrderBy()
            var orderedByAge = localList.OrderBy(s => s.Age).First();
            Console.WriteLine($"3. Youngest Student (Ordered by Age): {orderedByAge.Name} - Age: {orderedByAge.Age}");

            // 4. Count()
            int total = localList.Count();
            Console.WriteLine($"4. Total Number Of Students: {total}");

            // 5. Any()
            bool hasSenior = localList.Any(s => s.Age > 25);
            Console.WriteLine($"5. Is there any student age > 25?: {(hasSenior ? "Yes" : "No")}");

            // 6. Average()
            double avgAge = localList.Average(s => s.Age);
            Console.WriteLine($"6. Average Student Age: {avgAge:F2}");

            // 7. GroupBy()
            Console.WriteLine("7. Grouping Students by Department ID:");
            var bundled = localList.GroupBy(s => s.DepartmentId);
            foreach (var group in bundled)
            {
                Console.WriteLine($"   Department ID {group.Key} has {group.Count()} students.");
            }

            Console.ReadLine();
        }

        // Part 9: Advanced Report Requirement
        private static void ViewAdvancedReport(AppDbContext context)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--- Part 9: Department Advanced Report --- \n");
            Console.ResetColor();

            var report = context.Students
                .GroupBy(s => s.Department != null ? s.Department.Name : "No Department")
                .Select(g => new
                {
                    DepartmentName = g.Key,
                    NumberOfStudents = g.Count(),
                    AverageAge = g.Average(s => s.Age)
                }).ToList();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Format("| {0,-25} | {1,-20} | {2,-20} |", "Department Name", "Num Of Students", "Avg Student Age"));
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.ResetColor();

            foreach (var item in report)
            {
                Console.WriteLine(string.Format("| {0,-25} | {1,-20} | {2,-20:F2} |", item.DepartmentName, item.NumberOfStudents, item.AverageAge));
            }

            Console.ReadLine();
        }

        // Part 6: Seed Data 
        private static void SeedData(AppDbContext context)
        {
            if (!context.Departments.Any())
            {
                var cs = new Department { Name = "Computer Science" };
                var it = new Department { Name = "Information Technology" };
                var IS = new Department { Name = "Information Systems" };
                context.Departments.AddRange(cs, it, IS);

                var c1 = new Course { Title = "C# Programming", Hours = 60 };
                var c2 = new Course { Title = "Database Systems", Hours = 45 };
                var c3 = new Course { Title = "Web Development", Hours = 50 };
                var c4 = new Course { Title = "Software Engineering", Hours = 40 };
                var c5 = new Course { Title = "Data Structures", Hours = 55 };
                context.Courses.AddRange(c1, c2, c3, c4, c5);

                var students = new List<Student>
                {
                    new Student { Name = "Ahmed Mustafa", Age = 21, Email = "ahmed@test.com", Department = cs, Courses = new List<Course>{ c1, c2 } },
                    new Student { Name = "Fatima Al-Zahra", Age = 19, Email = "fatma@test.com", Department = cs, Courses = new List<Course>{ c1, c3 } },
                    new Student { Name = "Mohammed Al-Shammari", Age = 23, Email = "mohammed@test.com", Department = it, Courses = new List<Course>{ c2, c4 } },
                    new Student { Name = "Ali Al-Balooshi", Age = 22, Email = "ali@test.com", Department = it, Courses = new List<Course>{ c1, c5 } },
                    new Student { Name = "Omar Al-Farooq", Age = 26, Email = "omar@test.com", Department = IS, Courses = new List<Course>{ c4, c5 } },
                    new Student { Name = "Zainab Al-Ajmi", Age = 20, Email = "zainab@test.com", Department = cs, Courses = new List<Course>{ c2, c3 } },
                    new Student { Name = "Abdullah Al-Harbi", Age = 24, Email = "abdullah@test.com", Department = it, Courses = new List<Course>{ c1, c4 } },
                    new Student { Name = "Sara Al-Qahtani", Age = 18, Email = "sara@test.com", Department = IS, Courses = new List<Course>{ c3, c5 } },
                    new Student { Name = "Yousef Al-Otaibi", Age = 25, Email = "yousef@test.com", Department = cs, Courses = new List<Course>{ c1, c2, c5 } },
                    new Student { Name = "Reem Al-Dossari", Age = 21, Email = "reem@test.com", Department = it, Courses = new List<Course>{ c2, c3 } },
                    new Student { Name = "Ahlam", Age = 32, Email = "ahlam@test.com", Department = cs, Courses = new List<Course>{} }
                };

                context.Students.AddRange(students);
                context.SaveChanges();
            }
        }
    }
}