using System;
using System.Collections.Generic;
using System.Linq;


namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();


            string vehicleData;

            while ((vehicleData = Console.ReadLine()) != "End")
            {
                string[] newVehicle = vehicleData.Split().ToArray();

                vehicles.Add(new Vehicle(newVehicle[0], newVehicle[1], newVehicle[2], int.Parse(newVehicle[3])));
            }


            string model;

            while ((model = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.Find(x => x.Model == model));
            }


            if (vehicles.Exists(x => x.TypeOfVehicle == "Car"))
            {
                double carsHorsepowerAverage = vehicles.Where(x => x.TypeOfVehicle == "Car").Average(x => x.Horsepower);
                Console.WriteLine($"Cars have average horsepower of: {carsHorsepowerAverage:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (vehicles.Exists(x => x.TypeOfVehicle == "Truck"))
            {
                double trucksHorsepowerAverage = vehicles.Where(x => x.TypeOfVehicle == "Truck").Average(x => x.Horsepower);
                Console.WriteLine($"Trucks have average horsepower of: {trucksHorsepowerAverage:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }                                                                                                                                                                                                                                                                   

    public class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string typeOfVehicle, string model, string color, int horsepower)
        {
            this.TypeOfVehicle = CapitalizeFirstLetter(typeOfVehicle);
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public override string ToString()
        {
            return $"Type: {TypeOfVehicle}{Environment.NewLine}" +
                $"Model: {Model}{Environment.NewLine}" +
                $"Color: {Color}{Environment.NewLine}" +
                $"Horsepower: {Horsepower}";
        }

        public static string CapitalizeFirstLetter(string str)
        {

            return char.ToUpper(str[0]) + str.Substring(1);

        }
    }
}
