using System;
namespace SOLID.ISP
{
    public class Car : ICar
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
