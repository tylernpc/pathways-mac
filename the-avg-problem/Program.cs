using System;
using System.Data;
using System.Globalization;
using System.Net.Sockets;
using System.Numerics;

namespace avgProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            create 2d array
            transition it to a 1d array
            pass to method that calculates avg
            pass that to the high and low
            return all three and display them
            */

            // declare variables
            int avg = 0;

            // 2D ARRAY
            // formatting to show student 1, 2, and 3
            Console.WriteLine(" Scores");
            Console.WriteLine("S1 S2 S3");
            int [,] students = {   //s1  s2  s3
                                    {78, 86, 94}, // hw
                                    {90, 84, 96}, // quiz
                                    {80, 90, 99}  // exam
                                }; // end of student array

            // nested for loop to make it grid
            // displasy students scores
            for (int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = 0; j < students.GetLength(1); j++)
                {
                    Console.Write(students[i, j] + " ");
                } // end of for loop
                Console.WriteLine();
            } // end of for loop

            // increments through each student column
            for (int student = 0; student < students.GetLength(1); student++)
            {
                // creates a single record for the student
                int[] studentScores = new int[students.GetLength(0)];

                // loops through each score for the student
                for (int i = 0; i < students.GetLength(0); i++)
                {
                    studentScores[i] = students[i, student];
                }

                // utilize avg method
                avg = AvgCalc(studentScores);
                Console.WriteLine($"Average for student {student + 1}: {avg}");
            }   
            
        } // end of main class


        // logic to get the avg
        static int AvgCalc(int[] array)
        {
            /*
            foreach number add it to the base number
            then divide the total by the base number
            */

            // declared variables
            int averageNum = 0;
            int result = 0;

            // foreach that adds up total
            foreach (int i in array)
            {
                averageNum += i;
            } // end of foreach

            // return result here and averages out
            result = averageNum / array.Length;
            return result;
        } // end of avgCalc
    }
}