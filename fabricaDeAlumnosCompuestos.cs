using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class FabricaDeAlumnosCompuestos : Fabrica
    {
        public FabricaDeAlumnosCompuestos() { }
        public override Comparable crearAleatorio()
        {
            return new AlumnoCompuesto();
        }

        public override Comparable crearPorTeclado()
        {
            return new AlumnoCompuesto();
        }
    }
}
