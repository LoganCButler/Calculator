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
        
        private static int inputA;
        private static int inputB;
        private static string operation;

        public static void Main(string[] args)
        {
            try
            {
                GetFirstNumber();
                GetOperation();
                GetSecondNumber();
                DoTheMath();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private static void DoTheMath()
        {
            CalculatorLogic x = new CalculatorLogic();
            x.Calc(inputA, inputB, operation);
            Console.WriteLine("the answer is " + x.answer);
            Console.ReadLine();
        }

        private static void GetSecondNumber()
        {
            try
            {

                Console.WriteLine("Please enter in your second number.");
                string hold = Console.ReadLine();
                int value;
                if (int.TryParse(hold, out value))
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
                Console.WriteLine("Please enter only one integer right now.");
                GetSecondNumber();
            }
        }

        private static void GetOperation()
        {
            try
            {
                Console.WriteLine("Please enter in your operation");
                string hold = Console.ReadLine();
                
                if (ValidOperator(hold))
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

        private static bool ValidOperator(string hold)
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

        private static void GetFirstNumber()
        {
            try
            {
                
                Console.WriteLine("Please enter in your first number.");
                string hold = Console.ReadLine();
                int value;
                if (int.TryParse(hold, out value))
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
                Console.WriteLine("Please enter only one integer right now.");
                GetFirstNumber();
            }
        }
    }
}
