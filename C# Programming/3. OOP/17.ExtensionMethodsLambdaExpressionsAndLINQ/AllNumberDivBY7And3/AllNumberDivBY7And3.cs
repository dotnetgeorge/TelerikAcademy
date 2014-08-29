/*
 * Write a program that prints from given array of integers 
 * all numbers that are divisible by 7 and 3.
 * Use the built-in extension methods and lambda expressions. 
 * Rewrite the same with LINQ.
 */

using System;
using System.Linq;
using System.Collections.Generic;

class AllNumberDivBY7And3
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21 };

        //Lambda expression
        //var result = list.Where(x => (x % 3 == 0) && (x % 7 == 0));

        //LINQ
        var result =
            from numbers in list
            where (numbers % 3 == 0) && (numbers % 7 == 0)
            select numbers;


        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
