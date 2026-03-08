using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetArrayProblems
{
    internal class GetHighestSalary
    {
        public void PrintHighestSalary(List<Employee> listEmployees)
        {
            Employee highestSalaryEmployee = listEmployees[0];

            foreach (Employee emp in listEmployees)
            {
                if (emp.Salary > highestSalaryEmployee.Salary)
                {
                    highestSalaryEmployee = emp;
                }
            }

            Console.WriteLine("Employee with Highest Salary:");
            Console.WriteLine("First Name: " + highestSalaryEmployee.FirstName);
            Console.WriteLine("Last Name: " + highestSalaryEmployee.LastName);
            Console.WriteLine("DOB: " + highestSalaryEmployee.Dob);
            Console.WriteLine("Salary: " + highestSalaryEmployee.Salary);
        }

    }
}
