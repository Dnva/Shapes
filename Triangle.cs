using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesvid
{
    class Triangle : Ishape
    {
        public int Height { get; set; } = 15;
        public int Width { get; set; } = 10;

        public double GetArea()
        {
            return Height * Width / 2.0;

        }


    }
}
