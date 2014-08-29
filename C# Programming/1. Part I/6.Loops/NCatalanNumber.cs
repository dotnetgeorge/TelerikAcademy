//Write a program to calculate the Nth Catalan number by given N.


using System;
using System.Numerics;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstFactorial = 1, secondFactorial = 1, thirdFactorial = 1, sum = 0, result = 0;
            int number;
            
            do
            {
                number = int.Parse(Console.ReadLine());
            } while (number <= 0);

            for (int i = 1; i <= (2 * number); i++)
            {
                firstFactorial *= i;
            }
            for (int i = 1; i <= (number + 1); i++)
            {
                secondFactorial *= i;
            }
            for (int i = 1; i <= number; i++)
            {
                thirdFactorial *= i;
            }
            sum = firstFactorial / secondFactorial * thirdFactorial;
            for (int i = 1; i <= number; i++)
            {
                result += sum * sum;
            }
            Console.WriteLine(result);
        }
    }
}
