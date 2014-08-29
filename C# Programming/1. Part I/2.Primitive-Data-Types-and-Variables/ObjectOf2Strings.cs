//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Hello";
            string two = "World";
            object obj = one + " " + two;
            string three = (string)obj;
            Console.WriteLine(three);
        }
    }
}
