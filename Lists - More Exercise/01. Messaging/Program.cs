using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> integer = Console.ReadLine().Split(" ").ToList();


            List<char> stringList = new List<char>();
            stringList.AddRange(Console.ReadLine());



            string wantToSee = string.Empty;
            for (int i = 0; i < integer.Count; i++)
            {
                string curentInteger = integer[i];

                int sum = 0;
                for (int j = 0; j < curentInteger.Length; j++)
                {
                    sum += curentInteger[j] - 48;

                }
                int neededIndex = sum;
                while (neededIndex > stringList.Count)
                {
                    neededIndex -= stringList.Count;
                }
                for (int j = 0; j < stringList.Count; j++)
                {
                    if (j == neededIndex)
                    {

                        wantToSee += stringList[j];
                        stringList.RemoveAt(j);

                        break;
                    }


                }

            }
            Console.WriteLine(wantToSee);
        }
    }
}
