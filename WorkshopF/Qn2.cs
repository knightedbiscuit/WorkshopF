using System;

namespace WorkshopF
{
    class Qn2
    {
        static void Main()
        {
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
            int arrlength = marks.Length; // what is length of array. Number of elements
            int position = arrlength - 1; // nth position of array. starting with 0th.

            for (int i = 0; i <= position - 1; i++)
            {
                for (int j = i + 1; j <= position; j++)
                {
                    if (marks[j] > marks[i])
                    {
                        int tempNum = marks[i];
                        marks[i] = marks[j];
                        marks[j] = tempNum;                      
                    }

                    for (int k = 0; k <= position; k++)
                    {
                        Console.Write("{0},", marks[k]);
                    }
                    Console.WriteLine();
                }
            }


            Console.Write("Final sorted: ");

            for (int k = 0; k <= position; k++)
            {
                Console.Write("{0},", marks[k]);
            }
            Console.WriteLine();
        }

    }
}
