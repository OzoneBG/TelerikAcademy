using System;

namespace Garden
{
    class Program
    {
        static void Main()
        {   
            //Variables
            double seedPrice;
            long areaRemaining;
            long totalArea = 250;
            long area;


            //Read info
            double tomatoSeed = double.Parse(Console.ReadLine());
            long tomatoArea = long.Parse(Console.ReadLine());
            double cucumberSeeds = double.Parse(Console.ReadLine());
            long cucumberArea = long.Parse(Console.ReadLine());
            double potatoSeeds = double.Parse(Console.ReadLine());
            long potatoArea = long.Parse(Console.ReadLine());
            double carrotSeeds = double.Parse(Console.ReadLine());
            long carrotArea = long.Parse(Console.ReadLine());
            double cabbageSeeds = double.Parse(Console.ReadLine());
            long cabbageArea = long.Parse(Console.ReadLine());
            double beanSeeds = double.Parse(Console.ReadLine());

            //Calc total seed price
            seedPrice = (tomatoSeed * 0.50) + (cucumberSeeds * 0.40) + (potatoSeeds * 0.25) + (carrotSeeds * 0.60) + (cabbageSeeds * 0.30) + (beanSeeds * 0.40);

            //Calc total area
            area = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

            //Calc remaing area
            areaRemaining = totalArea - area;

            Console.WriteLine("Total costs: {0:F2}", seedPrice);

            if (areaRemaining > 0)
            {
                //Area left for beans
                Console.WriteLine("Beans area: {0}", areaRemaining);
            }
            else if (areaRemaining < 0)
            {
                //Insuccficient area
                Console.WriteLine("Insufficient area");
            }
            else if (areaRemaining == 0)
            {
                //No area left for beans
                Console.WriteLine("No area for beans");
            }

            
        }
    }
}
