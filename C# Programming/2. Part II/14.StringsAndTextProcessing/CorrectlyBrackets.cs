/*
 * Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 */
using System;

class CorrectlyBrackets
{
    static void Main(string[] args)
    {
        Console.Write("Expression: ");
        string expression = Console.ReadLine();

        int leftBrackets = 0;
        int rightBrackets = 0;

        int leftIndex = expression.IndexOf("(");
        while (leftIndex != -1)
        {
            leftBrackets++;
            leftIndex = expression.IndexOf("(", leftIndex + 1);
        }

        int rightIndex = expression.IndexOf(")");
        while (rightIndex != -1)
        {
            rightBrackets++;
            rightIndex = expression.IndexOf(")", rightIndex + 1);
        }

        Console.WriteLine(leftBrackets == rightBrackets ? "Correct" : "Incorrect");
    }
}