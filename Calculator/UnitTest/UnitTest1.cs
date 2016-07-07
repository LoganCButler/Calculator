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
            int inputF = 1;
            int inputB = 2;
            //Act
            CalculatorLogic c = new CalculatorLogic();
            c.CalcAdd(inputF, inputB);
            //Assert
            Assert.AreEqual(3, c.answer);
        }
    }
}
