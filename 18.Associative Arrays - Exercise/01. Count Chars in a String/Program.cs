namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int > charMembers = new Dictionary<char, int>();
            string[] startInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < startInput.Length; i++)
            {
                string inputString = startInput[i];
                for (int j = 0; j < inputString.Length; j++)
                {
                    char currChar = inputString[j];
                    if (!charMembers.ContainsKey(currChar))
                    {
                        charMembers.Add(currChar, 0);
                    }
                    charMembers[currChar] += 1;

                }
            }
           
            foreach (var item in charMembers)
            {
               
              
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                
                
            }
        }
    }
}