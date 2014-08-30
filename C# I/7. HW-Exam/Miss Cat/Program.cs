using System;

namespace Miss_Cat
{
    class Program
    {
        static void Main()
        {
            int judge = int.Parse(Console.ReadLine());
            int vote = new int();
            int cat1 = 0;
            int cat2 = 0;
            int cat3 = 0;
            int cat4 = 0;
            int cat5 = 0;
            int cat6 = 0;
            int cat7 = 0;
            int cat8 = 0;
            int cat9 = 0;
            int cat10 = 0;

            int catid1 = 1;
            int catid2 = 2;
            int catid3 = 3;
            int catid4 = 4;
            int catid5 = 5;
            int catid6 = 6;
            int catid7 = 7;
            int catid8 = 8;
            int catid9 = 9;
            int catid10 = 10;

            for (int i = 0; i < judge; i++)
            {
                vote = int.Parse(Console.ReadLine());
                switch (vote)
                {
                    case 1:
                        cat1++;
                        break;
                    case 2:
                        cat2++;
                        break;
                    case 3:
                        cat3++;
                        break;
                    case 4:
                        cat4++;
                        break;
                    case 5:
                        cat5++;
                        break;
                    case 6:
                        cat6++;
                        break;
                    case 7:
                        cat7++;
                        break;
                    case 8:
                        cat8++;
                        break;
                    case 9:
                        cat9++;
                        break;
                    case 10:
                        cat10++;
                        break;
                }
            }

            if (cat1 > cat2 && cat1 > cat3 && cat1 > cat4 && cat1 > cat5 && cat1 > cat6 && cat1 > cat7 && cat1 > cat8 && cat1 > cat9 && cat1 > cat10)
            {
                Console.WriteLine(catid1);
            }
            else if (cat2 > cat1 && cat2 > cat3 && cat2 > cat4 && cat2 > cat5 && cat2 > cat6 && cat2 > cat7 && cat2 > cat8 && cat2 > cat9 && cat2 > cat10)
            {
                Console.WriteLine(catid2);
            }
            else if (cat3 > cat1 && cat3 > cat2 && cat3 > cat4 && cat3 > cat5 && cat3 > cat6 && cat3 > cat7 && cat3 > cat8 && cat3 > cat9 && cat3 > cat10)
            {
                Console.WriteLine(catid3);
            }
            else if (cat4 > cat1 && cat4 > cat2 && cat4 > cat3 && cat4 > cat5 && cat4 > cat6 && cat4 > cat7 && cat4 > cat8 && cat4 > cat9 && cat4 > cat10)
            {
                Console.WriteLine(catid4);
            }
            else if (cat5 > cat1 && cat5 > cat2 && cat5 > cat3 && cat5 > cat4 && cat5 > cat6 && cat5 > cat7 && cat5 > cat8 && cat5 > cat9 && cat5 > cat10)
            {
                Console.WriteLine(catid5);
            }
            else if (cat6 > cat1 && cat6 > cat2 && cat6 > cat3 && cat6 > cat4 && cat6 > cat5 && cat6 > cat7 && cat6 > cat8 && cat6 > cat9 && cat6 > cat10)
            {
                Console.WriteLine(catid6);
            }
            else if (cat7 > cat1 && cat7 > cat2 && cat7 > cat3 && cat7 > cat4 && cat7 > cat5 && cat7 > cat6 && cat7 > cat8 && cat7 > cat9 && cat7 > cat10)
            {
                Console.WriteLine(catid7);
            }
            else if (cat8 > cat1 && cat8 > cat2 && cat8 > cat3 && cat8 > cat4 && cat8 > cat5 && cat8 > cat6 && cat8 > cat7 && cat8 > cat9 && cat8 > cat10)
            {
                Console.WriteLine(catid8);
            }
            else if (cat9 > cat1 && cat9 > cat2 && cat9 > cat3 && cat9 > cat4 && cat9 > cat5 && cat9 > cat6 && cat9 > cat8 && cat9 > cat7 && cat9 > cat10)
            {
                Console.WriteLine(catid9);
            }
            else
            {
                Console.WriteLine(catid10);
            }
        }
    }
}
