using System;

namespace inheritances
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"the {MainColor} vehicle goes Vrooom!");
        }
    }
}