using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class CompararProfesorPorAntiguedad : Strategy
    {
        public CompararProfesorPorAntiguedad() { }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Profesor)c1).Antiguedad.CompareTo(((Profesor)c2).Antiguedad) == 0;
        }

        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Profesor)c1).Antiguedad.CompareTo(((Profesor)c2).Antiguedad) == 1;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Profesor)c1).Antiguedad.CompareTo(((Profesor)c2).Antiguedad) == -1;
        }
    }
}
