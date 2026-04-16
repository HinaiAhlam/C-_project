
//Task 1 – Day Name Printer

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a number (1-7): ");

//        if (int.TryParse(Console.ReadLine(), out int day))
//        {
//            switch (day)
//            {
//                case 1:
//                    Console.WriteLine("Monday");
//                    break;
//                case 2:
//                    Console.WriteLine("Tuesday");
//                    break;
//                case 3:
//                    Console.WriteLine("Wednesday");
//                    break;
//                case 4:
//                    Console.WriteLine("Thursday");
//                    break;
//                case 5:
//                    Console.WriteLine("Friday");
//                    break;
//                case 6:
//                    Console.WriteLine("Saturday");
//                    break;
//                case 7:
//                    Console.WriteLine("Sunday");
//                    break;
//                default:
//                    if (!(day >= 1 && day <= 7))
//                    {
//                        Console.WriteLine("Invalid day number");
//                    }
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Please enter a valid numeric integer.");
//        }
//    }
//}

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//Task 2 – Multiplication Table



//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a number to see its multiplication table: ");

//        if (int.TryParse(Console.ReadLine(), out int number))
//        {
//            Console.WriteLine($"\nMultiplication Table for {number}:");
//            Console.WriteLine("---------------------------");

//            for (int i = 1; i <= 10; i++)
//            {
//                int result = number * i;

//                Console.WriteLine($"{number} x {i} = {result}");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer.");
//        }
//    }
//}



//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



//Task 3 – Countdown Timer


//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a positive number: ");

//        if (int.TryParse(Console.ReadLine(), out int count))
//        {
//            if (count <= 0)
//            {
//                Console.WriteLine("Please enter a positive number");
//            }
//            else
//            {
//                while (count >= 1)
//                {
//                    Console.WriteLine(count);
//                    count--;
//                }

//                Console.WriteLine("Go!");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter an integer.");
//        }
//    }
//}


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//Task 4 – Season Detector with Month Validation


//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a month number (1-12): ");

//        if (int.TryParse(Console.ReadLine(), out int month))
//        {
//            switch (month)
//            {
//                case 12:
//                case 1:
//                case 2:
//                    Console.WriteLine("Winter");
//                    break;

//                case 3:
//                case 4:
//                case 5:
//                    Console.WriteLine("Spring");
//                    break;

//                case 6:
//                case 7:
//                case 8:
//                    Console.WriteLine("Summer");
//                    break;

//                case 9:
//                case 10:
//                case 11:
//                    Console.WriteLine("Autumn");
//                    break;

//                default:
//                    if (month < 1 || month > 12)
//                    {
//                        Console.WriteLine("Invalid month number");
//                    }
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Please enter a valid numeric month.");
//        }
//    }
//}



//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//Task 5 – Sum of Even and Odd Numbers


//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a positive integer N: ");

//        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//        {
//            int evenSum = 0;
//            int oddSum = 0;

//            for (int i = 1; i <= n; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    evenSum += i;
//                }
//                else
//                {
//                    oddSum += i;
//                }
//            }

//            Console.WriteLine($"Total sum of even numbers: {evenSum}");
//            Console.WriteLine($"Total sum of odd numbers: {oddSum}");
//        }
//        else
//        {
//            Console.WriteLine("Please enter a valid positive integer.");
//        }
//    }
//}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



//Task 6 – Password Retry System


//class Program
//{
//    static void Main()
//    {
//        string correctPassword = "1234";
//        int attempts = 0;
//        int maxAttempts = 3;
//        bool accessGranted = false;

//        while (attempts < maxAttempts)
//        {
//            Console.Write("Enter password: ");
//            string input = Console.ReadLine();
//            attempts++;

//            if (input == correctPassword)
//            {
//                Console.WriteLine("Access Granted");
//                accessGranted = true;
//                break;
//            }
//            else
//            {
//                if (attempts == maxAttempts)
//                {
//                    Console.WriteLine("Account Locked");
//                }
//                else
//                {
//                    int remaining = maxAttempts - attempts;
//                    Console.WriteLine($"Wrong password, try again. Attempts remaining: {remaining}");
//                }
//            }
//        }
//    }
//}



//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//Task 7 – Simple Calculator


//class Program
//{
//    static void Main()
//    {
//        bool keepRunning = true;

//        Console.WriteLine("--- Simple Calculator ---");
//        Console.WriteLine("Enter 'exit' as the operator to stop.");

//        while (keepRunning)
//        {
//            Console.Write("\nEnter first number: ");
//            if (!double.TryParse(Console.ReadLine(), out double num1)) break;

//            Console.Write("Enter operator (+, -, *, /) or 'exit': ");
//            string op = Console.ReadLine().ToLower();

//            if (op == "exit")
//            {
//                keepRunning = false;
//                Console.WriteLine("Goodbye!");
//                continue;
//            }

//            Console.Write("Enter second number: ");
//            if (!double.TryParse(Console.ReadLine(), out double num2)) break;

