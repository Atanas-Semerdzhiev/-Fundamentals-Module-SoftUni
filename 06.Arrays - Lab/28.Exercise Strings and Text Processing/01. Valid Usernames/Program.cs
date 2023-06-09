namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputUserName = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            bool isNotChar = false;
            foreach (var user in inputUserName)
            {
                if (user.Length > 3 && user.Length < 16)
                {
                    foreach (var currChar in user)
                    {

                        if (!Char.IsLetterOrDigit(currChar))
                        {
                            isNotChar = true;
                        }
                        if (currChar == '-' || currChar == '_')
                        {
                            isNotChar = false;
                        }
                    }
                    if (isNotChar == false)
                    {
                        Console.WriteLine(user);
                    }
                }
              

               

                isNotChar = false;
            }
        }
    }
}