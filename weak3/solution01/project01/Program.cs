

#region 1
//class Program
//{
//    static void Main()
//    {
//        Sum3(10, 20, 30);
//        Mult4(2, 2, 2, 2);
//        Sum5(1, 1, 1, 1, 1);
//    }

//    static void Sum3(double a, double b, double c)
//    {
//        Console.WriteLine("Sum: " + (a + b + c));
//    }

//    static void Mult4(double a, double b, double c, double d)
//    {
//        Console.WriteLine("Product: " + (a * b * c * d));
//    }

//    static void Sum5(double a, double b, double c, double d, double e)
//    {
//        Console.WriteLine("Sum: " + (a + b + c + d + e));
//    }
//}
#endregion




#region 2
class Program
{
    static void Main()
    {
        Sum(10, 20);
        Mult(2, 2, 2);
        Sum(1, 1);
    }

    static void Sum(double a, double b)
    {
        Console.WriteLine("Sum: " + (a + b ));
    }

    static void Mult(double a, double b, double c)
    {
        Console.WriteLine("Product: " + (a * b * c ));
    }

    static void Sum(int a, double b)
    {
        Console.WriteLine("Sum: " + (a + b  ));
    }
}


#endregion