//            switch (op)
//            {
//                case "+":
//                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
//                    break;
//                case "-":
//                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
//                    break;
//                case "*":
//                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
//                    break;
//                case "/":
//                    if (num2 != 0)
//                    {
//                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Error: Cannot divide by zero");
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
//                    break;
//            }
//        }
//    }
//}

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------






//Task 8 – Prime Number Checker in a Range


//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter start of range: ");
//        int start = int.Parse(Console.ReadLine());

//        Console.Write("Enter end of range: ");
//        int end = int.Parse(Console.ReadLine());

//        bool foundAnyPrime = false;

//        Console.WriteLine($"\nPrime numbers between {start} and {end}:");

//        for (int i = start; i <= end; i++)
//        {
//            if (i < 2) continue;

//            bool isPrime = true;

//            for (int j = 2; j < i; j++)
//            {
//                if (i % j == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }

//            if (isPrime)
//            {
//                Console.Write(i + " ");
//                foundAnyPrime = true;
//            }
//        }

//        if (!foundAnyPrime)
//        {
//            Console.WriteLine("No prime numbers found.");
//        }
//        else
//        {
//            Console.WriteLine();
//        }
//    }
//}

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





//Task 9 – Student Grade Report






//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the number of students (N): ");
//        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
//        {
//            Console.WriteLine("Please enter a positive integer.");
//            return;
//        }

//        List<int> scores = new List<int>();

//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write($"Enter score for student {i} (0-100): ");
//            if (int.TryParse(Console.ReadLine(), out int score))
//            {
//                scores.Add(score);

//                int key = score / 10;
//                switch (key)
//                {
//                    case 10:
//                    case 9:
//                        Console.WriteLine("Result: Excellent");
//                        break;
//                    case 8:
//                        Console.WriteLine("Result: Very Good");
//                        break;
//                    case 7:
//                        Console.WriteLine("Result: Good");
//                        break;
//                    case 6:
//                        Console.WriteLine("Result: Pass");
//                        break;
//                    default:
//                        Console.WriteLine("Result: Fail");
//                        break;
//                }
//            }
//        }

//        int countEx = 0, countVG = 0, countG = 0, countP = 0, countF = 0;
//        int highest = -1;
//        int lowest = 101;

//        foreach (int s in scores)
//        {
//            if (s > highest) highest = s;
//            if (s < lowest) lowest = s;

//            int key = s / 10;
//            switch (key)
//            {
//                case 10: case 9: countEx++; break;
//                case 8: countVG++; break;
//                case 7: countG++; break;
//                case 6: countP++; break;
//                default: countF++; break;
//            }
//        }

//        Console.WriteLine("\n--- FINAL GRADE REPORT ---");
//        Console.WriteLine($"Excellent: {countEx}");
//        Console.WriteLine($"Very Good: {countVG}");
//        Console.WriteLine($"Good:      {countG}");
//        Console.WriteLine($"Pass:      {countP}");
//        Console.WriteLine($"Fail:      {countF}");
//        Console.WriteLine("--------------------------");
//        Console.WriteLine($"Highest Score: {highest}");
//        Console.WriteLine($"Lowest Score:  {lowest}");
//    }
//}

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




//Task 10 – Mini Banking System



class Program
{
    static void Main()
    {
        int balance = 5000;
        string pin = "9999";

        string[] transType = new string[100]; 
        int[] transAmount = new int[100];     
        int transIndex = 0;                   

        int attempts = 0;
        bool loggedIn = false;

        while (attempts < 3)
        {
            Console.Write("Enter PIN: ");
            string inputPin = Console.ReadLine();
            attempts++;

            if (inputPin == pin)
            {
                loggedIn = true;
                break;
            }
            else
            {
                if (attempts < 3)
                    Console.WriteLine($"Wrong PIN. {3 - attempts} attempts left.");
                else
                    Console.WriteLine("Card Blocked.");
            }
        }

        if (loggedIn)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- ATM MENU ---");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine($"Current Balance: {balance}");
                        break;

                    case "2": 
                        Console.Write("Enter deposit amount: ");
                        int depAmt = int.Parse(Console.ReadLine());
                        if (depAmt > 0 && depAmt <= 10000)
                        {
                            balance += depAmt;
                            transType[transIndex] = "Deposit";
                            transAmount[transIndex] = depAmt;
                            transIndex++;
                            Console.WriteLine("Deposit successful.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter withdrawal amount: ");
                        int withAmt = int.Parse(Console.ReadLine());
                        if (withAmt > 0 && withAmt <= balance)
                        {
                            balance -= withAmt;
                            transType[transIndex] = "Withdrawal";
                            transAmount[transIndex] = withAmt;
                            transIndex++;
                            Console.WriteLine("Withdrawal successful.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance or invalid amount.");
                        }
                        break;

                    case "4":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }

            Console.WriteLine("\n--- TRANSACTION LOG ---");
            if (transIndex == 0)
            {
                Console.WriteLine("No transactions made.");
            }
            else
            {
                for (int i = 0; i < transIndex; i++)
                {
                    Console.WriteLine($"{i + 1}. {transType[i]}: {transAmount[i]}");
                }
            }
            Console.WriteLine("Thank you for using our ATM!");
        }
    }
}