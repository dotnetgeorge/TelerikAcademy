using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProgram.Data;

namespace SchoolProgram
{
    class Program
    {
        public static Student student;

        static void Main(string[] args)
        {
            Console.Write("School name: ");
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);
            school = AddClasses(school);
            foreach (var item in school.Classes)
            {
                item.ShowClass();
            }
        }

        public static School AddClasses(School school)
        {
            Console.Write("Number of classes: ");
            int numberOfClasses = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfClasses; i++)
            {
                Console.Write("Class identifier: ");
                char identifier = char.Parse(Console.ReadLine());
                school.AddClass(identifier);
                Console.Write("Number of students in this class: ");
                int numberOfStudentsInClass = int.Parse(Console.ReadLine());
                for (int k = 0; k < numberOfStudentsInClass; k++)
                {
                    Console.Write("Student name: ");
                    string studentName = Console.ReadLine();
                    Console.Write("Student number in class: ");
                    int numberInClass = int.Parse(Console.ReadLine());
                    school.AddStudent(studentName, numberInClass);
                }
            }

            return school;
        }
    }
}
