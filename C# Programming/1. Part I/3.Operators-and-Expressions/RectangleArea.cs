//Write an expression that calculates rectangle’s area by given width and height.

using System;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = (width * 2) + (height * 2);
            Console.WriteLine(area);
        }
    }
}
