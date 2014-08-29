//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/505
using System;

class AngryFemaleGPS
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        int even = 0;
        int odd = 0;

        if (number < 0)
        {
            number *= -1;
        }
        if (number == 0)
        {
            Console.WriteLine("straight 0");
        }
        else
        {

            while (number != 0)
            {
                long digit = number % 10;
                number /= 10;
                if (digit % 2 == 0)
                {
                    even += (int)digit;
                }
                else
                {
                    odd += (int)digit;
                }
            }
            if (even > odd)
            {
                Console.WriteLine("right {0}", even);
            }
            else if (odd > even)
            {
                Console.WriteLine("left {0}", odd);
            }
            else
            {
                Console.WriteLine("straight {0}", even);
            }
        }
    }
}
