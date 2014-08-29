//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/1
using System;

class CartesianCoordinateSystem
{
    static void Main(string[] args)
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());

        if (pointX == 0 && pointY == 0)
        {
            Console.WriteLine("0");
        }
        else if (pointX > 0 && pointY > 0)
        {
            Console.WriteLine("1");
        }
        else if (pointX < 0 && pointY > 0)
        {
            Console.WriteLine("2");
        }
        else if (pointX < 0 && pointY < 0)
        {
            Console.WriteLine("3");
        }
        else if (pointX > 0 && pointY < 0)
        {
            Console.WriteLine("4");
        }
        else if (pointX == 0 && pointY > 0)
        {
            Console.WriteLine("5");
        }
        else
        {
            Console.WriteLine("6");
        }
    }
}
