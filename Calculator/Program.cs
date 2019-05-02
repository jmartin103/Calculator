using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter ic = new InputConverter();
                CalculatorEngine ce = new CalculatorEngine();

                double num1 = ic.ConvertToNum(Console.ReadLine());
                double num2 = ic.ConvertToNum(Console.ReadLine());
                string op = Console.ReadLine();

                double result = ce.Calculate(op, num1, num2);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
