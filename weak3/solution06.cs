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