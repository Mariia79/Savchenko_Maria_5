using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4.Models {
    class Cart : Vehicle {
        public Cart(float maxSpeed, int weightCapacity, decimal baggagePrice, decimal peoplePrice)
            : base(maxSpeed, weightCapacity, baggagePrice, peoplePrice) 
        {}

        public override int PassangersCapacity => 7;

        public override decimal FuelPricePerKm { get; } = 5.0M; // Seno

        public override string Type => "Cart";
    }
}
