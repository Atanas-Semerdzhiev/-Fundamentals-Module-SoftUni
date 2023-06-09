namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Cargo> cargo = new List<Cargo>();
            int numberCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ");
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Car newCar = new Car(model,engineSpeed,enginePower,cargoWeight,cargoType);
                cars.Add(newCar);
               

            }
            string comandType = Console.ReadLine();
            foreach (Car car in cars)
            {
                if (car.CargoType == "fragile" && car.CargoWeight <1000)
                {
                    Console.WriteLine($"{car.Model}");
                }
                else if (car.CargoType == "flamable" && car.EnginePower > 250)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }

      
    }
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            Model = model;
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
            CargoWeight = cargoWeight;
            CargoType = cargoType;
            AddCargo();
        }

        private void AddCargo()
        {
            Cargo curentCargo = new Cargo(CargoWeight, CargoType);
           
            
        }

     

        public string Model { get; set; }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get; set; }
        public string CargoType { get; set;}
    }
}