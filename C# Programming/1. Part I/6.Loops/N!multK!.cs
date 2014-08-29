//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).


using System;
using System.Numerics;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN, numberK;
            BigInteger factorialN = 1, factorialK = 1, factorialNK = 1;

            do
            {
                numberN = int.Parse(Console.ReadLine());
            } while (numberN < 1);
            
            do
            {
                numberK = int.Parse(Console.ReadLine());
            } while (numberK < numberN);

            for (int i = 1; i <= numberN; i++)
            {
                factorialN *= i;
            }

            for (int i = 1; i <= numberK; i++)
            {
                factorialK *= i;
            }

            for (int i = 1; i <= (numberK - numberN); i++)
            {
                factorialNK *= i;
            }

            BigInteger sum = factorialN * factorialK / factorialNK;
            Console.WriteLine(sum);
        }
    }
}
