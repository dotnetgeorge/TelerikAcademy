/*
 * Define abstract class Human with first name and last name. 
 * Define new class Student which is derived from Human and has new field – grade. 
 * Define class Worker derived from Human with new property
 * WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
 * that returns money earned by hour by the worker. 
 * Define the proper constructors and properties for this hierarchy. 
 * Initialize a list of 10 students and sort them by grade in ascending order
 * (use LINQ or OrderBy() extension method). 
 * Initialize a list of 10 workers and sort them by money per hour in descending order.
 * Merge the lists and sort them by first name and last name.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanProgram.Data;

namespace HumanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = AddStudents();
            students = SortStudents(students);
            ShowStudents(students);

            List<Worker> workers = AddWorkers();
            workers = SortWorkers(workers);
            ShowWorkers(workers);


        }

        public static List<Student> AddStudents()
        {
            List<Student> students = new List<Student>();
            Console.Write("Number of students: ");
            int studentsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsNumber; i++)
            {
                Console.Write("Student first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Student last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Grade: ");
                int grade = int.Parse(Console.ReadLine());
                students.Add(new Student(firstName, lastName, grade));
            }

            return students;
        }

        public static List<Student> SortStudents(List<Student> students)
        {
            return students.OrderBy(x => x.Grade).ToList<Student>();
        }

        public static void ShowStudents(List<Student> students)
        {
            Console.WriteLine("Students sorted by grades in ascending:");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static List<Worker> AddWorkers()
        {
            List<Worker> workers = new List<Worker>();
            Console.Write("Number of workers: ");
            int numberOfWorkers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfWorkers; i++)
            {
                Console.Write("Worker first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Worker last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Week salary: ");
                decimal weekSalary = decimal.Parse(Console.ReadLine());
                Console.Write("Work hours per day: ");
                decimal workHoursPerDay = decimal.Parse(Console.ReadLine());
                workers.Add(new Worker(firstName, lastName, weekSalary, workHoursPerDay));
            }

            return workers;
        }

        public static List<Worker> SortWorkers(List<Worker> workers)
        {
            return workers.OrderByDescending(x => x.MoneyPerHour()).ToList<Worker>();
        }

        public static void ShowWorkers(List<Worker> workers)
        {
            foreach (var item in workers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}