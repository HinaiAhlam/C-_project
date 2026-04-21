

namespace MultiDimensionalArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1
            //Console.Write("Enter the number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine()!);

            //Console.Write("Enter the number of columns: ");
            //int cols = Convert.ToInt32(Console.ReadLine()!);

            //int[,] numbers = new int[rows, cols];

            //Console.WriteLine($"\nPlease enter values for a {rows}x{cols} array:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter value for [{i},{j}]: ");
            //        numbers[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine("-----------------------");
            //}

            //Console.WriteLine("\n--- Displaying the Arrays ---");

            //for (int i = 0; i < rows; i++)
            //{
            //    Console.Write($"Array {i}: [ ");

            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(numbers[i, j]);

            //        if (j < cols - 1)
            //        {
            //            Console.Write(", ");
            //        }
            //    }

            //    Console.WriteLine(" ]");
            //}

            //Console.WriteLine("\nTask Completed!");
            //Console.ReadKey();
            #endregion

            //---------------------------------------------------------------------



            //Student Management System Using Arrays (C#)Assignment


            #region part1+2

            int numStudents = 5;
            int numSubjects = 3;

            string[] studentNames = new string[numStudents];
            int[,] grades = new int[numStudents, numSubjects];
            string[] subjects = { "Math", "Science", "English" };

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"\nEnter name for Student {i + 1}: ");
                studentNames[i] = Console.ReadLine()!;

                for (int j = 0; j < numSubjects; j++)
                {
                    Console.Write($"   Enter grade for {subjects[j]}: ");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            #endregion


            //*****************************************************************

            #region Part 3

                Console.WriteLine("\n\n" + new string('=', 50));
                Console.WriteLine("             STUDENT ACADEMIC REPORT");
                Console.WriteLine(new string('=', 50));

                Console.WriteLine("Name\t\tMath\tScience\tEnglish");
                Console.WriteLine("----\t\t----\t-------\t-------");

                for (int i = 0; i < numStudents; i++)
                {
                    Console.Write(studentNames[i] + (studentNames[i].Length < 8 ? "\t\t" : "\t"));

                    for (int j = 0; j < numSubjects; j++)
                    {
                        Console.Write(grades[i, j] + "\t");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Report Generated Successfully.");
                Console.ReadKey();

            #endregion
            //*********************************************************************




            #region part4

              for (int i = 0; i < numStudents; i++)
            {
                int sum = 0;
                for (int j = 0; j < numSubjects; j++)
                {
                    sum += grades[i, j]; 
                }
                double average = (double)sum / numSubjects; 
                Console.WriteLine($"{studentNames[i]}'s Average: {average:F2}");
            }

            #endregion


            //*************************************************************************************************************************


            #region part5
                int[][] jaggedGrades = new int[3][];

            jaggedGrades[0] = new int[] { 80, 90 };          
            jaggedGrades[1] = new int[] { 70, 85, 60, 95 };  
            jaggedGrades[2] = new int[] { 88 };              

            for (int i = 0; i < jaggedGrades.Length; i++)
            {
                Console.Write($"Student {i} has {jaggedGrades[i].Length} subjects: ");
                foreach (int grade in jaggedGrades[i])
                {
                    Console.Write(grade + " ");
                }
                Console.WriteLine();
            }
            #endregion

            //***************************************************************************************************************************************



            #region part6
             Console.Write("\nEnter student name to search: ");
            string searchName = Console.ReadLine()!;
            bool found = false;

            for (int i = 0; i < studentNames.Length; i++)
            {
                if (studentNames[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found! {searchName} is at index: {i}");
                    found = true;
                    break;
                }
            }

            if (!found) Console.WriteLine("Student not found.");

            #endregion

            //**********************************************************************************************************************************************************************


            #region part7
            int maxGrade = grades[0, 0];
            string topStudent = studentNames[0]; 

            for (int i = 0; i < numStudents; i++)
            {
                for (int j = 0; j < numSubjects; j++)
                {
                    if (grades[i, j] > maxGrade)
                    {
                        maxGrade = grades[i, j];    
                        topStudent = studentNames[i]; 
                    }
                }
            }

            Console.WriteLine($"\nThe highest grade in the system is: {maxGrade}");
            Console.WriteLine($"The student who got this grade is: {topStudent}");
            #endregion


            //****************************************************************************************************************************************************************************************



            #region Bonus Tasks (Optional)
               int passingStudentsCount = 0;

            for (int i = 0; i < numStudents; i++)
            {
                int sum = 0;
                for (int j = 0; j < numSubjects; j++)
                {
                    sum += grades[i, j];
                }

                double average = (double)sum / numSubjects;

                if (average >= 50)
                {
                    passingStudentsCount++;
                }
            }

            Console.WriteLine($"Total passing students: {passingStudentsCount}");
            #endregion

           









        }


    }
}