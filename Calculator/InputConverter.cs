using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class InputConverter
    {
        public double ConvertInputToNumeric(string number) {
           return Convert.ToDouble(number);
        }
    }
}
