using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addingIntegers()
        {
            //Arrange 
            int inputA = 1;
            int inputB = 2;
            string operation = "+";
            //Act
            CalculatorLogic c = new CalculatorLogic();
            c.Calc(inputA, inputB, operation);
            //Assert
            Assert.AreEqual(3, c.answer);
        }

        [TestMethod]
        public void subtractingIntegers()
        {
            //Arrange 
            int inputA = 5;
            int inputB = 1;
            string operation = "-";
            //Act
            CalculatorLogic c = new CalculatorLogic();
            c.Calc(inputA, inputB, operation);
            //Assert
            Assert.AreEqual(4, c.answer);
        }

        [TestMethod]
        public void multiplyingIntegers()
        {
            //Arrange 
            int inputA = 5;
            int inputB = 2;
            string operation = "*";
            //Act
            CalculatorLogic c = new CalculatorLogic();
            c.Calc(inputA, inputB, operation);
            //Assert
            Assert.AreEqual(10, c.answer);
        }

        [TestMethod]
        public void dividingIntegers()
        {
            //Arrange 
            int inputA = 15;
            int inputB = 3;
            string operation = "/";
            //Act
            CalculatorLogic c = new CalculatorLogic();
            c.Calc(inputA, inputB, operation);
            //Assert
            Assert.AreEqual(5, c.answer);
        }

    }
}
