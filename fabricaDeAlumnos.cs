using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class FabricaDeAlumnos : Fabrica
    {
        private LectorDeDatos ld = new LectorDeDatos();
        private GeneradorDeDatos gd = new GeneradorDeDatos();

        public FabricaDeAlumnos() { }

        public override Comparable crearAleatorio()
        {
            return new Alumno("alum1", 5, 6, 8.2);
        }

        public override Comparable crearPorTeclado()
        {
            return new Alumno("alum2", 5, 6, 8.2);
        }
    }
}
