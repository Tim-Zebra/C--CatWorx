using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
    {
        static void Main(string[] args)
        {
            // This is our employee-getting code now
            List<Employee> employees = GetEmployees();

            PrintEmployees(employees);
        }

        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
                while (true)
                {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                Employee currentEmployee = new Employee(input, "Smith");
                // Add currentEmployee, not a string
                employees.Add(currentEmployee);
                }
            return employees;
        }
          static void PrintEmployees(List<Employee> employees)
            {
                for (int i = 0; i < employees.Count; i++) 
                {
                // each item in employees is now an Employee instance
                Console.WriteLine(employees[i].GetName());
                }
            }
    }
}