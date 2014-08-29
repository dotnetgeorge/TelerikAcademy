//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/4
using System;

class BinaryDigitsCount
{
    static void Main(string[] args)
    {
        int binarySearch = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int count = 0;

        string result = "";

        for (int i = 0; i < length; i++)
        {
            long number = long.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);
            for (int j = 0; j < binaryNumber.Length; j++)
            {
                if (binaryNumber[j].ToString() == binarySearch.ToString())
                {
                    count++;
                }
            }
            result += count + "\n";
            count = 0;
        }
        Console.Write(result);
    }
}
