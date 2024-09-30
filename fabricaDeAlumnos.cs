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
            string n = gd.stringAleatorio(5);
            int d = gd.numeroAleatorio(10);
            int l = gd.numeroAleatorio(10);
            double p = gd.numeroAleatorio(10) - 0.5;
            return new Alumno(n, d, l, p);
        }

        public override Comparable crearPorTeclado()
        {
            string n = ld.stringPorTeclado();
            int d = ld.numeroPorTeclado();
            int l = ld.numeroPorTeclado();
            double p = ld.numeroPorTeclado() - 0.5;
            return new Alumno(n, d, l, p);
        }
    }
}
