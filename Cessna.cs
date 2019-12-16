using System;

namespace inheritances
{
    public class Cessna:Vehicle {  // Propellor light aircraft
    public double FuelCapacity { get; set; }
    // public void RefuelTank () { ... }
    public override void Drive () {
        Console.WriteLine($"the {MainColor} cessna goes Zoooooom!");
    }
}
}