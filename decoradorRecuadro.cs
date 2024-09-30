using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class DecoradorRecuadro : Decorator
    {
        public DecoradorRecuadro(IAlumno a) : base(a) { }

        public override string mostrarCalificacion()
        {
            return "*********************************************\n*\t" + alumno.getName() + "\t" + alumno.getCalificacion() + "\n" + "*********************************************";
        }
    }
}
