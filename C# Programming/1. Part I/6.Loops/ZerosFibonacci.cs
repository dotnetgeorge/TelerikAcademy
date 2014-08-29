/* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
	Does your program work for N = 50 000?
	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!*/


using System;
using System.Numerics;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            int zeroCount = 0;
            for (int i = 1; i <= (number / 5); i++)
            {
                if (factorial % 5 == 0)
                {
                    zeroCount++;
                }
            }
            Console.WriteLine(zeroCount);
        }
    }
}
