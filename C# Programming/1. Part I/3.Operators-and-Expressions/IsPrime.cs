//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime
using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int loopEnd = (int)Math.Sqrt(number);
            
            bool result = true;
            int count = 2;
            while (loopEnd >= count)
            {
                if (number % count == 0)
                {
                    result = false;
                    break;
                }
                count++;
            }
            Console.WriteLine(result ? "Prime" : "Not Prime");
        }
    }
}
