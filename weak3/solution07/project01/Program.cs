
class Program
{
    static void Main(string[] args)
    {
        Child myChild = new Child();

        Console.WriteLine("--- Testing Object-Oriented Logic ---");

        myChild.FunctionOne();

        Console.WriteLine("\n--- Testing Overridden Functions ---");

        myChild.FunctionTwo();

        Console.WriteLine("\n--- Testing Overridden Functions ---");

        myChild.FunctionThree();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

public class Parent
{
    public void FunctionOne()
    {
        Console.WriteLine("Parent: Standard Logic");
    }

    public virtual void FunctionTwo()
    {
        Console.WriteLine("Parent: Virtual Logic A");
    }

    public virtual void FunctionThree()
    {
        Console.WriteLine("Parent: Virtual Logic B");
    }
}

public class Child : Parent
{
    public override void FunctionTwo()
    {
        base.FunctionTwo(); 
        Console.WriteLine("Child: New Logic for Function Two");
    }

    public override void FunctionThree()
    {
        base.FunctionThree(); 
        Console.WriteLine("Child: New Logic for Function Three");
    }
}