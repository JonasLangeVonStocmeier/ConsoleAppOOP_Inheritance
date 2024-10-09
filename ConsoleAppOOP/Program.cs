using OOP_ConsoleApp;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Car car = new Car()
        {
            Acceleration = 100,
            DoorCount = 5,
            BreakSpeed = 50,
            Speed = 200
        };

        Plane plane = new Plane()
        {
            Acceleration = 500,
            DoorCount = 10,
            BreakSpeed = 200,
            Speed = 600,
            HasJetEngine = true
        };

        Motorcycle motorcycle = new Motorcycle()
        {
            Acceleration = 250,
            DoorCount = 0,
            BreakSpeed = 25,
            Speed = 350
        };

        Helicopter helicopter = new Helicopter()
        {
            Acceleration = 250,
            DoorCount = 0,
            BreakSpeed = 25,
            Speed = 350
        };

        vehicles.Add(car);
        vehicles.Add(plane);
        vehicles.Add(motorcycle);
        vehicles.Add(helicopter);

        Console.WriteLine("What vehicle do you want to use: ");
        var userInput = Console.ReadLine();

        foreach (Vehicle vehicle in vehicles)
        {
            if (vehicle.GetType().Name == userInput)
            {
                Console.WriteLine("Vehicle found: " + userInput);
                vehicle.LogInformation();

                if(userInput == nameof(Car))
                {
                    Car myCar = vehicle as Car;
                    myCar.Move();
                }else if(userInput == nameof(Plane))
                {
                    Plane myPlane = vehicle as Plane;
                    myPlane.Move();
                    myPlane.Landing();
                }
                else if(userInput == nameof(Motorcycle))
                {
                    Motorcycle myMotorcycle = vehicle as Motorcycle;
                    myMotorcycle.Move();
                }
                else if (userInput == nameof(Helicopter))
                {
                    Helicopter myHelicopter = vehicle as Helicopter;
                    myHelicopter.Landing();
                }
                else
                {
                    Console.WriteLine("This vehicle is not ready.");
                }

                break;
            }
        }



    }
}