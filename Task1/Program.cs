using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Прохоренко Олександр";
            TransportNetwork transportNetwork = new TransportNetwork();

            Car car = new Car();
            Bus bus = new Bus();
            Train train = new Train();

            transportNetwork.AddVehicle(car);
            transportNetwork.AddVehicle(bus);
            transportNetwork.AddVehicle(train);

            transportNetwork.MoveVehicles();

            Route route = new Route("City A", "City B");
            transportNetwork.CalculateOptimalRoute(route, car);

            Human passenger = new Human { Speed = 5 };
            transportNetwork.PassengerBoarding(passenger, bus);

            Console.ReadLine();
        }
    }
}
