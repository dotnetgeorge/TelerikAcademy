//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16)

using System;

class ConvertNumeralSystem
{
    static void Main(string[] args)
    {
        Console.Write("Number: ");
        string number = Console.ReadLine();

        int system = 0, convertToSystem = 0;

        do
        {
            Console.Write("Enter system ot number: ");
            system = int.Parse(Console.ReadLine()); 
        } while (system < 2);

        do
        {
            Console.Write("Enter system to convert number: ");
            convertToSystem = int.Parse(Console.ReadLine());
        } while (convertToSystem > 16);
        string result = null;
        switch (system)
        {
            case 2:
            case 10:
            case 16:
                result = Convert.ToString(Convert.ToInt32(number, system), convertToSystem);
                Console.WriteLine("Result: " + result);
                break;
            default:
                Console.WriteLine("Wrong!!! Try again!");
                break;
        }
    }
}