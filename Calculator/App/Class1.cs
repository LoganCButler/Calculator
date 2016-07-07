using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class CalculatorLogic
    {
        
        public int answer { get; set; }

        public void CalcAdd(int a, int b)
        {
            answer = a + b; 
        }
    }
}
