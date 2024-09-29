using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class CompararPromedioStrategy : Strategy
    {
        public CompararPromedioStrategy() { }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).Promedio.CompareTo(((Alumno)c2).Promedio) == 0;
        }

        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).Promedio.CompareTo(((Alumno)c2).Promedio) == 1;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).Promedio.CompareTo(((Alumno)c2).Promedio) == -1;
        }
    }
}
