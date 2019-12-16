using System;
using System.Collections.Generic;
using inheritances.Interfaces;

namespace inheritances
{
    public class GarysGas : IGasStation<Vehicle>
    {

        public int Capacity { get; set; }

        public void Refuel(List<Vehicle> GasVehicles)
        {
            Console.WriteLine("Your gas vehicles have been refueled.");
        }
    }
}
