using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesvid
{
    class Circle : Ishape
    {
        public int bredd { get; set; } = 20;

        public double GetArea()
        {
            return bredd * Math.PI;

        }
    }
}
