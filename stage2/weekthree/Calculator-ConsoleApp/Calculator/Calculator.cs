﻿namespace Calculator
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }

        public Calculator(double firstNumber, double secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public double Operation(string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "A":
                    result = FirstNumber + SecondNumber; break;
                case "S":
                    result = FirstNumber - SecondNumber; break;
                case "M":
                    result = FirstNumber * SecondNumber; break;
                case "D":
                    result = FirstNumber / SecondNumber; break;
                default:
                    break;
            }
            return result;
        }
    }
}