/*
 * Define a class InvalidRangeException<T> that holds information 
 * about an error condition related to invalid range. 
 * It should hold error message and a range definition [start … end].
 * Write a sample application that demonstrates the InvalidRangeException<int>
 * and InvalidRangeException<DateTime> by entering numbers in the range [1..100]
 * and dates in the range [1.1.1980 … 31.12.2013].
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeptionProgram.Data;
using System.Globalization;

namespace ExeptionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            IntTest();
            DateTest();
        }

        public static void IntTest()
        {
            Console.Write("Write number: ");
            int number = int.Parse(Console.ReadLine());
            InvalidRangeException<int> ire = new InvalidRangeException<int>("Accepted range is between 1 and 100!", 1, 100);
            if (number < ire.Start || number > ire.End)
            {
                throw ire;
            }
        }

        public static void DateTest()
        {
            Console.Write("Enter date in format dd.mm.yyyy: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", CultureInfo.InvariantCulture);

            InvalidRangeException<DateTime> ire = new InvalidRangeException<DateTime>("Accepted range is between 1.1.1980 and 31.12.2013!", DateTime.Parse("01.01.1980"), DateTime.Parse("31.12.2013"));
            if (date.Year < ire.Start.Year || date.Year > ire.End.Year)
            {
                throw ire;
            }
        }
    }
}
