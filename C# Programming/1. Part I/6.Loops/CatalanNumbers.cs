//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:


using System;
using System.Numerics;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                number = int.Parse(Console.ReadLine());
            } while (number <= 0);

            BigInteger firstFactorial = 1, secondFactorial = 1, thirdFactorial = 1;

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

            BigInteger sum = firstFactorial / secondFactorial * thirdFactorial;
            Console.WriteLine(sum);
        }
    }
}
