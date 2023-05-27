namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string infoPerson;
            while ((infoPerson = Console.ReadLine()) != "End")
            {
                string[] splitInfo = infoPerson.Split(" ");
                string namePerson = splitInfo[0];
                string iDPerson = splitInfo[1];
                int age = int.Parse(splitInfo[2]);
                if(IDPersonExiste( persons, iDPerson))
                {
                   Person curentPerson = persons.First(p => p.IDPerson == iDPerson);
                    curentPerson.NamePerson = namePerson;
                    curentPerson.Age = age;
                }
                else
                {
                    Person newPerson = new Person (namePerson, iDPerson, age);
                    persons.Add(newPerson);
                }

            }
            List<Person> orderedPerson = persons.OrderBy(p => p.Age).ToList();
            foreach(Person person in orderedPerson)
            {
                Console.WriteLine($"{person.NamePerson} with ID: {person.IDPerson} is {person.Age} years old.");
            }
        }
        static bool IDPersonExiste(List<Person> persons, string ID)
        {
            return persons.Any(p => p.IDPerson == ID);
        }
    }
  
    public class Person
    {
        public Person(string namePerson, string iDPerson, int age)
        {
            NamePerson = namePerson;
            IDPerson = iDPerson;
            Age = age;
        }

        public string NamePerson { get; set; }
        public string IDPerson { get; set; }
        public int Age { get; set; }
    }

}