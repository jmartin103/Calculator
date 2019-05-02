using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine ce = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            // Step 1: Setting up data
            int num1 = 1;
            int num2 = 2;

            // Step 2: Process data through method
            double result = ce.Calculate("+", num1, num2);

            // Step 3: Compare result against your assumption
            Assert.AreEqual(3, result);
        }
    }
}
