//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (first > second)
            {
                int temp = first;
                first = second;
                second = temp;
            }

            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
