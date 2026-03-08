using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DotnetArrayProblems
{
    internal class GetSecondHighestSalary
    {
        public void PrintSecondHighestSalary(List<Employee> listEmployees)
        {
            Employee highestSalary = null;
            Employee secondHighestSalary = null;

            foreach (Employee emp in listEmployees)
            {
                if (highestSalary == null || emp.Salary > highestSalary.Salary)
                {
                    secondHighestSalary = highestSalary;
                    highestSalary = emp;
                }

                else if (secondHighestSalary == null || emp.Salary > secondHighestSalary.Salary)
                {
                    secondHighestSalary = emp;
                }
            }

            Console.WriteLine("Employee with Second Highest Salary:");
            Console.WriteLine("First Name: " + secondHighestSalary.FirstName);
            Console.WriteLine("Last Name: " + secondHighestSalary.LastName);
            Console.WriteLine("DOB: " + secondHighestSalary.Dob);
            Console.WriteLine("Salary: " + secondHighestSalary.Salary);
        }
    }
}
