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
            CalculatorLogic c = new CalculatorLogic();
            //Act
            c.numberList.Add(3);
            c.operationList.Add('+');
            c.numberList.Add(2);
            c.operationList.Add('=');
            c.DoTheMath();
            //Assert
            Assert.AreEqual(5, c.lastAnswer);
        }

        [TestMethod]
        public void subtractingIntegers()
        {
            //Arrange 
            CalculatorLogic c = new CalculatorLogic();
            //Act
            c.numberList.Add(3);
            c.operationList.Add('-');
            c.numberList.Add(2);
            c.operationList.Add('=');
            c.DoTheMath();
            //Assert
            Assert.AreEqual(1, c.lastAnswer);
        }

        [TestMethod]
        public void multiplyingIntegers()
        {
            //Arrange 
            CalculatorLogic c = new CalculatorLogic();
            //Act
            c.numberList.Add(8);
            c.operationList.Add('*');
            c.numberList.Add(2);
            c.operationList.Add('=');
            c.DoTheMath();
            //Assert
            Assert.AreEqual(16, c.lastAnswer);
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
            //c.Calc(inputA, inputB, operation);
            //Assert
            //Assert.AreEqual(5, c.answer);
        }

        [TestMethod]
        public void integersInDoubleOut()
        {
            //Arrange 
            int inputA = 13;
            int inputB = 2;
            string operation = "/";
            //Act
            CalculatorLogic c = new CalculatorLogic();
            //c.Calc(inputA, inputB, operation);
            //Assert
            //Assert.AreEqual(6.5, c.answer);
        }

        [TestMethod]
        public void doublesInIntegerOut()
        {
            //Arrange 
            double inputA = 2.5;
            double inputB = .5;
            string operation = "/";
            //Act
            CalculatorLogic c = new CalculatorLogic();
            //c.Calc(inputA, inputB, operation);
            //Assert
            //Assert.AreEqual(5, c.answer);
        }

        [TestMethod]
        public void doublesInDoublesOut()
        {
            //Arrange 
            double inputA = 5;
            double inputB = .5;
            string operation = "*";
            //Act
            CalculatorLogic c = new CalculatorLogic();
            //c.Calc(inputA, inputB, operation);
            //Assert
            //Assert.AreEqual(2.5, c.answer);
        }

        

    }
}
