/*
 * Write a LINQ query that finds 
 * the first name and last name of all students 
 * with age between 18 and 24.
 */
using System;
using System.Linq;


class Program
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

        var query =
            from student in students
            where student.Age >= 18 & student.Age <= 24
            select student;

        foreach (var student in query)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}