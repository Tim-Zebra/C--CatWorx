using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
    {
        static void Main(string[] args)
        {
            // This is our employee-getting code now
            List<Employee> employees = PeopleFetcher.GetEmployees();

            // Prints list of employees
            Util.PrintEmployees(employees);
            // Saves list of employees
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }


    }
}