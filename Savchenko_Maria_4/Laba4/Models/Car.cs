using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4.Models {
    class Car : Vehicle {
        public Car(float maxSpeed, int weightCapacity, decimal baggagePrice, decimal peoplePrice) 
         : base(maxSpeed, weightCapacity, baggagePrice, peoplePrice)   
        {}
        public override int PassangersCapacity => 4;

        public override decimal FuelPricePerKm => 21.85M;

        public override string Type => "Car";
    }
}
