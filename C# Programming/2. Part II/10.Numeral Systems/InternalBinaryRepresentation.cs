/*
*Write a program that shows the internal binary representation of given 32-bit signed floating-point number in 
 IEEE 754 format (the C# type float). Example: -27,25 -> sign = 1,
 exponent = 10000011, mantissa = 10110100000000000000000.
*/
using System;
using System.Collections.Generic;

class InternalBinaryRepresentation
{
    static void Main(string[] args)
    {
        Console.Write("Number:");
        float number = float.Parse(Console.ReadLine());


        byte[] arr = BitConverter.GetBytes(number);
        Array.Reverse(arr);
        string result = BitConverter.ToString(arr);

        string binary = "";

        for (int i = 0; i < result.Length; i++)
        {
            switch (result[i])
            {
                case '0':
                    binary += "0000";
                    break;
                case '1':
                    binary += "0001";
                    break;
                case '2':
                    binary += "0010";
                    break;
                case '3':
                    binary += "0011";
                    break;
                case '4':
                    binary += "0100";
                    break;
                case '5':
                    binary += "0101";
                    break;
                case '6':
                    binary += "0110";
                    break;
                case '7':
                    binary += "0111";
                    break;
                case '8':
                    binary += "1000";
                    break;
                case '9':
                    binary += "1001";
                    break;
                case 'A':
                    binary += "1010";
                    break;
                case 'a':
                    binary += "1010";
                    break;
                case 'B':
                    binary += "1011";
                    break;
                case 'b':
                    binary += "1011";
                    break;
                case 'C':
                    binary += "1100";
                    break;
                case 'c':
                    binary += "1100";
                    break;
                case 'D':
                    binary += "1101";
                    break;
                case 'd':
                    binary += "1101";
                    break;
                case 'E':
                    binary += "1110";
                    break;
                case 'e':
                    binary += "1110";
                    break;
                case 'F':
                    binary += "1111";
                    break;
                case 'f':
                    binary += "1111";
                    break;
                default:
                    break;
            }
        }

        Console.Write("Result:");
        for (int i = 0; i < binary.Length; i++)
        {
            Console.Write(binary[i]);
            if (i == 0 || i == 8)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
