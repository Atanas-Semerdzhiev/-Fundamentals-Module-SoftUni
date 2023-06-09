namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberCar = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCar; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ");
                string brand = carInfo[0];
                double fuellAmount = double.Parse(carInfo[1]);
                double fuelConsumationFor1km = double.Parse(carInfo[2]);
                double amountFor1km = 0;
                Car curentCar = new Car(brand, fuellAmount,fuelConsumationFor1km,amountFor1km);
                cars.Add(curentCar);
            }
            string newCar;
            while ((newCar = Console.ReadLine()) != "End")
            {
                string[] newCarInfo = newCar.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string brand = newCarInfo[1];
                double amountFor1km = double.Parse(newCarInfo[2]);
              //  AmountFor1km( cars, brand, amountFor1km);
                for (int i = 0;i < cars.Count; i++)
                {
                  
                    if (cars[i].Brand == brand)
                    {
                        if (cars[i].FuellAmount < amountFor1km * cars[i].FuelConsumptionFor1km )
                        {
                            Console.WriteLine("Insufficient fuel for the drive") ;
                        }
                        else
                        {
                            cars[i].FuellAmount -= amountFor1km * cars[i].FuelConsumptionFor1km;
                            cars[i].AmountFor1km += amountFor1km;
                        }
                        
                    }
                }
                
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Brand} {car.FuellAmount:F2} {car.AmountFor1km}");
            }
        }
        public void AmountFor1km(List<Car>cars, string brand, double amountFor1km)
        {

        }
    }
    class Car
    {
        public Car(string brand, double fullAmount, double fuelConsumptionFor1km, double amountFor1km)
        {
            Brand = brand;
            FuellAmount = fullAmount;
            FuelConsumptionFor1km = fuelConsumptionFor1km;
            AmountFor1km = amountFor1km;
        }
        public double AmountFor1km { get; set; }    
        public string Brand { get; set; }
        public double FuellAmount { get; set; }
        public double FuelConsumptionFor1km { get; set;}
    }
}