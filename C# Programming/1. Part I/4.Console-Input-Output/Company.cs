//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string phone = Console.ReadLine();
            string fax = Console.ReadLine();
            string web = Console.ReadLine();
            string manager = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("---Company---\nName: {0}\nAddress: {1}\nPhone: {2}\nFax: {3}\nWeb: {4}\nManager: {5}", name, address, phone, fax, web, manager);
            Console.WriteLine("---Manager---\nFirst Name: {0}\nLast Name: {1}\nPhone: {2}", managerFirstName, managerLastName, managerPhone);
        }
    }
}
