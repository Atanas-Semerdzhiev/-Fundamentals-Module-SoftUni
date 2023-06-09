using System;

namespace _10._Poke_Mon__not_included_in_final_score_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powerIntegerN = int.Parse(Console.ReadLine());
            int distanceIntegerM = int.Parse(Console.ReadLine());
            int factorIntegerY = int.Parse(Console.ReadLine());
            int counterPoket = 0;
            double furstValueN = powerIntegerN;

            while (powerIntegerN >= distanceIntegerM)
            {
                powerIntegerN -= distanceIntegerM;
                counterPoket++;
                if (furstValueN / 2 == powerIntegerN && factorIntegerY != 0)
                {


                    powerIntegerN = powerIntegerN / factorIntegerY;


                }
            }

            Console.WriteLine(powerIntegerN);
            Console.WriteLine(counterPoket);
        }
    }
}
