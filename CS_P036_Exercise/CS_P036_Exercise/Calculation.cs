using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P036_Exercise
{
    class Calculation
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public int Volume()
        {
            int volume;

            volume = Height * Width * Length;

            return volume;
        }


    }
}
