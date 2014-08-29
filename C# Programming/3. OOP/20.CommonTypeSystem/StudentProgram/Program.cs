using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProgram.Data;

namespace StudentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fill info about first student.");
            Student firstStudent = CreateStudent();

            Console.WriteLine("Fill info about second student.");
            Student secondStudent = CreateStudent();

            Console.WriteLine("Equals test\n" + firstStudent.Equals(secondStudent));
            Console.WriteLine("GetHashCode test for first student\n" + firstStudent.GetHashCode());
            Console.WriteLine("GetHashCode test for second student\n" + secondStudent.GetHashCode());
            Console.WriteLine("ToString test for first student\n" + firstStudent.ToString());
            Console.WriteLine("ToString test for second student\n" + secondStudent.ToString());
            Console.WriteLine("== test\n{0}", (firstStudent == secondStudent));
            Console.WriteLine("!= test\n{0}", (firstStudent != secondStudent));

            Student clone = firstStudent.Clone();
            Console.WriteLine("Clone test for first user\n" + clone.ToString());
            Console.WriteLine("CompareTo test\n" + firstStudent.CompareTo(secondStudent));
        }

        public static Student CreateStudent()
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("SSN: ");
            string ssn = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Clear();

            UniversityType university = University();
            Console.Clear();

            FacultiesType faculty = Faculty();
            Console.Clear();

            SpecialityType speciality = Speciality();
            Console.Clear();

            Student student = new Student(firstName, middleName, lastName, ssn, address, phoneNumber, email, speciality, university, faculty);

            return student;
        }

        public static UniversityType University()
        {
            UniversityType university = new UniversityType();
            int choice = 0;
            do
            {
                Console.WriteLine("Choose university");
                Console.WriteLine("1. TU");
                Console.WriteLine("2. SU");
                Console.WriteLine("3. NBU");
                Console.WriteLine("4. UNSS");
                Console.Write("Your choice");
                choice = int.Parse(Console.ReadLine());
            } while (choice < 1 || choice > 4);

            switch (choice)
            {
                case 1:
                    university = UniversityType.TU;
                    break;
                case 2:
                    university = UniversityType.SU;
                    break;
                case 3:
                    university = UniversityType.NBU;
                    break;
                case 4:
                    university = UniversityType.UNSS;
                    break;
            }

            return university;
        }

        public static FacultiesType Faculty()
        {
            FacultiesType faculty = new FacultiesType();
            int choice = 0;

            do
            {
                Console.WriteLine("Choose faculty");
                Console.WriteLine("1. Mathematics");
                Console.WriteLine("2. Law");
                Console.WriteLine("3. Business");
                Console.WriteLine("4. Philosophy");
                Console.WriteLine("5. Phisics");
                Console.WriteLine("6. Management");
                Console.WriteLine("7. Telecommunications");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
            } while (choice < 1 || choice > 7);

            switch (choice)
            {
                case 1:
                    faculty = FacultiesType.Mathematics;
                    break;
                case 2:
                    faculty = FacultiesType.Law;
                    break;
                case 3:
                    faculty = FacultiesType.Business;
                    break;
                case 4:
                    faculty = FacultiesType.Philosophy;
                    break;
                case 5:
                    faculty = FacultiesType.Phisics;
                    break;
                case 6:
                    faculty = FacultiesType.Management;
                    break;
                case 7:
                    faculty = FacultiesType.Telecommunications;
                    break;
            }

            return faculty;
        }

        public static SpecialityType Speciality()
        {
            SpecialityType speciality = new SpecialityType();
            int choice = 0;

            do
            {
                Console.WriteLine("Choose speciality");
                Console.WriteLine("1. Marketing");
                Console.WriteLine("2. Business");
                Console.WriteLine("3. Enterpreneurship");
                Console.WriteLine("4. Phisics");
                Console.WriteLine("5. Mathematics");
                Console.WriteLine("6. Telecommunications");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
            } while (choice < 1 || choice > 6);

            switch (choice)
            {

                case 1:
                    speciality = SpecialityType.Marketing;
                    break;
                case 2:
                    speciality = SpecialityType.Business;
                    break;
                case 3:
                    speciality = SpecialityType.Enterpreneurship;
                    break;
                case 4:
                    speciality = SpecialityType.Phisics;
                    break;
                case 5:
                    speciality = SpecialityType.Mathematics;
                    break;
                case 6:
                    speciality = SpecialityType.Telecommunications;
                    break;
            }

            return speciality;
        }
    }
}
