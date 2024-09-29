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
            return ((Alumno)c1).Nombre.CompareTo(((Alumno)c2).Nombre) == 0;
        }

        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).Nombre.CompareTo(((Alumno)c2).Nombre) == 1;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).Nombre.CompareTo(((Alumno)c2).Nombre) == -1;
        }
    }
}
