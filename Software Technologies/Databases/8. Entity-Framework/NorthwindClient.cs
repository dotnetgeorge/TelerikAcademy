/*
 * Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database
 */
using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindWork.Data;

namespace NorthwindClient
{
    class NorthwindClient
    {
        static void Main(string[] args)
        {
            var northWind = new NorthwindEntities();

            using (northWind)
            {
                var employees = northWind.Employees.Where(x => x.Country == "USA").Select(x => x.FirstName + " " + x.LastName);

                Console.WriteLine("All employees from USA:");
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}
