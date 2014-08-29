//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer
using System;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            uint mask3 = 1 << 3;
            uint result3 = number & mask3;
            result3 >>= 3;
            uint mask24 = 1 << 24;
            uint result24 = number & mask24;
            result24 >>= 24;
            if (result24 == 1)
            {
                number |= mask3;
            }
            else
            {
                number &= (~mask3);
            }
            if (result3 == 1)
            {
                number |= mask24;
            }
            else
            {
                number &= (~mask24);
            }

            
            uint mask4 = 1 << 4;
            uint result4 = number & mask4;
            result4 >>= 4;
            uint mask25 = 1 << 25;
            uint result25 = number & mask25;
            result25 >>= 25;
            if (result25 == 1)
            {
                number |= mask4;
            }
            else
            {
                number &= (~mask4);
            }
            if (result4 == 1)
            {
                number |= mask25;
            }
            else
            {
                number &= (~mask25);
            }

            uint mask5 = 1 << 5;
            uint result5 = number & mask5;
            result5 >>= 5;
            uint mask26 = 1 << 26;
            uint result26 = number & mask26;
            result26 >>= 26;
            if (result26 == 1)
            {
                number |= mask5;
            }
            else
            {
                number &= (~mask5);
            }
            if (result5 == 1)
            {
                number |= mask26;
            }
            else
            {
                number &= (~mask26);
            }

            Console.WriteLine(number);
        }
    }
}
