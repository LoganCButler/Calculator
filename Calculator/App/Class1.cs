using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class CalculatorLogic
    {
        public int inputA;
        public int inputB;
        public string operation;
        public int answer { get; set; }

        public void Calc(int a, int b, string operation)
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
