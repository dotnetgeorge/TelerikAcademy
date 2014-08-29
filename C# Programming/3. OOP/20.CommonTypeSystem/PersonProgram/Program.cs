/*
 * Create a class Person with two fields – name and age. 
 * Age can be left unspecified (may contain null value. 
 * Override ToString() to display the information of a person 
 * and if age is not specified – to say so. Write a program to test this functionality.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonProgram.Data;

namespace PersonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.ToString());
            person.Name = "Joro Petkoff";
            Console.WriteLine(person.ToString());
            person.Age = 19;
            Console.WriteLine(person.ToString());
        }
    }
}
