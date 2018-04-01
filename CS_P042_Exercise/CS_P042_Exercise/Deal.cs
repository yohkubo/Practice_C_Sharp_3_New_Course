using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P042_Exercise
{
    public static class  Deal
    {

        public static void Divide(int num, out int result)
        {
            result = num / 2;
        }

        public static void Divide(int num, int times, out int result)
        {
            result = num / Convert.ToInt16(Math.Pow(2, Convert.ToDouble(times)));
        }
        
    }
}
