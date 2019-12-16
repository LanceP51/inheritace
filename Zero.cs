using System;
namespace inheritances
{


    public class Zero:Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }
        // public void ChargeBattery() { ... }
        public override void Drive () {
        Console.WriteLine($"the {MainColor} zero goes zeerrrereee!");
    }
    }
}