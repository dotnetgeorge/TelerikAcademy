namespace Point3DProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PathStorage
    {

        public PathStorage()
        { }

        public static List<Path> LoadPaths()
        {
            List<Path> paths = new List<Path>();
            try
            {
                StreamReader reader = new StreamReader("paths.txt");
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Path path = new Path();
                        string[] pointsArr = line.Split(' ');
                        foreach (var point in pointsArr)
                        {
                            if (point != string.Empty)
                            {
                                int x = Convert.ToInt32(point[0] - 48);
                                int y = Convert.ToInt32(point[2] - 48);
                                int z = Convert.ToInt32(point[4] - 48);
                                path.AddPath(new Point3D(x,y,z));
                            }
                        }
                        paths.Add(path);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }

            return paths;
        }

        public static void SavePaths(Path path)
        {
            try
            {
                string point = "";
                StreamWriter writer = new StreamWriter("paths.txt");
                using (writer)
                {
                    for (int i = 0; i < path.Points.Count; i++)
                    {
                        point += path.Points[i] + " ";
                    }
                    writer.WriteLine(point);
                    point += Environment.NewLine;
                }
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }
        }
    }
}
