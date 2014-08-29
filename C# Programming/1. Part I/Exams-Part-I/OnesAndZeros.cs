//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/498
using System;

class BinaryDigits
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int row = 0; row <= 4; row++)
        {
            for (int bit = 15; bit >= 0; bit--)
            {
                bool isOne = ((1 << bit) & number) > 0;
                if (isOne)
                {
                    switch (row)
                    {
                        case 0:
                        case 2:
                        case 3:
                            Console.Write(".#.");
                            break;
                        case 1:
                            Console.Write("##.");
                            break;
                        case 4:
                            Console.Write("###");
                            break;
                    }
                }
                else
                {
                    switch (row)
                    {
                        case 0:
                        case 4:
                            Console.Write("###");
                            break;
                        case 1:
                        case 2:
                        case 3:
                            Console.Write("#.#");
                            break;
                    }
                }

                if (bit > 0)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
