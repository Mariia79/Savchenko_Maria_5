using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4.Models {
    abstract class Vehicle {
        public abstract string Type { get; }
        public abstract int PassangersCapacity { get; }
        public abstract decimal FuelPricePerKm { get; }

        public int WeightCapacity { get; protected set; }
        public float MaxSpeed { get; protected set; }

        public decimal TransportBaggagePricePerKm { get; set; }
        public decimal TransportPeoplePricePerKm { get; set; }

        public Vehicle(float maxSpeed, int weightCapacity, decimal baggagePrice, decimal peoplePrice) {
            this.MaxSpeed = maxSpeed;
            this.WeightCapacity = weightCapacity;
            this.TransportBaggagePricePerKm = baggagePrice;
            this.TransportPeoplePricePerKm = peoplePrice;
        }
        public decimal GetSumToTransportPassengers(int passengers, decimal distanceKM = 1) {
            if (passengers > PassangersCapacity)
                throw new ArgumentOutOfRangeException("Too many passengers!");
            return (FuelPricePerKm + TransportPeoplePricePerKm) * distanceKM;
        }
        public decimal GetSumToTransportBaggage(int weight, decimal distanceKM = 1) {
            if (weight > WeightCapacity)
                throw new ArgumentOutOfRangeException("Too much weight!");
            return ((weight / (decimal)WeightCapacity) * TransportBaggagePricePerKm) * distanceKM;
        }
        public decimal GetSumToTransportPassengersWithBaggage(int passengers, int weight, decimal distanceKM = 1) {
            return GetSumToTransportPassengers(passengers, distanceKM) + 
                    GetSumToTransportBaggage(weight, distanceKM);
        }
        public float GetTimeToTransport(float distance) => distance / MaxSpeed;
    }
}
