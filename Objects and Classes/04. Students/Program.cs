using System.Security.Cryptography.X509Certificates;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudent = new List<Student>();
            string student;
            bool isSame = false;
            while ((student=Console.ReadLine()) !="end")
            {
                List<string> curentStudent = new List<string>();
                curentStudent = student.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                string firstName = curentStudent[0];
                string lastName = curentStudent[1];
                int age = int.Parse(curentStudent[2]);
                string homeTowne = curentStudent[3];

                Student newStudent = new Student(firstName, lastName, age, homeTowne);
                      
             
                    listStudent.Add(newStudent);
                           
            }
            string towneName = Console.ReadLine();
            for (int i = 0; i < listStudent.Count; i++)
            {
                Student curentStudent = listStudent[i];
                if(curentStudent.HomeTowne == towneName)
                {
                    Console.WriteLine($"{curentStudent.FirstName} {curentStudent.LastName} is {curentStudent.Age} years old.");
                }
            }
        }

     
    }
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTowne)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTowne = homeTowne;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTowne { get; set; }

    }  
}