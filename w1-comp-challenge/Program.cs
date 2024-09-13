using System;

namespace compChallenge
{
    class Program
    {
        // main program
        static void Main(string[] args)
        {
            /*
            prompt user for a total number of students
                use validation so only whole numbers
            for loop for the amount of students
                prompt each student for a name
            */

            // declare variables
            int totNumStudents;

            // prompt user for total number of students
            Console.WriteLine("Please enter the total number of students");
            totNumStudents = validInt();

            for (int i = 0; i < totNumStudents; i++)
            {
                Console.Write("Student name: ");
                string studentName = Console.ReadLine();
                gradeMethod(studentName);
            }


        }   // end of main class


        // validating int's
        static int validInt()
        {
            /*
            prompt user for valid integer
                utilize do while loop for validation logic

            tryparse method of seeing if what's entered is an int and nothing else
                basic if logic to check if the number entered meets the requirements
            */

            // declare variables
            bool result;
            int userNum;

            // user prompt for int
            Console.Write("Please provide a(n) whole number: ");
            do
            {
                string userInput = Console.ReadLine();
                result = int.TryParse(userInput, out userNum);

                if (!result || userNum < 1)
                {
                    Console.Write("Please enter a valid whole number: ");
                }   // end of if

            } while (!result || userNum < 1);   // end of do while

            return userNum;
        }   // end of integer validator


        // method overload from above, just to allow 0's for the grades
        static int validGradeNum()
        {
            /*
            prompt user for valid integer
                utilize do while loop for validation logic

            tryparse method of seeing if what's entered is an int and nothing else
                basic if logic to check if the number entered meets the requirements
            */

            // declare variables
            bool result;
            int userNum;

            // user prompt for int
            Console.Write("Please provide a grade between 0 and 100: ");
            do
            {
                string userInput = Console.ReadLine();
                result = int.TryParse(userInput, out userNum);

                if (!result || userNum < 0 || userNum > 100)
                {
                    Console.Write("Please enter a valid grade between 0 and 100: ");
                }   // end of if

            } while (!result || userNum < 0 || userNum > 100);   // end of do while

            return userNum;
        }   // end of method overload


        // prompting for user grades
        static void gradeMethod(string studentName)
        {
            /*
            prompt user for 5 homework grades
                use for loop five times

            prompt user for 3 quiz grades
                use for loop 3 times

            prompt user for 2 exam grades
                use for loop 2 times
            */

            // delcare variables
            int initialHomeworkGrade = 0;
            int initialExamGrade = 0;
            int initialQuizGrade = 0;
            double finalHomeworkAverage = 0;
            double finalExamAverage = 0;
            double finalQuizAverage = 0;
            double finalHomeworkGrade = 0;
            double finalQuizGrade = 0;
            double finalExamGrade = 0;
            double finalNumberGrade = 0;
            string finalLetterGrade;


            // homework loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter homework grade {i + 1}");
                initialHomeworkGrade += validGradeNum();
            }   // end of for loop

            // finalHomeworkAverage & finalHomeworkGrade logic
            finalHomeworkAverage = (double)initialHomeworkGrade / 5;
            finalHomeworkGrade = finalHomeworkAverage * 0.5;

            // quiz loop
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter quiz grade {i + 1}");
                initialQuizGrade += validGradeNum();
            }   // end of for loop

            // finalQuizAverage & finalQuizGrade logic
            finalQuizAverage = (double)initialQuizGrade / 3;
            finalQuizGrade = finalQuizAverage * 0.3;

            // exam loop
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter exam grade {i + 1}");
                initialExamGrade += validGradeNum();
            }   // end of for loop

            // finalExamAverage & finalExamGrade logic
            finalExamAverage = (double)initialExamGrade / 2;
            finalExamGrade = finalExamAverage * 0.2;

            // finalGrade logic
            finalNumberGrade = finalHomeworkGrade + finalQuizGrade + finalExamGrade;

            if (finalNumberGrade >= 90)
            {
                finalLetterGrade = "A";
            }
            else if (finalNumberGrade >= 80)
            {
                finalLetterGrade = "B";
            }
            else if (finalNumberGrade >= 70)
            {
                finalLetterGrade = "C";
            }
            else if (finalNumberGrade >= 60)
            {
                finalLetterGrade = "D";
            }
            else
            {
                finalLetterGrade = "F";
            }

            // summary of results
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            Console.WriteLine($"Student Name {studentName}");
            Console.WriteLine($"Your final homework average is: {finalHomeworkAverage:F2}");
            Console.WriteLine($"Your final quiz average is: {finalQuizAverage:F2}");
            Console.WriteLine($"Your final exam average is: {finalExamAverage:F2}");
            Console.WriteLine($"Your final letter grade is: {finalLetterGrade}");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
        }   // end of grade method
    }
}