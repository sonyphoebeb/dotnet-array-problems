using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetArrayProblems
{
    internal class PrintEmployeeDetails
    {
        public void DisplayEmployees(List<Employee> listEmployees)
        {
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
        }
    }
}
