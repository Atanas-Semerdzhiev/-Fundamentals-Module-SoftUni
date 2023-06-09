using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogueVehicle catalogue = new CatalogueVehicle();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] vehicleInfo = input.Split("/");
                string vehicleTipy = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];
                int velue =int.Parse( vehicleInfo[3]); // Hp or Weight
                if (vehicleTipy =="Truck")
                {
                    Truck truck = new Truck(brand, model, velue);
                    catalogue.Trucks.Add(truck);
                }
                else
                {
                    Car car = new Car(brand, model, velue);
                    catalogue.Cars.Add(car);
                }
            }
            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }
            foreach (var car in catalogue.Cars
                .OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }
            foreach(var truck in catalogue.Trucks
                .OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    public class CatalogueVehicle
    {
        public CatalogueVehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set;}
        public string Model { get; set;}
        public int Weight { get; set;}
    }
}