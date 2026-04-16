Console.WriteLine("Please Enter First Number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Second Number:");
int num2 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2;
int diff = num1 - num2; 
int product = num1 * num2; 
int quotient = num1 / num2; 

Console.WriteLine("---------- Results ----------");
Console.WriteLine($"{num1} + {num2} = {sum}");
Console.WriteLine($"{num1} - {num2} = {diff}");
Console.WriteLine($"{num1} * {num2} = {product}");
Console.WriteLine($"{num1} / {num2} = {quotient}");
Console.WriteLine("-----------------------------");