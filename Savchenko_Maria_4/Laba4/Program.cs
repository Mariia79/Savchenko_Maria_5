using System;
using System.Collections.Generic;
using Laba4.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4 {
    class Program {
        static void Main(string[] args) {
            decimal Distance = 10.0M, baggagePrice = 50.0M, peoplePrice = 20.0M;
            int Weight = 9, passengers = 1;
            List<Vehicle> vehicles = new List<Vehicle>() {
                new Car(60, 500, baggagePrice, peoplePrice),
                new Cart(7, 500, baggagePrice, peoplePrice),
                new Bike(15, 75, baggagePrice, peoplePrice),
                new Unicycle(5, 10, baggagePrice, 0)
            };
            foreach (var vehicle in vehicles) {
                Console.WriteLine(
                    $"Prices for {vehicle.Type}: \n" +
                    $"Transport {Weight} baggage for {Distance} Km: {vehicle.GetSumToTransportBaggage(Weight, Distance)}\n" +
                    $"Transport {passengers} passengers: {vehicle.GetSumToTransportPassengers(passengers, Distance)}\n" +
                    $"Transport {Weight} baggage of {passengers} passengers: {vehicle.GetSumToTransportPassengersWithBaggage(passengers, Weight, Distance)}\n" +
                    $"Minimal time: {Math.Round(vehicle.GetTimeToTransport((float)Distance), 1)} hours\n" +
                    "--------------------------------");
            }
            Console.ReadKey();
        }
    }
}
