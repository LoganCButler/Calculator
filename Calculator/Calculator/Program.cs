using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App;

namespace Calculator
{
    class Program
    {
        
        private static double inputA;
        private static double inputB;
        private static string operation;

        public static void Main(string[] args)
        {
                GetFirstNumber();
                GetOperation();
                GetSecondNumber();
                DoTheMath();
        }

        private static void GetFirstNumber()
        {
            try
            {
                Console.WriteLine("Please enter in your first number.");
                string hold = Console.ReadLine();
                double value;
                if (double.TryParse(hold, out value))
                {
                    inputA = value;
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

        private static void GetSecondNumber()
        {
            try
            {
                Console.WriteLine("Please enter in your second number.");
                string hold = Console.ReadLine();
                double value;
                if (double.TryParse(hold, out value))
                {
                    inputB = value;
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

        private static void GetOperation()
        {
            try
            {
                Console.WriteLine("Please enter in your operation");
                string hold = Console.ReadLine();

                if (ValidOperatorCheck(hold))
                {
                    operation = hold;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch
            {
                Console.WriteLine("Please enter only one of these operations: +  -  *  / ");
                GetOperation();
            }
        }

        private static void DoTheMath()
        {
            CalculatorLogic x = new CalculatorLogic();
            x.Calc(inputA, inputB, operation);
            Console.WriteLine("Your problem of {0} {1} {2} is {3}.", inputA, operation, inputB, x.answer);
            Console.ReadLine();
        }

        private static bool ValidOperatorCheck(string hold)
        {
            if (hold.IndexOf("+") > -1)
            {
                return true;
            }
            if (hold.IndexOf("-") > -1)
            {
                return true;
            }
            if (hold.IndexOf("*") > -1)
            {
                return true;
            }
            if (hold.IndexOf("/") > -1)
            {
                return true;
            }
            return false;
        }
        
    }
}
