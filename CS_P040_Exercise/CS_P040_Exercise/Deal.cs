using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P040_Exercise
{
    class Deal
    {
        public void Power(int num1, int num2)
        {
             int result = num1;

            for(int i=0; i<num2; i++)
            {
                result = result * num1;
            }

            Console.WriteLine("You inputed {0} and {1}. Then this multiplied " +
                "{0} to itself {1} times.\nResult: {2:N0}",
                num1, num2, result);
        }
    }
}
