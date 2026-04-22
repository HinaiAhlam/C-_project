

using System.Diagnostics;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("exam1.txt", "Exam 1: This is the Basic C# test.");
            File.WriteAllText("exam2.txt", "Exam 2: This is the Intermediate Arrays test.");
            File.WriteAllText("exam3.txt", "Exam 3: This is the Advanced File Stream test.");

            Console.WriteLine("Enter exam number (1, 2, or 3):");
            string choice = Console.ReadLine();

            string fileName = "exam" + choice + ".txt";

            if (File.Exists(fileName))
            {
                Process.Start(new ProcessStartInfo(fileName) { UseShellExecute = true });
                Console.WriteLine("File opened successfully!");
            }
            else
            {
                Console.WriteLine("Error: File not found.");
            }
        }
        }
    }