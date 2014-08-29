//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());

            bool inRectangle = (pointX <= 1) && (pointX >= -1) && (pointY >= -1) && (pointY <= 5);
            bool inCircle = (pointX * pointX) + (pointY * pointY) <= (3 * 3);

            if (inRectangle && inCircle)
            {
                Console.WriteLine("In circle and rectangle.");
            }
            else if (inRectangle && !inCircle)
            {
                Console.WriteLine("In rectangle and outside circle.");
            }
            else if (!inRectangle && inCircle)
            {
                Console.WriteLine("In circle and outside rectangle.");
            }
            else
            {
                Console.WriteLine("Outside rectangle and circle.");
            }
        }
    }
}
