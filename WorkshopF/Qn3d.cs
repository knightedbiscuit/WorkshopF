using System;

namespace WorkshopF
{
    class Qn3d
    {
        // The quesiton is not asking you to create a user prompt to store the class results.
        // Rather, the question is asking you to write the program that can still work for the scenario
        // when you the array has been initiliased and you may neeed to make changes.
        // I should try writing a program to ask for user input on results. Store that in a array and
        // and do the necessary computation.
        static void Main()
        {
            double[,] classmarks = new double[12, 4]
                                { {56,84,68,29},
                                  {94,73,31,96},
                                  {41,63,36,90},
                                  {99,9,18,17},
                                  {62,3,65,75 },
                                  {40,96,53,23},
                                  {81,15,27,30},
                                  {21,70,100,22},
                                  {88,50,13,12},
                                  {48,54,52,78},
                                  {64,71,67,25},
                                  {16,93,46,72} };
            
            int students = classmarks.GetLength(0);
            int subjects = classmarks.GetLength(1);

            double[,] results = new double[students, 2];

            for (int i = 0; i < students; i++)
            {
                double sum = 0;
                for (int j = 0; j < subjects; j++)
                {
                    double temp = classmarks[i, j];
                    sum = sum + temp;
                }
                results[i,0] = sum;
                double average = sum / 4;
                results[i,1] = average;
            }

            for (int k = 0; k < students; k++)
            {
                for (int m =0; m < subjects; m++)
                {
                    Console.Write("{0}\t",classmarks[k,m]);
                }
                 Console.Write("{0}\t{1}", results[k,0], results[k,1]);
                 Console.WriteLine();
            }

        }
    }
}
