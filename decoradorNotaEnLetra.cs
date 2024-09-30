using System;
using System.Collections.Generic;

namespace MP1
{
    internal class DecoradorNotaEnLetra : Decorator
    {
        private List<string> _num = new List<string>() {"CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
        public DecoradorNotaEnLetra(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            return alumno.getName() + "\t" + alumno.getCalificacion() + " (" + _num[alumno.getCalificacion()] + ")";
        }
    }
}
