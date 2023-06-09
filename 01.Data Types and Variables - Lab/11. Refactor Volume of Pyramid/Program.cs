using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());

            double Width = double.Parse(Console.ReadLine());

            double Height = double.Parse(Console.ReadLine());
            double V = 0;
            V = ((length * Width) * Height) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {V:f2}");
        }
    }
}
