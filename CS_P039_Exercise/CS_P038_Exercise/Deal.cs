using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P039_Exercise
{
    class Deal
    {
        public int Pizza(decimal friends, decimal slices = 4)
        {
            // Calculate how many whole pizza you need at the party
            // One whole pizza has 8 slices
            // +1 is about you
            int numPizza = Convert.ToInt16(Math.Ceiling(((friends + 1) * slices) / 8)); 
            
            return numPizza;
        }
    }
}
