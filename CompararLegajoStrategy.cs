using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class CompararLegajoStrategy : Strategy
    {
        public CompararLegajoStrategy() { }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getLegajo().CompareTo(((IAlumno)c2).getLegajo()) == 0;
        }

        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getLegajo().CompareTo(((IAlumno)c2).getLegajo()) == 0;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getLegajo().CompareTo(((IAlumno)c2).getLegajo()) == -1;
        }
    }
}
