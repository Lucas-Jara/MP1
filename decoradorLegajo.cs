using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class DecoradorLegajo : Decorator
    {
        public DecoradorLegajo(IAlumno a) : base(a) { }

        public override string mostrarCalificacion()
        {
            return alumno.getName() + " (" + alumno.getLegajo() + "/" + alumno.getCalificacion() + ")" + "\t" + alumno.getCalificacion();
        }
    }
}
