using System;

namespace S2_L2__T1_Sharpwasher
{
    class Program
    {
        delegate void Wa(Car car);
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("'True' means that the car is clean, 'False' - the car is dirty.");
            Garage garage = new Garage();
            Car car1 = new Car("Dodge Charger");
            Car car2 = new Car("Lada Kalina");
            Car car3 = new Car("Tesla");
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);
            foreach (var car in garage)
            {
                Console.WriteLine(car.name + " " + car.clean);
            }
            Console.WriteLine("Your order is being done...");
            foreach (var car in garage)
            {
                Washer washer = new Washer();
                Wa del = washer.Wash;
                del(car);
                Console.WriteLine(car.name + " " + car.clean);
            }
            Console.ReadKey();  
        }
    }
}
