using System;
using System.Collections.Generic;
using inheritances.Interfaces;


namespace inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna C130 = new Cessna(){
                FuelCapacity = 100.00, MainColor = "white", MaximumOccupancy="26"
            };
            Ram Lariat = new Ram(){
                FuelCapacity = 20.00, MainColor = "yellow", MaximumOccupancy="4"
            };
            Tesla modelS = new Tesla(){
                BatteryKWh= 75.00, MainColor = "black", MaximumOccupancy="4"
            };
            Zero fx = new Zero(){
                BatteryKWh=70.00, MainColor = "blue", MaximumOccupancy="6"
            };

            fx.Drive();
            modelS.Drive();
            Lariat.Drive();
            C130.Drive();

            // make list of gas and electric cars
            List<Vehicle> GasVehicles = new List<Vehicle>(){
                Lariat, C130
            };
            List<Vehicle> ElectricVehicles = new List<Vehicle>(){
                modelS, fx
            };

            // make a gas and electric station instance
            ElenorsElectric Station1 = new ElenorsElectric(){
                Capacity=6
            };
            GarysGas Station2 = new GarysGas(){
                Capacity=10
            };

            // send the vehicles to correct stations
            Station1.Recharge(ElectricVehicles);
            Station2.Refuel(GasVehicles);
Console.WriteLine();
        }
    }
}
