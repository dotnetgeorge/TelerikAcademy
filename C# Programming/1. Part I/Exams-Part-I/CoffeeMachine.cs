//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/439
using System;

class CoffeeMachine
{
    static void Main(string[] args)
    {
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        double n4 = double.Parse(Console.ReadLine());
        double n5 = double.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double money = (0.05 * n1) + (0.1 * n2) + (0.2 * n3) + (0.5 * n4) + (1 * n5);
 
        if ((a > p) && (money >= (a-p)))
        {
            Console.WriteLine("Yes {0:F2}", money - (a - p));
        }
        else if (a < p)
        {
            Console.WriteLine("More {0:F2}", (p - a));
        }
        else if ((a >= p) && money < (a - p))
        {
            Console.WriteLine("No {0:F2}", (a - p) - money);
        }
    }
}
