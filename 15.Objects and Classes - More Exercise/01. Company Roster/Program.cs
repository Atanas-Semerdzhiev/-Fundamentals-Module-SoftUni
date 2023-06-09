using System.Security.Cryptography.X509Certificates;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // List<Employee> employees = new List<Employee>();
            List <Department> departments = new List<Department>();
            int numberEnplyee = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberEnplyee; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split(" ");
               
                if (!departments.Any(d => d.DepartamentName == employeeInfo[2]))
                {
                    departments.Add(new Department(employeeInfo[2]));
                }
                departments.Find(d => d.DepartamentName == employeeInfo[2]).AddNewEmployee(employeeInfo[0], decimal.Parse(employeeInfo[1]));
            }


            Department bestDepartment = departments.OrderByDescending(d => d.TotalSalary / d.employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartamentName}");

            foreach (var employee in bestDepartment.employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }

     
    }
     class Employee
    {
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
     
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
     
    }
     class Department
    {
        public List<Employee> employees { get; set; } = new List<Employee>();
        public string DepartamentName { get; set; }
        public decimal TotalSalary { get; set; }
        public void AddNewEmployee(string employee,decimal salary)
        {
            this.TotalSalary += salary;
            this.employees.Add(new Employee(employee, salary));
        }
        public Department (string departName)
        {
            this.DepartamentName = departName;
        }



    }
}