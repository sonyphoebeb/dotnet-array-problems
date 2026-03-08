using System;
using System.Collections.Generic;

namespace DotnetArrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee { FirstName = "Sony", LastName = "Phoebe", Dob = "15-05-2002", Salary = 50000 },
                new Employee { FirstName = "Sowji", LastName = "Ch", Dob = "20-10-1990", Salary = 60000 },
                new Employee { FirstName = "Hima", LastName = "Prabha", Dob = "05-03-1985", Salary = 55000 },
                new Employee { FirstName = "Narendra", LastName = "S", Dob = "12-08-1995", Salary = 70000 },
            };

            /*
            int count = 1;

            foreach (Employee emp in listEmployees)
            {
           
                Console.WriteLine(count);
                Console.WriteLine("First Name: " + emp.FirstName);
                Console.WriteLine("Last Name: " + emp.LastName);
                Console.WriteLine("Date of Birth: " + emp.Dob);
                Console.WriteLine("Salary: " + emp.Salary);
                Console.WriteLine();

                count++;
            }
            */

            GetHighestSalary objGetHighestSalary = new GetHighestSalary();
            objGetHighestSalary.PrintHighestSalary(listEmployees);

        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }
        public decimal Salary { get; set; }

    }

}