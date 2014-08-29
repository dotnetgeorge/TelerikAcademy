/*
 * Using the extension methods OrderBy() and ThenBy()
 * with lambda expressions sort the students by first name and last name
 * in descending order. Rewrite the same with LINQ.
 */
using System;
using System.Linq;


class SortStudentsInDescendingOrder
{
    static void Main(string[] args)
    {
        var students = new[] 
        {
            new {FirstName = "Joro", LastName = "Jorov", Age = 17},
            new {FirstName = "Georgi", LastName = "Asparuhov", Age = 18},
            new {FirstName = "Mihaela", LastName = "Fileva", Age = 21},
            new {FirstName = "Petkan", LastName = "Draganov", Age = 20},
            new {FirstName = "Dragan", LastName = "Petkanov", Age = 30},
            new {FirstName = "Stoqn", LastName = "Dilov", Age = 24},
            new {FirstName = "Boqn", LastName = "Cankov", Age = 19},
            new {FirstName = "Deqn", LastName = "Bojkov", Age = 25},
            new {FirstName = "Stanka", LastName = "Zlateva", Age = 18},
            new {FirstName = "Tanq", LastName = "Ruseva", Age = 22},
        };

        //Program with Lambda expressions
        //var result = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

        //foreach (var student in result)
        //{
        //    Console.WriteLine(student.FirstName + " " + student.LastName);
        //}

        var result =
            from student in students
            orderby student.FirstName descending, student.LastName descending
            select student;

        foreach (var student in result)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }

    }
}