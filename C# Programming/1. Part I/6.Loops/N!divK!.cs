//Write a program that calculates N!/K! for given N and K (1<K<N).


using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberK = int.Parse(Console.ReadLine());

            do
            {
                numberK = int.Parse(Console.ReadLine());
            } while (1 > numberK);
            do
            {
                numberN = int.Parse(Console.ReadLine());
            } while (numberK > numberN);
            long factorialN = 1, factorialK = 1;
            for (int i = 1; i <= factorialN; i++)
            {
                factorialN *= i;
            }
            for (int i = 1; i <= numberK; i++)
            {
                factorialK *= i;
            }

            long result = factorialN / factorialK;
            Console.WriteLine(result);
        }
    }
}
