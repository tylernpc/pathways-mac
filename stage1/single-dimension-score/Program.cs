using System;

// min, max, average method
namespace singleDimension
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            pass any size array
            prompt user for array size
            call method for how many spots
            call maxMethod
            call minMethod
            call avgMethod
            */

            // prompt for how many spots in array
            int myNum = validInt();
            int[] myArray = new int[Convert.ToInt32(myNum)];

            // call array creation method
            myArray = userArray(myArray);

            // calling max method
            int maxValue = maxMethod(myArray);
            
            // calling min method
            int minValue = minMethod(myArray);

            // calling avg method
            int avgValue = avgMethod(myArray);

            Console.WriteLine("The highest number was " + maxValue + ", the lowest number was " + minValue + ", the average number was " + avgValue);

        } // end of main class



        // logic to get numbers for the array
        static int[] userArray(int[] array)
        {
            // for loop for number prompt
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a value for [" + i + "]: ");
                array[i] = validInt();
            }

            return array;
        }



        // logic to get the max numbers in order s a a
        static int maxMethod(int[] array)
        {
            /*
            similar to finding the highest number
            foreach loop through the passed array
            and top the number and keep them in place
            number by number
            */

            // 0 is the maximum in this case
            int maxValue = array[0];

            //loop through
            foreach (int number in array)
            {
                // if larger number update value to that number
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }

            return maxValue;
        } // end of max method



        // logic to get the min numbers in order
        static int minMethod(int[] array)
        {
            /*
            similar to finding the lowest number
            foreach loop through the passed array
            and lower the number and keep them in place
            number by number
            */

            // 0 is the minimum in this case
            int minValue = array[0];

            //loop through
            foreach (int number in array)
            {
                // if lower number update value to that number
                if (number < minValue)
                {
                    minValue = number;
                }
            }

            return minValue;
        } // end of min method



        // logic to get the avg
        static int avgMethod(int[] array)
        {
            /*
            foreach number add it to a base number
            then divide the total by the base number
            */

            int averageNum = 0;

            foreach (int i in array)
            {
                averageNum += i;
            }

            return averageNum / array.Length;
        } // end of avg method



        // reused valid whole number logic
        static int validInt()
        {
            // variable decloration
            bool result; // this will check if the num is a(n) int
            int userNum; // this will be the users num and will be checked
            string userInput; // this is the userInput

            Console.Write("Please provide a(n) whole number: ");
            do
            {
                // prompt user for valid number (logic)
                userInput = Console.ReadLine();
                result = int.TryParse(userInput, out userNum);

                if (!result || userNum < 1)
                {
                    Console.Write("Please enter a valid whole number: ");
                } // end of if

            } while (!result || userNum < 1); // end of do while

            return userNum;
        } // end of valid whole number
    }
}