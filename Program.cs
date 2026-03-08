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

            
            PrintEmployeeDetails objPrintEmployeeDetails = new PrintEmployeeDetails();
            objPrintEmployeeDetails.DisplayEmployees(listEmployees);

            Console.WriteLine();
            GetHighestSalary objGetHighestSalary = new GetHighestSalary();
            objGetHighestSalary.PrintHighestSalary(listEmployees);

            Console.WriteLine();
            GetSecondHighestSalary objGetSecondHighestSalary = new GetSecondHighestSalary();
            objGetSecondHighestSalary.PrintSecondHighestSalary(listEmployees);

            Console.WriteLine();
            GetLowestSalary objGetLowestSalary = new GetLowestSalary();
            objGetLowestSalary.DisplayLowestSlary(listEmployees);

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