using System.Diagnostics.Metrics;

namespace _4._Bit_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int[] mask = new int[8];
            int newNomber = 0;
            int counter = 0;
            while (n > 0)
            {

                int currNumber = n % 2;
                n = n / 2;
                mask[mask.Length - 1 - counter] = currNumber;
                counter++;
            }
            mask[p] = 1;
            Console.WriteLine(String.Join("",mask));
        }
    }
}