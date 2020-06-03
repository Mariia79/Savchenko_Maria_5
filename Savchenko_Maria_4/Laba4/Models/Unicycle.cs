using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4.Models {
    class Unicycle : Vehicle {
        public Unicycle(float maxSpeed, int weightCapacity, decimal baggagePrice, decimal peoplePrice) 
            : base(maxSpeed, weightCapacity, baggagePrice, peoplePrice) 
        {}

        public override int PassangersCapacity => 0;

        public override decimal FuelPricePerKm => 0;

        public override string Type => "Unicycle";
    }
}
