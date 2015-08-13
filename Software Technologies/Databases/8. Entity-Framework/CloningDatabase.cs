/*
 * Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext. 
 * Find for the API for schema generation in MSDN or in Google.
 */
using System;
using NorthwindWork.Data;

namespace CloningDatabase
{
    class CloningDatabase
    {
        static void Main(string[] args)
        {
            using (var northWind = new NorthwindEntities())
            {
                try
                {
                    northWind.Database.CreateIfNotExists();
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error occured: " + ex.InnerException.Message);
                }
            }
        }
    }
}
