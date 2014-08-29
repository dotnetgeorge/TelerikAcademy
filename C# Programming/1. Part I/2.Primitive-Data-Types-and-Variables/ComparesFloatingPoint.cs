//Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = 5.3f;
            float secondNumber = 6.01f;
            Console.WriteLine(firstNumber == secondNumber ? "True" : "False");
            Console.ReadKey();
        }
    }
}
