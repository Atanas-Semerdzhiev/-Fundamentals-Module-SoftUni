using Oldest_Family_Member;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace Oldest_Family_Member
{
    internal class Program
    {
        public static object AddMember { get; private set; }

        static void Main(string[] args)
        {
           
            List <Family> familyMembers = new List <Family> ();
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string[] memberInfo = Console.ReadLine().Split(" ");
                string memberName = memberInfo[0];
                int memberAge = int.Parse(memberInfo[1]);
               // Person member = new Person(memberName, memberAge);
                Family curentMember = new Family(memberName, memberAge);
                familyMembers.Add(curentMember);
               

            }

            familyMembers.OrderByDescending(x => x.Age);

            foreach (Family f in familyMembers)
            {
                Console.WriteLine($"{f.Name} ");
                Console.WriteLine($"{f.Age}");
            }

           
        }


    }
  
    public class Family
    {
      

        //  private List<Family> membersFamily;

        public Family(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

      
    }

}