//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

using System;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 128; i++)
            {
                char c = (char)i;

                string display = string.Empty;
                if (char.IsWhiteSpace(c))
                {
                    display = c.ToString();
                    switch (c)
                    {
                        case '\t':
                            Console.WriteLine("\\t");
                            break;
                        case ' ':
                            Console.WriteLine("space");
                            break;
                        case '\n':
                            Console.WriteLine("\\n");
                            break;
                        case '\r':
                            Console.WriteLine("\\r");
                            break;
                        case '\v':
                            Console.WriteLine("\\v");
                            break;
                        case '\f':
                            Console.WriteLine("\\f");
                            break;
                        default:
                            break;
                    }
                }
                else if (char.IsControl(c))
                {
                    display = "control";
                }
                else
                {
                    display = c.ToString();
                }
                Console.WriteLine(display);
            }
        }
    }
}
