using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                string dataOfType = "";
                if (input == "END")
                {
                    break;
                }

                try
                {
                    int num = int.Parse(input);
                    dataOfType = "integer";
                }
                catch (FormatException)
                {
                    try
                    {
                        double num = double.Parse(input);
                        dataOfType = "floating point";
                    }
                    catch (FormatException)
                    {
                        try
                        {
                            char number = char.Parse(input);
                            dataOfType = "character";
                        }
                        catch (FormatException)
                        {
                            try
                            {
                                bool number = bool.Parse(input);
                                dataOfType = "boolean";
                            }
                            catch (FormatException)
                            {
                                dataOfType = "string";
                            }
                        }
                    }
                }
                Console.WriteLine($"{input} is {dataOfType} type");
            }
        }
    }
}
