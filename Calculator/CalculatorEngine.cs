using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class CalculatorEngine
    {
        public double Calculate(string operation, double firstEntry, double secondEntry) {
            double result = 0.0;
            switch (operation) {
                case "add":
                    result = firstEntry + secondEntry;
                    break;
                case "+":
                    result = firstEntry + secondEntry;
                    break;
                case "subtract":
                    result = firstEntry - secondEntry;
                    break;
                case "-":
                    result = firstEntry - secondEntry;
                    break;
                case "multiply":
                    result = firstEntry * secondEntry;
                    break;
                case "*":
                    result = firstEntry * secondEntry;
                    break;
                case "divide":
                    result = firstEntry / secondEntry;
                    break;
                case "/":
                    result = firstEntry / secondEntry;
                    break;
                default:
                    throw new InvalidOperationException("The operation you have entered is not recognized.");
            }
            return result;
        }
    }
}
