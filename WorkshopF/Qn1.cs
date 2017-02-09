using System;
using System.Linq; // needed to call ARRAY.Min() method.

namespace WorkshopF
{
    class Qn1
    {
        static void Main()
        {
            double[] Sales = new double[12] { 110, 111, 500, 300, 600, 420, 540.5, 1000, 900, 300, 410, 560 };
            string[] Months = new string[12]
                                {"Jan","Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            


            for (int i=0; i<12;i++)
            {
                if (Sales[i] == Sales.Max())
                {
                    Console.WriteLine("The Maximum Sales of ${0:0.00} is recorded in " + Months[i], Sales[i]);
                    break;
                }
            }


            for (int j = 0; j < 12; j++)
            {
                if (Sales[j] == Sales.Min())
                {
                    Console.WriteLine("The Minimum Sales of ${0:0.00} is recorded in " + Months[j], Sales[j]);
                    break;
                }
            }
            Console.WriteLine("The average monthly sales is ${0:0.00}", Sales.Average());
        }
    }
}
