
internal class Program
{
    class Car
    {
        private int temp;

        public int Speed
        {
            get { return temp; }
            set
            {
                if (value > 0)
                {
                    temp = value;
                }
            }
        }

        public void Drive()
        {
            Console.WriteLine("Driving...");
        }
    }

    static void Main(string[] args)
    {
        Car my_car = new Car();
        my_car.Speed = 400;
        Console.WriteLine(my_car.Speed);
    }
}