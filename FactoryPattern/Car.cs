using System;
namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {

        }

        public void Drive()
        {
            Console.WriteLine("The car has 4 tires");
            Console.WriteLine("beep beep");
        }
    }
}

