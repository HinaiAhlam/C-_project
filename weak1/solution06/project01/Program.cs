
#region for loop1
//namespace project01
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int j = 1; j <= 5; j++)
//            {
//                for (int i = 1; i <= 5; i++)
//                {
//                    Console.Write($"({i},{j}) ");
//                }
//                Console.WriteLine();
//            }

//        }
//    }
//}
#endregion





//--------------------------------------------------------------------------------------------------------------------------------------





#region for loop
//namespace project01
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a number: ");

//            int num = Convert.ToInt32(Console.ReadLine());

//            int count = 0;

//            for (int i = 1; i <= num; i++)
//            {
//                if (num % i == 0)
//                {
//                    count++;
//                }
//            }

//            if (count == 2)
//            {
//                Console.WriteLine("Prime");
//            }
//            else
//            {
//                Console.WriteLine("Not Prime");
//            }
//        }
//    }
//}
#endregion







#region while loop
//namespace project01
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rd = new Random();

//            int secretNum = rd.Next(1,10);

//            Console.WriteLine("Please Enter any number: ");
//            int num = Convert.ToInt32(Console.ReadLine());

//            while (num != secretNum)
//            {
//                Console.WriteLine("Incorrect Number. Try again: ");
//                num = Convert.ToInt32(Console.ReadLine());
//            }

//            Console.WriteLine("Correct! The secret number was " + secretNum);
//        }
//    }
//}
#endregion







#region while loop2 
//namespace project01
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rd = new Random();
//            int secretNum = rd.Next(1, 11);

//            int attempts = 1;
//            int maxAttempts = 3;

//            Console.WriteLine("Guess the number (1-10). You have 3 attempts:");
//            int num = Convert.ToInt32(Console.ReadLine());


//            while (num != secretNum && attempts < maxAttempts)
//            {
//                Console.WriteLine("Incorrect! Try again.");
//                num = Convert.ToInt32(Console.ReadLine());
//                attempts++;
//            }

//            if (num == secretNum)
//            {
//                Console.WriteLine("Congratulations! You won in " + attempts + " attempts.");
//            }
//            else
//            {
//                Console.WriteLine("Game Over! You used all 3 attempts. The number was: " + secretNum);
//            }
//        }
//    }
//}
#endregion



#region task
class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        string reversed = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }

        if (word.ToLower() == reversed.ToLower())
        {
            Console.WriteLine("Perfect!");
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
    }
}
#endregion

