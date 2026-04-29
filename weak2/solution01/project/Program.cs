
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();

        if (!double.TryParse(input1, out double num1))
        {
            Console.WriteLine("Invalid input! Please enter numbers only.");
            return;
        }

        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        if (!double.TryParse(input2, out double num2))
        {
            Console.WriteLine("Invalid input! Please enter numbers only.");
            return;
        }

        Console.WriteLine("The sum is: " + (num1 + num2));
    }
}