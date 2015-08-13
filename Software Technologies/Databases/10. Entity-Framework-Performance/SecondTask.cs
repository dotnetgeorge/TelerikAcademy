/*
 * Using Entity Framework write a query that selects all employees from the Telerik Academy database, 
 * then invokes ToList(), then selects their addresses, then invokes ToList(), then selects their towns, 
 * then invokes ToList() and finally checks whether the town is "Sofia". 
 * Rewrite the same in more optimized way and compare the performance.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TelerikAcademy;

namespace SecondTask
{
    class SecondTask
    {
        static void Main(string[] args)
        {
            SlowVersion();
            FastVersion();
        }

        public static void SlowVersion()
        {
            using (var telerikAcademy = new TelerikAcademyDB())
            {
                telerikAcademy.Employees.Count();

                var sw = new Stopwatch();
                sw.Start();
                var employees = telerikAcademy.Employees.ToList().Select(empl => empl.Address).Select(address => address.Town).ToList().Where(city => city.Name == "Sofia").ToList();
                Console.WriteLine(sw.Elapsed);
                sw.Stop();
                Console.WriteLine("Count of employees in Sofia: " + employees.Count);
            }
        }

        public static void FastVersion()
        {
            using (var telerikAcademy = new TelerikAcademyDB())
            {
                telerikAcademy.Employees.Count();

                var sw = new Stopwatch();
                sw.Start();
                var employees = telerikAcademy.Employees.Select(empl => empl.Address).Select(address => address.Town).Where(city => city.Name == "Sofia");
                Console.WriteLine(sw.Elapsed);
                sw.Stop();
                Console.WriteLine("Count of employees in Sofia: " + employees.Count());
            }
        }
    }
}
