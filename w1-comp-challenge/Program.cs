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

            */

            // declare variables
            int totNumStudents;

            Console.WriteLine("Please enter the total number of students");
            totNumStudents = validInt();
            
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
            Console.Write("Please provide a(n) int: ");
            do
            {
                string userInput = Console.ReadLine();
                result = int.TryParse(userInput, out userNum);

                if (!result || userNum < 1)
                {
                    Console.WriteLine("Please enter a valid integer");
                }   // end of if

            } while (!result || userNum < 1);   // end of do while

            return userNum;
        }   // end of integer validator

        // prompting for user grades
        static int gradeMethod()
        {
            /*
            prompt user for 5 homework grades
            prompt user for 3 quiz grades
            prompt user for 2 exam grades
            */

            // delcare variables
            int grade;


            Console.Write("Please enter a grade: ");
            grade = validInt();
        }


    }
}