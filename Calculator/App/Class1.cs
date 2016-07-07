using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class CalculatorLogic
    {
        public double inputA;
        public double inputB;
        public string operation;
        public double answer { get; set; }

        public void Calc(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+":
                    answer = a + b;
                    break;
                case "-":
                    answer = a - b;
                    break;
                case "*":
                    answer = a * b;
                    break;
                case "/":
                    answer = a / b;
                    break;
            }

            
        }
    }
}
