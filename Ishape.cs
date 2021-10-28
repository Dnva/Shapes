using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapesvid
{
    interface Ishape
    {
        public double GetArea(); //ett kontrakt som använder som "blueprint" för andra klasser som ärver, sällan måsvingar.
        

    }
}
