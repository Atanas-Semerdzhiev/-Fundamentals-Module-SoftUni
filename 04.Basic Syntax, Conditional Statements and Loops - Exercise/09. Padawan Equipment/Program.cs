using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentNumber = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double numberNeedLightsabers = Math.Ceiling(studentNumber * 0.10);
            double caculatedLightsabers = (numberNeedLightsabers + studentNumber) * priceLightsabers;

            int needBelts = studentNumber - (studentNumber / 6);
            double caculatedSumBelts = needBelts * priceBelts;
            double caculatedSumRobes = priceRobes * studentNumber;
            double finalPrice = caculatedLightsabers + caculatedSumBelts + caculatedSumRobes;
            if (budget >= finalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
            }
            else if (budget < finalPrice)
            {
                double needeMoney = finalPrice - budget;
                Console.WriteLine($"John will need {needeMoney:f2}lv more.");
            }
        }
    }
}
