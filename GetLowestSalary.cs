using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetArrayProblems
{
    internal class GetLowestSalary
    {
        public void DisplayLowestSlary(List<Employee> listEmployees)
        {
            Employee lowestSalaryEmployee = listEmployees[0];

            foreach (Employee emp in listEmployees)
            {
                if (emp.Salary < lowestSalaryEmployee.Salary)
                {
                    lowestSalaryEmployee = emp;
                }
            }
            Console.WriteLine("Employee with Lowest Salary:");
            Console.WriteLine("First Name: " + lowestSalaryEmployee.FirstName);
            Console.WriteLine("Last Name: " + lowestSalaryEmployee.LastName);
            Console.WriteLine("DOB: " + lowestSalaryEmployee.Dob);
            Console.WriteLine("Salary: " + lowestSalaryEmployee.Salary);
        }
    }
}
