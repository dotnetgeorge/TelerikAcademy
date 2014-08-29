/*
 * Define abstract class Shape with only one abstract method CalculateSurface()
 * and fields width and height. Define two new classes Triangle and Rectangle 
 * that implement the virtual method and return the surface of the figure 
 * (height*width for rectangle and height*width/2 for triangle).
 * Define class Circle and suitable constructor so that at initialization height
 * must be kept equal to width and implement the CalculateSurface() method.
 * Write a program that tests the behavior of  the CalculateSurface() method
 * for different shapes (Circle, Rectangle, Triangle) stored in an array.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProgram.Data;

namespace ShapeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(4, 5);
            Rectangle rectangle = new Rectangle(2, 2);
            Circle circle = new Circle(3, 3);

            List<double> surfaces = new List<double>();

            surfaces.Add(triangle.CalculateSurface());
            surfaces.Add(rectangle.CalculateSurface());
            surfaces.Add(circle.CalculateSurface());

            foreach (var surface in surfaces)
            {
                Console.WriteLine(surface);
            }
        }
    }
}
