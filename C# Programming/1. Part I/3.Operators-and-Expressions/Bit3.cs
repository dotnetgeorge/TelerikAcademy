//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main()
        {
            const string messageFormat = "3rd number from the binary number {0} is {1}.";
            const int numberWithZeroOnThrirdPlace = int.MaxValue - 8;
            Console.WriteLine(messageFormat, GetBiteBinaryNumber(numberWithZeroOnThrirdPlace), GetBit(numberWithZeroOnThrirdPlace, 3));
            Console.WriteLine(messageFormat, GetBiteBinaryNumber(8), GetBit(8, 3));
        }

        public static int GetBit(int number, byte position)
        {
            if (position >= GetBiteBinaryNumber(number).Length)
            {
                throw new ArgumentOutOfRangeException("position");
            }

            int mask = 1;
            mask = mask << position;
            int result = number & mask;
            result = result >> position;
            return result;
        }

        public static string GetBiteBinaryNumber(int number)
        {
            return Convert.ToString(number, 2).PadLeft(32, '0');
        }
    }
}
