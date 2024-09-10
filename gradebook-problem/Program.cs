// gradebook.exe
// a program made to calculate grades based on weights, and numbers

using System;
using System.Data;

// v1.
public class gradeBook
{
    public static void Main(string[] args)
    {
        // ask the user how many classes a student has
        Console.Write("What grade did the student receive on their exam? ");
        string testGrade = Console.ReadLine();

        Console.Write("What grade did the student receive on their quiz? ");
        string quizGrade = Console.ReadLine();

        Console.Write("What grade did the student receive on their homework? ");
        string homeworkGrade = Console.ReadLine();


        if (testGrade == "A")
        {
            int weightedTestGrade = 90;
        } else if (testGrade == "B") {
            int weightedTestGrade = 80;
        } else if (testGrade == "C") {
            int weightedTestGrade = 70;
        }

        
    }
}


/* v2. loops *


public class gradeBook
{
    public static void Main(string[] args)
    {
        // ask the user how many classes a student has
        Console.Write("What grade did the student receive on their exam? ");
        string testGrade = Console.ReadLine();

        Console.Write("What grade did the student receive on their quiz? ");
        string quizGrade = Console.ReadLine();

        Console.Write("What grade did the student receive on their homework? ");
        string homeworkGrade = Console.ReadLine();


        if (testGrade == "A")
        {
            int weightedTestGrade = 90;
        } else if (testGrade == "B") {
            int weightedTestGrade = 80;
        } else if (testGrade == "C") {
            int weightedTestGrade = 70;
        }

        
    }
}


*/


/* v3. ai revised *


public class gradeBook
{
    public static void Main(string[] args)
    {
        // ask the user how many classes a student has
        Console.Write("What grade did the student receive on their exam? ");
        string testGrade = Console.ReadLine();

        Console.Write("What grade did the student receive on their quiz? ");
        string quizGrade = Console.ReadLine();

        Console.Write("What grade did the student receive on their homework? ");
        string homeworkGrade = Console.ReadLine();


        if (testGrade == "A")
        {
            int weightedTestGrade = 90;
        } else if (testGrade == "B") {
            int weightedTestGrade = 80;
        } else if (testGrade == "C") {
            int weightedTestGrade = 70;
        }

        
    }
}


*/