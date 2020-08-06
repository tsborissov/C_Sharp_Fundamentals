using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, Car> carsCollection = new Dictionary<string, Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCars = Console.ReadLine().Split('|').ToArray();

                string car = inputCars[0];
                int mileage = int.Parse(inputCars[1]);
                int fuel = int.Parse(inputCars[2]);

                carsCollection.Add(car, new Car(car, mileage, fuel));
            }

            while (true)
            {
                string commandRaw = Console.ReadLine();
                if (commandRaw == "Stop") { break; }

                string[] command = commandRaw.Split(" : ").ToArray();

                switch (command[0])
                {
                    
                    case "Drive":

                        string carToDrive = command[1];
                        int distanceToDrive = int.Parse(command[2]);
                        int fuelNeeded = int.Parse(command[3]);

                        if (carsCollection[carToDrive].Fuel < fuelNeeded)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                            break;
                        }
                        else
                        {
                            carsCollection[carToDrive].Mileage += distanceToDrive;
                            carsCollection[carToDrive].Fuel -= fuelNeeded;

                            Console.WriteLine($"{carToDrive} driven for {distanceToDrive} kilometers. {fuelNeeded} liters of fuel consumed.");
                        }

                        if (carsCollection[carToDrive].Mileage >= 100000)
                        {
                            carsCollection.Remove(carToDrive);
                            Console.WriteLine($"Time to sell the {carToDrive}!");
                        }

                        break;
                        

                    case "Refuel":

                        string carToRefuel = command[1];
                        int fuelQuantity = int.Parse(command[2]);
                        int exceesFuel = 0;
                                               
                        carsCollection[carToRefuel].Fuel += fuelQuantity;

                        if (carsCollection[carToRefuel].Fuel > 75)
                        {
                            exceesFuel = carsCollection[carToRefuel].Fuel - 75;
                            carsCollection[carToRefuel].Fuel = 75;
                            fuelQuantity -= exceesFuel;
                        }

                        Console.WriteLine($"{carToRefuel} refueled with {fuelQuantity} liters");

                        break;
                        

                    case "Revert":

                        string carToRevert = command[1];
                        int mileageToRevert = int.Parse(command[2]);

                        carsCollection[carToRevert].Mileage -= mileageToRevert;

                        if (carsCollection[carToRevert].Mileage < 10000)
                        {
                            carsCollection[carToRevert].Mileage = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{carToRevert} mileage decreased by {mileageToRevert} kilometers");
                        }

                        break;
                        
                }

            }

            foreach (var car in carsCollection.OrderByDescending(x => x.Value.Mileage).ThenBy(x => x.Value.CarModel))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }

        }
    }

    public class Car
    {
        public string CarModel { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }

        public Car(string car, int mileage, int fuel)
        {
            this.CarModel = car;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
    }
}
