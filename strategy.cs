using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    interface Strategy
    {
        bool sosMenor(Comparable c1, Comparable c2);
        bool sosIgual(Comparable c1, Comparable c2);
        bool sosMayor(Comparable c1, Comparable c2);
    }
}
