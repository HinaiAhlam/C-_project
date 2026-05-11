using System;

namespace project01
{
    // =========================
    // Parent Class Example
    // =========================

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    class Cat : Animal
    {
        public void Sound()
        {
            Console.WriteLine("Meow");
        }
    }


    // =========================
    // Interface Example
    // =========================

    interface IAnimal
    {
        void Run();
    }

    class Dog : IAnimal
    {
        public void Run()
        {
            Console.WriteLine("Dog is Running");
        }
    }


    // =========================
    // Main
    // =========================

    class Program
    {
        static void Main(string[] args)
        {
            // Object with Parent Class
            Animal a = new Cat();

            a.Eat();

            // -------------------------

            // Object with Interface
            IAnimal d = new Dog();

            d.Run();
        }
    }
}