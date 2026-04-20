using System;

class Program
{
    static void Main()
    {

        #region 1
        //int[] numbers = { 10, 20, 30, 40, 50 };

        //        for (int i = 0; i < numbers.Length; i++)
        //        {
        //            Console.WriteLine(numbers[i]);
        //        }
        #endregion



        //----------------------------------------------------------


        #region 2
        //int[] numbers = { 10, 20, 30, 40, 50 };


        //foreach (int num in numbers)
        //{
        //    Console.WriteLine(num);
        //}
        #endregion

        //----------------------------------------------------
        //


        #region 3
        //int[] numbers = new int[5];

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write("Enter number: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.WriteLine("\nOutput:");

        //foreach (int num in numbers)
        //{
        //    Console.WriteLine(num);
        //}
        #endregion



        //--------------------------------------------------------------------------------------

        #region 4
        //int[] numbers = new int[5];
        //int sum = 0; 

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write($"Enter number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //foreach (int num in numbers)
        //{
        //    sum += num; 
        //}

        //Console.WriteLine("\nThe total sum is: " + sum);
        #endregion


        //--------------------------------------------------------------------


        #region 5
        //int[] numbers = new int[5];

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write($"Enter number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //int max = numbers[0];

        //for (int i = 1; i < numbers.Length; i++)
        //{
        //    if (numbers[i] > max)
        //    {
        //        max = numbers[i]; 
        //    }
        //}

        //Console.WriteLine("\nMax = " + max);
        #endregion



        //---------------------------------------------------------------------------


        #region 6
        //int[] numbers = new int[5];

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write($"Enter number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //int min = numbers[0];

        //for (int i = 1; i < numbers.Length; i++)
        //{
        //    if (numbers[i] < min)
        //    {
        //        min = numbers[i]; 
        //    }
        //}

        //Console.WriteLine("\nMin = " + min);
        #endregion



        //*------------------------------------------------------------------

        #region 7
        //int[] numbers = new int[10];

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write($"Enter number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.WriteLine("\nEven numbers only:");

        //foreach (int num in numbers)
        //{
        //    if (num % 2 == 0)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}
        #endregion

        //*---------------------------------------------------------------------------------------


        #region 8
        //int[] numbers = new int[5];
        //double sum = 0; 

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write($"Enter number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //foreach (int num in numbers)
        //{
        //    sum += num;
        //}


        //double average = sum / numbers.Length;

        //Console.WriteLine("\nAverage = " + average);
        #endregion


        //----------------------------------------------------------------------------------------------

        #region 9
        //int[] numbers = { 1, 2, 3, 4, 5 };

        //Console.WriteLine("Original Array: 1 2 3 4 5");
        //Console.Write("Reversed Array: ");


        //for (int i = numbers.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(numbers[i] + " ");
        //}
        #endregion


        //---------------------------------------------------------------------------------------------------



        #region 10
           int[] numbers = { 10, 20, 30, 40, 50 };

        Console.Write("Enter a number to search for: ");
        int target = Convert.ToInt32(Console.ReadLine());

        bool isFound = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine("Number found at index " + i);
                isFound = true;
                break; 
            }
        }

        if (!isFound)
        {
            Console.WriteLine("Number not found");
        }
        #endregion
        


    }
}