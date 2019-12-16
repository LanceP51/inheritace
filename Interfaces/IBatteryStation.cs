using System;
using System.Collections.Generic;

namespace inheritances.Interfaces
{
    public interface IBatteryStation<T>{
         public int Capacity {get;set;}
        public void Recharge(List<T> ElectricVehicles);
    }
}