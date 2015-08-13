/*
 * Using Entity Framework write a SQL query to select all employees from the Telerik Academy database 
 * and later print their name, department and town. 
 * Try the both variants: with and without .Include(…). 
 * Compare the number of executed SQL statements and the performance.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using TelerikAcademy;

namespace FirstTask
{
    class FirstTask
    {
        static void Main(string[] args)
        {
            WithInclude();

            WithoutInclude();
        }

        public static void WithInclude()
        {
            using (var telerikAcademy = new TelerikAcademyDB())
            {
                telerikAcademy.Employees.Count();

                Stopwatch sw = new Stopwatch();
                sw.Start();

                var employees = telerikAcademy.Employees.Include("Address.Town").Include("Department");
                
                Console.WriteLine(sw.Elapsed);
                sw.Restart();

                Console.WriteLine("Full Name\t Department Name\t Town Name");
                foreach (var employee in telerikAcademy.Employees.Include("Address.Town").Include("Department"))
                {
                    Console.WriteLine("{0} {1}\t {2}\t {3}", employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
                }

                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void WithoutInclude()
        {
            using (var telerikAcademy = new TelerikAcademyDB())
            {
                telerikAcademy.Employees.Count();

                Stopwatch sw = new Stopwatch();
                sw.Start();

                var employees = telerikAcademy.Employees;
                Console.WriteLine(sw.Elapsed);

                sw.Restart();

                Console.WriteLine("Full Name\t Department Name\t Town Name");
                foreach (var employee in telerikAcademy.Employees)
                {
                    Console.WriteLine("{0} {1}\t {2}\t {3}", employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
                }

                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
