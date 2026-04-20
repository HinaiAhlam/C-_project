
namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //int size = 5;
            //int[] numbers = new int[size];


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");

            //    string input = Console.ReadLine();
            //    numbers[i] = Convert.ToInt32(input);
            //}

            //Console.WriteLine("/********************/");

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion




            //--------------------------------------------------------------------------------

            #region 2
            //int[] friends = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.WriteLine("/*/**/ */*/*/*/*/*/*/*/*/*/");


            //Console.WriteLine(Array.IndexOf(friends, 5));

            //Console.ReadLine();
            #endregion

            //--------------------------------------------------------------------

            #region 3
            int[] friends = { 15, 2, 45, 3, 81, 32, 19 };

            Console.WriteLine("/*/**/ */*/*/*/*/*/*/*/*/*/");

            Array.Sort(friends);

            foreach (int i in friends)
            {
                Console.WriteLine(i);
            }
            #endregion
            //----------------------------------------------------------------------------




        }
    }
}