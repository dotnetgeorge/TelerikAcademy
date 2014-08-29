/*
 * You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum. 
 * Example:
 * string = "43 68 9 23 318" -> result = 461
 */
using System;

class StringToIntSum
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Numbers:");
            string numbers = Console.ReadLine();
            int result = Sum(numbers);
            Console.WriteLine(result);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
    }

    static int Sum(string numbers)
    {
        char[] pattern = new char[]{' ', ',', '.', '!', '+'};
        string[] elements = numbers.Split(pattern, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            sum += Convert.ToInt32(elements[i]);
        }
        return sum;
    }
}