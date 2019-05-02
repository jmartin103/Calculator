using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertToNum(string textInp)
        {
            double convertedNumber;
            if (!double.TryParse(textInp, out convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value; got string");
            }
            return convertedNumber;
        }
    }
}
