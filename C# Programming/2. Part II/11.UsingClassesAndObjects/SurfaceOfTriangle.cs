/*
 * Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it; Three sides; Two sides and an angle between them.
 * Use System.Math.
 */
using System;

class ProgSurfaceOfTriangle 
{
    static void Main(string[] args)
    {
        try
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("1. Side and an altitude to it");
                Console.WriteLine("2. Three sides");
                Console.WriteLine("3. Two sides and an angle between them");
                Console.WriteLine("4. Exit");
                Console.Write("Your choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Area();
                        break;
                    case 2:
                        Perimeter();
                        break;
                    case 3:
                        AreaWithAngle();
                        break;
                }
            } while(choice < 1 || choice > 4 || choice != 4);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine(fe.Message);
        }
    }
    static void Area()
    {
        Console.Write("Base:");
        double sideBase = double.Parse(Console.ReadLine());
        Console.Write("Altitude:");
        double altitude = double.Parse(Console.ReadLine());

        double result = (sideBase * altitude) / 2;
        Console.WriteLine("{0}*{1}/2={2}", sideBase, altitude, result);
    }
    static void Perimeter()
    {
        Console.Write("First side:");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Second side:");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Third side:");
        double thirdSide = double.Parse(Console.ReadLine());

        double result = firstSide + secondSide + thirdSide;
        Console.WriteLine("{0}+{1}+{2}={3}", firstSide, secondSide, thirdSide, result);
    }
    static void AreaWithAngle()
    {
        Console.Write("First side:");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Second side:");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Angle in degree:");
        double angle = double.Parse(Console.ReadLine());

        angle = Math.Cos(angle);

        double result = (firstSide * firstSide) + (secondSide * secondSide) - (2*firstSide*secondSide*angle);
        Console.WriteLine("Third side is: {0}", Math.Sqrt(result));
    }
}