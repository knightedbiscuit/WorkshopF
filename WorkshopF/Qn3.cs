using System;

namespace WorkshopF
{
    class Qn3
    {
        static void Main()
        {
            double[,] classmarks = new double[12, 6]
                                { {56,84,68,29,0,0},
                                  {94,73,31,96,0,0},
                                  {41,63,36,90,0,0},
                                  {99,9,18,17,0,0},
                                  {62,3,65,75,0,0},
                                  {40,96,53,23,0,0},
                                  {81,15,27,30,0,0},
                                  {21,70,100,22,0,0},
                                  {88,50,13,12,0,0},
                                  {48,54,52,78,0,0},
                                  {64,71,67,25,0,0},
                                  {16,93,46,72,0,0} };

            for (int i = 0; i < 12; i++)
            {
                double sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    double temp = classmarks[i,j];
                    sum = sum + temp;
                }
                classmarks[i, 4] = sum;
                double average = sum / 4;
                classmarks[i,5] = average;
            }

            for (int k = 0; k < 12; k++)
            {
                Console.WriteLine("{0}, {1}",classmarks[k, 4],classmarks[k,5]);
            }
           


        }

    }
}
