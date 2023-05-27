namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CatalogueVehicle> vehicles = new List<CatalogueVehicle>();
            string vehicleInfo;
            double carsHP = 0;
            double truckHP = 0;
            double carsCounter = 0;
            double truckCounter = 0;
            while ((vehicleInfo = Console.ReadLine()) !="End")
            {
                string[] info = vehicleInfo.Split(" ").ToArray();
                string typeOfVehicle = info[0];
                string model = info[1];
                string color = info[2];
                double horsePower = double.Parse(info[3]);
                if(typeOfVehicle == "car")
                {
                    CatalogueVehicle car = new CatalogueVehicle(typeOfVehicle, model, color, horsePower);
                    vehicles.Add(car);
                    carsHP += horsePower;
                    carsCounter++;
                }
                else if(typeOfVehicle == "truck")
                {
                    CatalogueVehicle truc = new CatalogueVehicle(typeOfVehicle, model, color,horsePower);
                    vehicles.Add(truc);
                    truckHP += horsePower;
                    truckCounter++;
                }
            }
            string modelVehicle;
            while ((modelVehicle = Console.ReadLine()) != "Close the Catalogue")
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    CatalogueVehicle vehicle = vehicles[i];
                    
                    if(vehicle.Model== modelVehicle)
                    {
                        if(vehicle.TypeOfVehicle == "car")
                        {
                            Console.WriteLine($"Type: Car");
                        }
                        else
                        {
                            Console.WriteLine($"Type: Truck");
                        }
                       // Console.WriteLine($"Type: {vehicle.TypeOfVehicle.}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                      
                    }
                }
            }
            if (carsHP == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            else
            {
                double carHorsePower = carsHP / carsCounter;
                Console.WriteLine($"Cars have average horsepower of: {carHorsePower:f2}.");
            }
            if (truckHP == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else
            {
                double truckHorsePower = truckHP / truckCounter;
                Console.WriteLine($"Trucks have average horsepower of: {truckHorsePower:f2}.");
            }
        }
    }
   
    public class CatalogueVehicle
    {
        public CatalogueVehicle(string typeOfVehicle ,string model, string color, double horsepower)
        {
            TypeOfVehicle = typeOfVehicle;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }
}