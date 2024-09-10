// gradebook.exe
// a program made to calculate grades based on weights, and numbers

using System;
using System.Data;

// v1.

public class gradeBook
{
    public static void Main(string[] args)
    {
        // Initializing var's
        double weightedTestGrade;
        double weightedQuizGrade;
        double weightedHomeworkGrade;
        double finalTestGrade;
        double finalQuizGrade;
        double finalHomeworkGrade;

        // Asking for Exam Grade
        Console.Write("What grade did the student receive on their exam? ");
        string testGrade = Console.ReadLine();

        // Asking for Quiz Grade
        Console.Write("What grade did the student receive on their quiz? ");
        string quizGrade = Console.ReadLine();

        // Asking for Homework Grade
        Console.Write("What grade did the student receive on their homework? ");
        string homeworkGrade = Console.ReadLine();

        /* 
        0.8 & 0.6 are completely randomly selected numbers. The idea is that you give them less than the actual grade and add it up to be equivalent to something on the grading scale.
        In this case the 0.8 & 0.6 are completely for the weights of (0.8 = Summative) (0.6 = Formative)

        Max amount of summative points can be 72
        Max amount of formative points can be 54

        Max amount of points is 180
        */

        // Test Grade Selection | Summative
        if (testGrade.ToUpper() == "A")
        {
            weightedTestGrade = 90;
            finalTestGrade = weightedTestGrade * 0.8;
        } else if (testGrade.ToUpper() == "B") {
            weightedTestGrade = 80;
            finalTestGrade = weightedTestGrade * 0.8;
        } else if (testGrade.ToUpper() == "C") {
            weightedTestGrade = 70;
            finalTestGrade = weightedTestGrade * 0.8;
        } else if (testGrade.ToUpper() == "D") {
            weightedTestGrade = 60;
            finalTestGrade = weightedTestGrade * 0.8;
        } else {
            weightedTestGrade = 50;
            finalTestGrade = weightedTestGrade * 0.8;
        }

        // Quiz Grade Selection | Formative
        if (quizGrade.ToUpper() == "A")
        {
            weightedQuizGrade = 90;
            finalQuizGrade = weightedQuizGrade * 0.6;
        } else if (quizGrade.ToUpper() == "B") {
            weightedQuizGrade = 80;
            finalQuizGrade = weightedQuizGrade * 0.6;
        } else if (quizGrade.ToUpper() == "C") {
            weightedQuizGrade = 70;
            finalQuizGrade = weightedQuizGrade * 0.6;
        } else if (quizGrade.ToUpper() == "D") {
            weightedQuizGrade = 60;
            finalQuizGrade = weightedQuizGrade * 0.6;
        } else {
            weightedQuizGrade = 50;
            finalQuizGrade = weightedQuizGrade * 0.6;
        }

        // Homework Grade Selection | Formative
        if (homeworkGrade.ToUpper() == "A")
        {
            weightedHomeworkGrade = 90;
            finalHomeworkGrade = weightedHomeworkGrade * 0.6;
        } else if (homeworkGrade.ToUpper() == "B") {
            weightedHomeworkGrade = 80;
            finalHomeworkGrade = weightedHomeworkGrade * 0.6;
        } else if (homeworkGrade.ToUpper() == "C") {
            weightedHomeworkGrade = 70;
            finalHomeworkGrade = weightedHomeworkGrade * 0.6;
        } else if (homeworkGrade.ToUpper() == "D") {
            weightedHomeworkGrade = 60;
            finalHomeworkGrade = weightedHomeworkGrade * 0.6;
        } else {
            weightedHomeworkGrade = 50;
            finalHomeworkGrade = weightedHomeworkGrade * 0.6;
        }

        // Final grade calculation to determine what comes below
        double finalGrade = (finalTestGrade + finalQuizGrade + finalHomeworkGrade) / 180;        

        // Output | Depending on grade level you will receive one of these messages
        if (finalGrade >= 0.9) {
            Console.WriteLine("Congratulations, you received an A this semester! Your grade percentage was: " + finalGrade);
        } else if (finalGrade >= 0.8) {
            Console.WriteLine("Good job, you finished the semester with a B! Your grade percentage was: " + finalGrade);
        } else if (finalGrade >= 0.7) {
            Console.WriteLine("You completed classes with a C. Nice try, definitely some things you can work on next semester! Your grade percentage was: " + finalGrade);
        } else if (finalGrade >= 0.6) {
            Console.WriteLine("You finished with a D. Let's try to get you more into studying after school! Your grade percentage was: " + finalGrade);
        } else {
            Console.WriteLine("You probably shouldn't take classes anymore. Your grade percentage was: " + finalGrade);
        }
    }
}