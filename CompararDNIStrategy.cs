using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class CompararDNIStrategy : Strategy
    {
        public CompararDNIStrategy() { }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getDNI().CompareTo(((IAlumno)c2).getDNI()) == 0;
        }

        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getDNI().CompareTo(((IAlumno)c2).getDNI()) == 1;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getDNI().CompareTo(((IAlumno)c2).getDNI()) == -1;
        }
    }
}
