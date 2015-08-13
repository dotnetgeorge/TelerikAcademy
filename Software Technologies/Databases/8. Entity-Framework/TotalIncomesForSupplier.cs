/*
 * Create a stored procedures in the Northwind database for finding the total incomes
 * for given supplier name and period (start date, end date). 
 * Implement a C# method that calls the stored procedure and returns the retuned record set.
 */
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using NorthwindWork.Data;

namespace TotalIncomesForSupplier
{
    class TotalIncomesForSupplier
    {
        static void Main(string[] args)
        {

            Console.Write("Supplier Name: ");
            string supplierName = Console.ReadLine();
            Console.Write("/dd-MM-yyyy/ Start Date: ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.Write("/dd-MM-yyyy/ End Date: ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            using (var northWind = new NorthwindEntities())
            {
                var totalIncomes = northWind.ups_TotalIncomes(supplierName, startDate, endDate).Sum();

                Console.WriteLine("Supplier '{0}' Between Period '{1}' And '{2}' Have Total Incomes '${3:F2}'", supplierName, startDate.ToShortDateString(), endDate.ToShortDateString(), totalIncomes);
            }
        }
    }
}
