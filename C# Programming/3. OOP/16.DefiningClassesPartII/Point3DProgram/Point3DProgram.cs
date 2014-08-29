using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3DProgram.Data;

namespace Point3DProgram
{
    class Point3DProgram
    {
        static void Main(string[] args)
        {
            Point3D one = new Point3D(1, 2, 3);
            Point3D two = new Point3D(4, 5, 6);

            Console.WriteLine(Distance.CalculateDistance(one,two));

            Path path1 = new Path();
            Path path2 = new Path();

            //Add points to this paths
            path2.AddPath(two);
            path2.AddPath(one);
            path1.AddPath(one);
            path1.AddPath(two);

            PathStorage.SavePaths(path1);
            PathStorage.SavePaths(path2);

            for (int i = 0; i < PathStorage.LoadPaths().Count; i++)
            {
                Console.Write("Path{0}: ", i + 1);
                for (int j = 0; j < PathStorage.LoadPaths()[i].Points.Count; j++)
                {
                    Console.Write(PathStorage.LoadPaths()[i].Points[j].ToString());
                    if (j < PathStorage.LoadPaths()[i].Points.Count - 1)
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
