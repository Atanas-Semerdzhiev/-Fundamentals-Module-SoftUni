using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nuberOfPeople = int.Parse(Console.ReadLine());
            string speciesGrup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double priceForOnePerson = 0;
            double sumPrice = 0;
            if (dayOfWeek == "Friday")
            {
                if (speciesGrup == "Students")
                {
                    priceForOnePerson = 8.45;
                    sumPrice = priceForOnePerson * nuberOfPeople;
                    if (nuberOfPeople >= 30)
                    {
                        sumPrice *= 0.85;
                    }
                }
                else if (speciesGrup == "Business")
                {
                    priceForOnePerson = 10.90;
                    if (nuberOfPeople >= 100)
                    {
                        nuberOfPeople -= 10;
                    }
                    sumPrice = priceForOnePerson * nuberOfPeople;

                }
                else if (speciesGrup == "Regular")
                {
                    priceForOnePerson = 15;
                    sumPrice = priceForOnePerson * nuberOfPeople;
                    if (nuberOfPeople >= 10 && nuberOfPeople <= 20)
                    {
                        sumPrice *= 0.95;
                    }
                }

            }
            else if (dayOfWeek == "Saturday")
            {
                if (speciesGrup == "Students")
                {
                    priceForOnePerson = 9.80;
                    sumPrice = priceForOnePerson * nuberOfPeople;
                    if (nuberOfPeople >= 30)
                    {
                        sumPrice *= 0.85;
                    }
                }
                else if (speciesGrup == "Business")
                {
                    priceForOnePerson = 15.60;
                    if (nuberOfPeople >= 100)
                    {
                        nuberOfPeople -= 10;
                    }
                    sumPrice = priceForOnePerson * nuberOfPeople;
                }
                else if (speciesGrup == "Regular")
                {
                    priceForOnePerson = 20;
                    sumPrice = priceForOnePerson * nuberOfPeople;
                    if (nuberOfPeople >= 10 && nuberOfPeople <= 20)
                    {
                        sumPrice *= 0.95;
                    }
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (speciesGrup == "Students")
                {
                    priceForOnePerson = 10.46;
                    sumPrice = priceForOnePerson * nuberOfPeople;
                    if (nuberOfPeople >= 30)
                    {
                        sumPrice *= 0.85;
                    }
                }
                else if (speciesGrup == "Business")
                {
                    priceForOnePerson = 16;
                    if (nuberOfPeople >= 100)
                    {
                        nuberOfPeople -= 10;
                    }
                    sumPrice = priceForOnePerson * nuberOfPeople;
                }
                else if (speciesGrup == "Regular")
                {
                    priceForOnePerson = 22.50;
                    sumPrice = priceForOnePerson * nuberOfPeople;
                    if (nuberOfPeople >= 10 && nuberOfPeople <= 20)
                    {
                        sumPrice *= 0.95;
                    }
                }
            }
            Console.WriteLine($"Total price: {sumPrice:f2}");
        }
    }
}
