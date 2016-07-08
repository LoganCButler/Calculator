using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
  

    public class CalculatorLogic
    {
        private  bool equalPressed = false;
        private string stringOutput;

        public List<char> operationList = new List<char> { };
        public List<double> numberList = new List<double> { };

        public double lastAnswer { get; set; }


        public double DoTheMath()
        {
            lastAnswer = numberList[0];
            for (var i = 0; i < numberList.Count-1; i++)
            {
                Calc(numberList[i+1], operationList[i]);
            }
            return lastAnswer;
        }


        public void Calc(double a,  char operation)
        {
            switch (operation)
            {
                case '+':
                    lastAnswer += a;
                    break;
                case '-':
                    lastAnswer -= a;
                    break;
                case '*':
                    lastAnswer *= a;
                    break;
                case '/':
                    lastAnswer /= a;
                    break;
                case '=':                    
                    break;
            }
        }

        public string StringAnswerGenerator()
        {
            stringOutput = "'Your problem of";
            stringOutput += " " + numberList[0].ToString();
            for (var i = 0; i < numberList.Count - 1; i++)
            {
                stringAnswerMaker(numberList[i + 1], operationList[i]);
            }
            stringOutput += " = " + lastAnswer.ToString();
            return stringOutput;
        }

        private void stringAnswerMaker(double num, char op)
        {
            stringOutput += " "+ op.ToString();
            stringOutput += " " + num.ToString();
        }

        public  void GetFirstNumber()
        {
            try
            {
                Console.WriteLine("Please enter in your first number.");
                string hold = Console.ReadLine();
                double value;
                if (double.TryParse(hold, out value))
                {
                    numberList.Add(value);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch
            {
                Console.WriteLine("Please enter only one number right now.");
                GetFirstNumber();
            }
        }
        public void GetStringOfOperations()
        {
            GetOperation();
            while (false == equalPressed)
            {
                GetSecondNumber();
                GetStringOfOperations();
            }
            if (equalPressed == true)
            {
                DoTheMath();
            }

        }
        private  void GetSecondNumber()
        {
            try
            {
                Console.WriteLine("Please enter in a number.");
                string hold = Console.ReadLine();
                double value;
                if (double.TryParse(hold, out value))
                {
                    numberList.Add(value);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch
            {
                Console.WriteLine("Please enter only one number right now.");
                GetSecondNumber();
            }
        }

        private  void GetOperation()
        {
            try
            {
                Console.WriteLine("Please enter in a operation");
                char hold = Convert.ToChar(Console.ReadLine());

                if (ValidOperatorCheck(hold))
                {
                    operationList.Add(hold);
                }
                else
                {
                    throw new NotImplementedException();
                }

                if (hold == '=')
                {
                    equalPressed = true;
                }
            }
            catch
            {
                Console.WriteLine("Please enter only one of these operations: +  -  *  / \n Choose = to end and find the answer");
                GetOperation();
            }
        }

        private  bool ValidOperatorCheck(char hold)
        {
            if (hold.Equals('+'))
            {
                return true;
            }
            if (hold.Equals('-'))
            {
                return true;
            }
            if (hold.Equals('*'))
            {
                return true;
            }
            if (hold.Equals('/'))
            {
                return true;
            }
            if (hold.Equals('='))
            {
                return true;
            }
            return false;
        }
    }
}
