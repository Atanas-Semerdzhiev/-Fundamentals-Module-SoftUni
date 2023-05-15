using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double speckarsPrice = double.Parse(Console.ReadLine()); //2
            double mousePrice = double.Parse(Console.ReadLine());    //3
            double keyboardPrice = double.Parse(Console.ReadLine()); //6
            double displayPrice = double.Parse(Console.ReadLine());  // 12


            double sumSpeckars = (lostGames / 2) * speckarsPrice;
            double sumMouse = (lostGames / 3) * mousePrice;
            double sumKeyboard = (lostGames / 6) * keyboardPrice;
            double sumDisplay = (lostGames / 12) * displayPrice;
            double totalSum = sumSpeckars + sumMouse + sumKeyboard + sumDisplay;
            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}
