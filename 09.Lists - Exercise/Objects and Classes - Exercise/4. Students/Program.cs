using System.Collections.Generic;
using System.Diagnostics;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> ollStudents = new List<Students>();
            int nuberOfStudent = int.Parse(Console.ReadLine());
            for (int i = 0; i < nuberOfStudent; i++)
            {
                string[] curentStudent = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = curentStudent[0];
                string lastName = curentStudent[1];
                double avarageGrade = double.Parse(curentStudent[2]);
                Students student = new Students(name, lastName, avarageGrade);
                ollStudents.Add(student);
            }
            List<Students> sortStudent = ollStudents.OrderByDescending(x => x.AvarageGrade).ToList();
           // sortStudent.Reverse();
            foreach (Students student in sortStudent)
            {
                Console.WriteLine($"{student.Name} {student.LastName}: {student.AvarageGrade:f2}");
            }
        }
    }
    public class Students
    {
        public Students(string name, string lastName, double avarageGrade)
        {
            Name = name;
            LastName = lastName;
            AvarageGrade = avarageGrade;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public double AvarageGrade { get; set; }
    }
}