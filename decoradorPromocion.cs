using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class DecoradorPromocion : Decorator
    {
        public DecoradorPromocion(IAlumno a) : base(a) { }

    public override string mostrarCalificacion()
    {
            if(alumno.getCalificacion() > 6)
            {
                return alumno.getNombre() + "\t" + alumno.getCalificacion() + "(APROBADO)";
            }
            
            return alumno.getNombre() + "\t" + alumno.getCalificacion() + "(DESAPROBADO)";

        }
    }
}

