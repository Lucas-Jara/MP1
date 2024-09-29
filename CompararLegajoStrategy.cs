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
            return ((Alumno)c1).Legajo.CompareTo(((Alumno)c2).Legajo) == 0;
        }

        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).Legajo.CompareTo(((Alumno)c2).Legajo) == 1;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).Legajo.CompareTo(((Alumno)c2).Legajo) == -1;
        }
    }
}
