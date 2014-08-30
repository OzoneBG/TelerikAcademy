using System;



namespace Triangle
{
    class SurfaceCalc
    {
        static void Main()
        {
            Methods Method = new Methods();

            //Area found by base and height method! BH - Base and Height
            double areaBH = Method.BaseAndHeight(5, 3);
            Console.WriteLine(areaBH);

            //Area found by tree sides! T - Three sides
            double areaT = Method.TreeSides(3, 4, 5);
            Console.WriteLine(areaT);

            //Area found by two sides and angle! TA - Two sides and Angle
            double areaTA = Method.TwoSidesAndAngle(150, 231, 123);
            Console.WriteLine(areaTA);

            
        }
    }
}
