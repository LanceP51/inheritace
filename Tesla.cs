using System;

namespace inheritances
{


    public class Tesla:Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }
        // public void ChargeBattery() { ... }
        public override void Drive () {
        Console.WriteLine($"the {MainColor} tesla goes mmmmnnmmmnmm!");
    }
    }
}