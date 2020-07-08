using System;
namespace SOLID.ISP
{
    public class MultiFunctionalCar : ICar, IAirplane
    {
        public MultiFunctionalCar()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}
