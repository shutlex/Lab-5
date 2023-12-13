using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TransportNetwork
    {
        private List<Vehicle> vehicles;

        public TransportNetwork()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void MoveVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

        public void CalculateOptimalRoute(Route route, Vehicle vehicle)
        {
            Console.WriteLine($"Calculating optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}...");
            
        }

        public void PassengerBoarding(Human passenger, Vehicle vehicle)
        {
            Console.WriteLine($"Passenger is boarding {vehicle.GetType().Name}...");
            
        }

        public void PassengerDisembarking(Human passenger, Vehicle vehicle)
        {
            Console.WriteLine($"Passenger is disembarking from {vehicle.GetType().Name}...");
            
        }
    }

}
