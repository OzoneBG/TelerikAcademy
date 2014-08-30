using System;
using System.IO;

namespace Point3D
{
    class PathStorage
    {
        //4. Create a static class PathStorage with static methods
        //to save and load paths from a text file. Use a 
        //file format of your choice.

        public static void SavePath(Path hold)
        {
            StreamWriter writer = new StreamWriter("path.txt");
            using (writer)
            {
                for (int i = 0; i < hold.path.Count; i++)
                {
                    writer.WriteLine(hold.path[i].x + " " + hold.path[i].y + " " + hold.path[i].z);
                }
            }
        }

        public static Path LoadPath(string file)
        {
            StreamReader reader = new StreamReader(file);
            Path pathList = new Path();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] pointCords = line.Split(' ');
                    //Create a new point for every line in the text file and add it to the List
                    Point3D Point = new Point3D(int.Parse(pointCords[0]), int.Parse(pointCords[1]), int.Parse(pointCords[2]));
                    pathList.path.Add(Point);
                    line = reader.ReadLine();
                }
            }
            return pathList;
        }

    }
}
