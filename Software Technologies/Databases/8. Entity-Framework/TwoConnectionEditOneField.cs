/*
 * Try to open two different data contexts and perform concurrent changes on the same records.
 * What will happen at SaveChanges()? 
 * How to deal with it?
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindWork.Data;

namespace TwoConnectionEditOneField
{
    class TwoConnectionEditOneField
    {
        static void Main(string[] args)
        {
            FirstConnection();

            Console.WriteLine("Real Name of Company Name is: ");
            using (var northWind = new NorthwindEntities())
            {
                Console.Write(northWind.Customers.First().CompanyName);
            }
            Console.WriteLine();
        }

        public static void FirstConnection()
        {
            using (var northWind = new NorthwindEntities())
            {
                FirstSee(northWind);
                SecondConnection(northWind);
                FirstSeeAfterChanges(northWind);
            }
        }

        public static void SecondConnection(NorthwindEntities firstNorthWind)
        {
            using (var northWind = new NorthwindEntities())
            {
                SecondSee(northWind);
                firstNorthWind.SaveChangesAsync();
                northWind.SaveChangesAsync();
                SecondSeeAfterChanges(northWind);
            }
        }

        public static void FirstSee(NorthwindEntities northWind)
        {
            var companyName = northWind.Customers.First().CompanyName;
            northWind.Customers.Attach(northWind.Customers.First());
            Console.WriteLine("First See Company Name: " + companyName);
            companyName = "This is first test!";
            Console.WriteLine("Company Name Changed To: " + companyName);
        }

        public static void SecondSee(NorthwindEntities northWind)
        {
            var companyName = northWind.Customers.First().CompanyName;
            northWind.Customers.Attach(northWind.Customers.First());
            Console.WriteLine("Second See Company Name: " + companyName);
            companyName = "This is second test!"; 
            Console.WriteLine("Company Name Changed to: " + companyName);
        }

        public static void FirstSeeAfterChanges(NorthwindEntities northWind)
        {
            var companyName = northWind.Customers.First().CompanyName;
            Console.WriteLine("After Changes First See Company Name: " + companyName);
        }

        public static void SecondSeeAfterChanges(NorthwindEntities northWind)
        {
            var companyName = northWind.Customers.First().CompanyName;
            Console.WriteLine("After Changes Second See Company Name: " + companyName);
        }
    }
}
