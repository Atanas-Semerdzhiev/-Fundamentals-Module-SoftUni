using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cityHouses = Console.ReadLine()
                .Split('@',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command;
            int lastPosition = 0;
            int curentIndex;
            int counter = 0;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] plaey = command.Split().ToArray();
                
                int jumpIndex = int.Parse(plaey[1]);
                curentIndex = jumpIndex + lastPosition;
                if ((curentIndex) >= cityHouses.Length  || curentIndex < 0)
                {
                    curentIndex = 0;
                }
                if (cityHouses[curentIndex] != 0)
                {               
                    
                        cityHouses[curentIndex] -= 2;

                    if (cityHouses[curentIndex] == 0)
                    {
                        Console.WriteLine($"Place {curentIndex} has Valentine's day.");
                     
                       counter++;
                    }


                   
                }
                else
                {
                    Console.WriteLine($"Place {curentIndex} already had Valentine's day.");
                }
                lastPosition = curentIndex;


            }
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            if (counter == cityHouses.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {cityHouses.Length - counter} places.");
            }
        }
    }
}
