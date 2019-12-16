using System;
using System.Collections.Generic;

namespace inheritances.Interfaces
{
    public interface IGasStation<T>{
        public int Capacity {get;set;}
        public void Refuel(List<T> GasVehicles);
    }
}
