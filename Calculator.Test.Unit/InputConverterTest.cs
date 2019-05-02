using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter ic = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble() 
        {
            string inpNum = "5";
            double convertedNumber = ic.ConvertToNum(inpNum);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringIntoDouble()
        {
            string inpNum = "*";
            double convertedNumber = ic.ConvertToNum(inpNum);
        }
    }
}
