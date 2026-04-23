
class Program
{
    static void Main()
    {
        RunCalculator(); 
    }

    static void RunCalculator()
    {
        string choice;
        do
        {
            Console.Write("inter first Num ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("inter second Num ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("shose an Op (+, -, *, /): ");
            string op = Console.ReadLine();

            if (op == "+") Console.WriteLine("Result: " + (n1 + n2));
            else if (op == "-") Console.WriteLine("Result: " + (n1 - n2));
            else if (op == "*") Console.WriteLine("Result: " + (n1 * n2));
            else if (op == "/") Console.WriteLine("Result: " + (n1 / n2));

            Console.Write("Another calculation? (yes/no): ");
            choice = Console.ReadLine().ToLower();

        } while (choice == "yes"); 
    }
}