namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string> > softUniCourses = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commArg = input.Split(" : ");
                string coursName = commArg[0];
                string studentName = commArg[1];
                if (!softUniCourses.ContainsKey(coursName))
                {
                    softUniCourses[coursName] = new List<string>();
                    //softUniCourses[coursName].Add(studentName);
                }
                             
                    softUniCourses[coursName].Add( studentName);               
            }
            foreach (var kvp in softUniCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var studentName in kvp.Value)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}