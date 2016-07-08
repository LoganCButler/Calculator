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

        

        public static void Main(string[] args)
        {
            
            string continueOn = "y";
            do
            {
                CalculatorLogic MathProblem = new CalculatorLogic();
                MathProblem.GetFirstNumber();
                MathProblem.GetStringOfOperations();
                MathProblem.DoTheMath();
                Console.WriteLine(MathProblem.StringAnswerGenerator());

                
                Console.WriteLine("Would you like to do another problem?\n y: yes, any key: no");
                continueOn = Console.ReadLine();
            } while (continueOn.Contains("y"));
        }

       

              

        

        
        
        
    }
}
