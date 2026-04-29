using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var students = new Dictionary<int, string>();
        var queue = new Queue<int>();
        var stack = new Stack<int>();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============================================");
            Console.WriteLine("        STUDENT SERVICE CENTER SYSTEM         ");
            Console.WriteLine("==============================================");
            Console.ResetColor();
            Console.WriteLine("1. Add Student          5. Join Service Queue");
            Console.WriteLine("2. Update Student       6. Serve Next Student");
            Console.WriteLine("3. Remove Student       7. Undo Last Service ");
            Console.WriteLine("4. Show All Students    8. Show Queue Status ");
            Console.WriteLine("9. Exit");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine()!; 

            if (choice == "9") break;

            switch (choice)
            {
                case "1":
                    Console.Write("Enter ID: "); int id = int.Parse(Console.ReadLine()!);
                    if (!students.ContainsKey(id))
                    {
                        Console.Write("Enter Name: "); students[id] = Console.ReadLine()!;
                    }
                    else Console.WriteLine("ID exists!");
                    break;

                case "2":
                    Console.Write("Enter ID to Update: "); int upId = int.Parse(Console.ReadLine()!);
                    if (students.ContainsKey(upId))
                    {
                        Console.Write("New Name: "); students[upId] = Console.ReadLine()!;
                    }
                    break;

                case "3":
                    Console.Write("Enter ID to Remove: "); students.Remove(int.Parse(Console.ReadLine()!));
                    break;

                case "4":
                    Console.WriteLine("\n--- All Students ---");
                    foreach (var s in students) Console.WriteLine($"{s.Key}: {s.Value}");
                    break;

                case "5":
                    Console.Write("Enter ID to Join Queue: "); int qId = int.Parse(Console.ReadLine()!);
                    if (students.ContainsKey(qId)) queue.Enqueue(qId);
                    break;

                case "6":
                    if (queue.Count > 0)
                    {
                        int sId = queue.Dequeue();
                        stack.Push(sId);
                        Console.WriteLine($"Serving: {students[sId]}");
                    }
                    else Console.WriteLine("Queue empty!");
                    break;

                case "7":
                    if (stack.Count > 0)
                    {
                        int undoId = stack.Pop();
                        queue.Enqueue(undoId);
                        Console.WriteLine($"Restored: {students[undoId]}");
                    }
                    break;

                case "8":
                    Console.WriteLine($"\n--- Queue ({queue.Count} waiting) ---");
                    foreach (int i in queue) Console.WriteLine("- " + students[i]);
                    break;
            }

            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
            Console.Clear(); 
        }
    }
}