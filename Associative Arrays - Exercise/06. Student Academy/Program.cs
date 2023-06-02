namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> studentMembers = new Dictionary<string, double[]>();
            int numberStudent = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberStudent; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentMembers.ContainsKey(studentName))
                {
              //      studentMembers[studentName] = new List<double>();
                    studentMembers.Add(studentName, new double[2]);
                }
                studentMembers[studentName][0] += 1;
                studentMembers[studentName][1] += grade;
         
            }
            foreach (var kvp in studentMembers)
            {
                if (kvp.Value[1] / kvp.Value[0] >=4.5)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value[1] / kvp.Value[0]:f2}");
                }
              
            }
        }
    }
}