﻿namespace CalculatorMVC
{
    public class CalculatorController
    {
        CalculatorView view = new CalculatorView();
        CalculatorModel model = new CalculatorModel();

        public void Start()
        {
            (double firstNum, double secondNum, string userOperation) = view.UserPrompt();
            model.FirstNumber = firstNum; 
            model.SecondNumber = secondNum;
            view.Output(model.Operation(userOperation));
        }
    }
}
