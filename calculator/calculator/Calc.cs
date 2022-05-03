using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calc
    {
            public void Addition(int num1, int num2)
        {
            int sum = num1 + num2;
                Console.WriteLine("Addition of {0} + {1} = {2}", num1, num2, sum);
        }
    }
}
