using System;

namespace _09._Spice_Must_Flow__not_included_in_final_score_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yieldOfDay = double.Parse(Console.ReadLine());
            double dayCounter = 0;
            double sumYield = 0;
            double leftYield = 0;
            if (yieldOfDay > 99)
            {


                while (yieldOfDay >= 100)
                {
                    dayCounter++;


                    sumYield += yieldOfDay;
                    yieldOfDay -= 10;
                }
                double sumLeftYield = (dayCounter * 26);
                double finalsum = sumYield - sumLeftYield;
                Console.WriteLine(dayCounter);
                Console.WriteLine(finalsum - 26);
            }
            else
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
        }
    }
}
