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
            return ((Alumno)c1).DNI.CompareTo(((Alumno)c2).DNI) == 0;
        }

        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).DNI.CompareTo(((Alumno)c2).DNI) == 1;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).DNI.CompareTo(((Alumno)c2).DNI) == -1;
        }
    }
}
