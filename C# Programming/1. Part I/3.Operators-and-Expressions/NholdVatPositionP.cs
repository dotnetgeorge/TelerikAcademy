/*
We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	n = 5 (00000101), p=2, v=0  1 (00000001)

*/
using System;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bit = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int result = 0;
            if (bit == 1)
            {
                result = number | mask;
            }
            else
            {
                result = number & (~mask);
            }
            Console.WriteLine(bit + "\n" + result);
        }
    }
}
