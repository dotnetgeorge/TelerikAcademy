/*
 * By inheriting the Employee entity class create a class which allows employees
 * to access their corresponding territories as property of type EntitySet<T>
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindWork.Data;

namespace ExtendEmployees
{
    class ExtendEmployees
    {
        static void Main(string[] args)
        {
            using (var northWind = new NorthwindEntities())
            {
                var territories = northWind.Employees.Include("Territories");
                foreach (var employee in territories)
                {
                    var allTerritories = employee.Territories.Select(x => x.TerritoryID);
                    var territoriesToString = String.Join(", ", allTerritories);
                    Console.WriteLine("Employee: '{0}' have territories id: '{1}'", employee.FirstName, territoriesToString);
                }
            }
        }
    }
}
