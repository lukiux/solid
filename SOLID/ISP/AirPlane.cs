using System;
namespace SOLID.ISP
{
    public class AirPlane : IAirplane
    {
        public AirPlane()
        {
        }

        public void Fly()
        {
            Console.WriteLine("Flying a plane");
        }
    }
}
