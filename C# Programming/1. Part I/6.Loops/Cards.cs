//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.


using System;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Spades");
                        break;
                    case 2:
                        Console.WriteLine("Hearts");
                        break;
                    case 3:
                        Console.WriteLine("Diamonds");
                        break;
                    case 4:
                        Console.WriteLine("Clubs");
                        break;
                    default:
                        Console.WriteLine("ERROR!!!");
                        break;
                }
                for (int j = 1; j <= 13; j++)
                {
                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("Two");
                            break;
                        case 2:
                            Console.WriteLine("Three");
                            break;
                        case 3:
                            Console.WriteLine("Four");
                            break;
                        case 4:
                            Console.WriteLine("Five");
                            break;
                        case 5:
                            Console.WriteLine("Six");
                            break;
                        case 6:
                            Console.WriteLine("Seven");
                            break;
                        case 7:
                            Console.WriteLine("Eight");
                            break;
                        case 8:
                            Console.WriteLine("Nine");
                            break;
                        case 9:
                            Console.WriteLine("Ten");
                            break;
                        case 10:
                            Console.WriteLine("Jack");
                            break;
                        case 11:
                            Console.WriteLine("Queen");
                            break;
                        case 12:
                            Console.WriteLine("King");
                            break;
                        case 13:
                            Console.WriteLine("Ace");
                            break;
                        default:
                            Console.WriteLine("ERROR!!!");
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
