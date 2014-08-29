/*
 * Write a method that from a given array of students
 * finds all students whose first name is before 
 * its last name alphabetically.
 * Use LINQ query operators.
 */
using System;
using System.Linq;

class StudentsAlphabeticallyNames
{
    static void Main(string[] args)
    {
        var students = new[] 
        { 
            new {FirstName = "Joro", LastName = "Jorov"},
            new {FirstName = "Georgi", LastName = "Ivanov"},
            new {FirstName = "Ivan", LastName = "Georgiev"},
            new {FirstName = "Krasimir", LastName = "Stanchev"}
        };

        var query =
            from student in students
            where student.FirstName.CompareTo(student.LastName) == -1
            select student;

        foreach (var student in query)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}