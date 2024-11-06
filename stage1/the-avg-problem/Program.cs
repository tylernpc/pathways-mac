using System;


namespace avgProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            create and display 2d array
            transition back into 1d array per column (1)
                for loop each student
                    for loop each student
            */

            // declare variables
            int totalAvg = 0;
            int avg = 0;
            int highestAvg = 0;
            int lowestAvg = 100;
            int highestAvgStudent = 0;
            int lowestAvgStudent = 0;

            // 2D ARRAY
            // formatting to show student 1, 2, and 3
            Console.WriteLine(" Scores");
            Console.WriteLine("S1 S2 S3");
            int[,] students = {   //s1  s2  s3
                                    {78, 86, 94}, // hw
                                    {90, 84, 96}, // quiz
                                    {80, 90, 99},  // exam
                                    {49, 32, 30}
                                }; // end of student array

            // displasy students scores in grid
            for (int i = 0; i < students.GetLength(0); i++)
            {
                for (int j = 0; j < students.GetLength(1); j++)
                {
                    Console.Write(students[i, j] + " ");
                } // end of for loop
                Console.WriteLine();
            } // end of for loop

            // array to store each student's average
            int[] studentAverages = new int[students.GetLength(1)]; // works together [1 big bit]

            // increments through each student column
            for (int student = 0; student < students.GetLength(1); student++)
            {
                // creates a single record for the student
                int[] studentScores = new int[students.GetLength(0)]; // works together [1 medium bit]

                // loops through each score for the student
                for (int i = 0; i < students.GetLength(0); i++)
                {
                    studentScores[i] = students[i, student]; // works together [1 small bit]
                } // end of for loop

                // used to calculate avg score
                avg = AvgCalc(studentScores);
                Console.WriteLine($"{avg} for {student}");

                // stores each students average
                studentAverages[student] = avg;

                // adds each average to a total
                totalAvg += avg;

                // logic to find highest average
                if (avg > highestAvg)
                {
                    highestAvg = avg;
                    highestAvgStudent = student + 1;
                } // end of if
                // logic to find lowest average
                if (avg < lowestAvg)
                {
                    lowestAvg = avg;
                    lowestAvgStudent = student + 1;
                } // end of if
            } // end of for loop

            // output
            // total average / amount of data in this case 9
            totalAvg /= students.GetLength(1);
            Console.WriteLine();
            Console.WriteLine($"The student with the highest average is S{highestAvgStudent} with a {highestAvg}\nThe student with the lowest average is S{lowestAvgStudent} with a {lowestAvg}\nWith a class average of {totalAvg}");
        } // end of main class

        // logic to get the avg
        static int AvgCalc(int[] array)
        {
            /*
            foreach number add it to the base number
            then divide the total by the base number
            */

            // declared variables
            int result = 0;

            // foreach that adds up total
            foreach (int i in array)
            {
                result += i;
            } // end of foreach

            // return results
            return result / array.Length;
        } // end of avgCalc
    }
}