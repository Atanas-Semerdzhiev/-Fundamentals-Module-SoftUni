using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemon = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int sum = 0;
            bool isSame = false;
            while (pokemon.Count > 0)
            {
                int doIndex = int.Parse(Console.ReadLine());

                int velue = 0;
                int sumVelue = 0;

                CheckIndex(pokemon, ref doIndex, ref velue, ref sumVelue, ref sum);




                for (int i = 0; i < pokemon.Count; i++)
                {
                    if (pokemon[i] <= velue)
                    {
                        if (pokemon[i] == velue)
                        {
                            isSame = true;
                        }
                        pokemon[i] += velue;
                    }
                    else if (pokemon[i] > velue)
                    {
                        pokemon[i] -= velue;
                    }
                }
                if (doIndex >= 0 && doIndex <= pokemon.Count - 1)
                {

                    sum += sumVelue;



                    pokemon.RemoveAt(doIndex);

                }

            }
            Console.WriteLine(sum);

        }

        private static void CheckIndex(List<int> pokemon, ref int doIndex, ref int velue, ref int sumVelue, ref int sum)
        {
            if (doIndex < 0)
            {
                velue = pokemon[0];
                pokemon[0] = pokemon[pokemon.Count - 1];
                sumVelue = velue;
                sum += sumVelue;
            }
            else if (doIndex >= 0 && doIndex <= pokemon.Count - 1)
            {
                velue = pokemon[doIndex];
                sumVelue = pokemon[doIndex];
            }
            if (doIndex > pokemon.Count - 1)
            {

                velue = pokemon[pokemon.Count - 1];
                pokemon[pokemon.Count - 1] = pokemon[0];
                sumVelue = velue;
                sum += sumVelue;
            }
        }
    }
}
