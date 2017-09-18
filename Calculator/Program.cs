using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                Console.WriteLine("Enter two numbers");
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(firstInput) || !String.IsNullOrWhiteSpace(secondInput))
                {
                    double firstNumber = inputConverter.ConvertInputToNumeric(firstInput);
                    double secondNumber = inputConverter.ConvertInputToNumeric(secondInput);
                    string operation = Console.ReadLine();
                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The number you have entered is null or empty.");
                    Console.ReadLine();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
