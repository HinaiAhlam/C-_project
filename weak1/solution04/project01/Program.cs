

//task1
//namespace project01
//{
//    internal class Program
//    {
//        static void Main(string[] args)

//        {
//            Console.WriteLine("inter a number: ");

//            string input = Console.ReadLine();
//            double number = Convert.ToDouble(input);
//            if (number > 0)
//            {
//                Console.WriteLine("Positive");
//            }
//            else if (number < 0)
//            {
//                Console.WriteLine("Negative");
//            }
//            else
//            {
//                Console.WriteLine("Zero");
//            }

//        }
//    }
//}


//task 2
//namespace project01
//{
//    internal class Program
//    {
//        static void Main(string[] args)

//        {
//            Console.WriteLine("inter an integer: ");
//            int number = int.Parse(Console.ReadLine());
//            if (number % 2 == 0)
//            {
//                Console.WriteLine("Even Number");
//            }
//            else
//            {
//                Console.WriteLine("Odd Number");
//            }
//        }
//    }
//}


//task3

//namespace project01
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter student score (0-100): ");

//            double score = double.Parse(Console.ReadLine());

//            if (score >= 90 && score <= 100)
//            {
//                Console.WriteLine("Excellent");
//            }
//            else if (score >= 75)
//            {
//                Console.WriteLine("Very Good");
//            }
//            else if (score >= 60)
//            {
//                Console.WriteLine("Good");
//            }
//            else if (score >= 50)
//            {
//                Console.WriteLine("Pass");
//            }
//            else
//            {
//                Console.WriteLine("Fail");
//            }
//        }
//    }
//}


//task4 

//namespace project01
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter Username: ");
//            string username = Console.ReadLine();

//            Console.Write("Enter Password: ");
//            string password = Console.ReadLine();

//            if (username == "admin" && password == "1234")
//            {
//                Console.WriteLine("Login Successful");
//            }
//            else
//            {
//                Console.WriteLine("Invalid Username or Password");
//            }
//        }
//    }
//}



//task5



namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000;

            Console.WriteLine("Welcome to ATM");
            Console.WriteLine("Your current balance is: " + balance);

            Console.Write("Enter the amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
 
            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance = balance - amount; 

                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("Remaining balance: " + balance);
            }
        }
    }
}