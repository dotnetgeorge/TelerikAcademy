//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberX = int.Parse(Console.ReadLine());
            int numberY = int.Parse(Console.ReadLine());

            if ((0 <= numberX) && (numberX <= 5) && (0 <= numberY) && (numberY <= 5))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
