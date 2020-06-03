using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4.Models {
    class Bike : Vehicle {
        public Bike(float maxSpeed, int weightCapacity, decimal baggagePrice, decimal peoplePrice) 
            : base(maxSpeed, weightCapacity, baggagePrice, peoplePrice) 
        {}

        public override int PassangersCapacity => 1;

        public override decimal FuelPricePerKm => 0;

        public override string Type => "Bike";
    }
}
