using System;
namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive ()
        {
            Console.WriteLine("The motorcycle has 2 tires");
            Console.WriteLine("Vroom"); 
        }
    }
}

