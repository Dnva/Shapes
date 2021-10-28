using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesvid
{
    class Square : Ishape
    {
        public int Side { get; set; } = 10; // property kan hålla och ta emot värde.
       public double GetArea()
        {
            return Side * Side;
        }
        


    }

        
}
