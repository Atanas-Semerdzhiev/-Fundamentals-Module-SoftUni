using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int input = int.Parse(Console.ReadLine());
            string[] phrases1 = {"Excellent product.", "Such a great product.", "I always use thatproduct.", 
                "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events1 ={"Now I feel good.", "I have succeeded with this product.", "Makesmiracles. I am happy of the results!"
                    , "I cannot believe but now I feelawesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors1 = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities1 = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            for (int i = 0; i < input; i++)
            {


                string phrases = GetRandomWord(phrases1);
                string events = GetRandomWord(events1);
                string authors = GetRandomWord(authors1);
                string cities = GetRandomWord(cities1);


                Console.WriteLine($"{phrases} {events} {authors} – {cities}.");
            }
        }
        static string GetRandomWord(string[] text)
        {
        
            Random random = new Random();
            int randomindex = random.Next(0, text.Length);
            string word = text[randomindex];
            return word;

        }
    }
   
} 

 
