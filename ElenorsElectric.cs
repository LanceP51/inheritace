using System;
using System.Collections.Generic;
using inheritances.Interfaces;

namespace inheritances
{
    public class ElenorsElectric : IBatteryStation<Vehicle>
    {
        public int Capacity { get; set; }

        public void Recharge(List<Vehicle> ElectricVehicles)
        {
            Console.WriteLine("You electric vehicles have been recharged.");
        }
    }
}