//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/440
using System;

class DrunkenNumbers
{
    static void Main(string[] args)
    {
        int mitko = 0, vladko = 0;
        int number;
        do
        {
            number = int.Parse(Console.ReadLine());
        } while (1 > number && number > 100);

        for (int i = 0; i < number; i++)
        {
            int drunkenNumber = int.Parse(Console.ReadLine());
            string digits = Math.Abs(drunkenNumber).ToString();
            for (int j = 0; j < digits.Length; j++)
            {
                if (j < digits.Length / 2)
                {
                    mitko += digits[j] - 48;
                }
                else
                {
                    vladko += digits[j] - 48;
                }
            }

            if (digits.Length % 2 != 0)
            {
                mitko += digits[digits.Length / 2] - 48;
            }
        }

        if (mitko > vladko)
        {
            Console.WriteLine("M " + (mitko - vladko));
        }
        else if (vladko > mitko)
        {
            Console.WriteLine("V " + (vladko - mitko));
        }
        else
        {
            Console.WriteLine("No " + (mitko + vladko));
        }
    }
}
