using System;

namespace Point3D
{
    class Calculation
    {
        //3. Write a static class with a static method to calculate
        //the distance between two points in the 3D space.
        //Create a class Path to hold a sequence of points in 

        public static double Distance(Point3D PointA, Point3D PointB)
        {
            return Math.Sqrt((PointA.x - PointB.x) * (PointA.x - PointB.x) +
                             (PointA.y - PointB.y) * (PointA.y - PointB.y) +
                             (PointA.z - PointB.z) * (PointA.z - PointB.z));
        }
    }
}
