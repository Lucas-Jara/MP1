using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class CompararNombreStrategy : Strategy
    {
        public CompararNombreStrategy() { }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getNombre().CompareTo(((IAlumno)c2).getNombre()) == 0;
        }

        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getNombre().CompareTo(((IAlumno)c2).getNombre()) == 1;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getNombre().CompareTo(((IAlumno)c2).getNombre()) == -1;
        }
    }
}
