using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class FabricaDeAlumnosCompuestoDesdeDatos : Fabrica
    {
        Manejador manejador;

        public FabricaDeAlumnosCompuestoDesdeDatos(Manejador m)
        {
            manejador = m;
        }
        public override Comparable crearAleatorio()
        {
            string n = manejador.stringDesdeArchivo(5);
            double d = manejador.numeroDesdeArchivo(10.0); ;
            double l = manejador.numeroDesdeArchivo(10.0);
            double p = manejador.numeroDesdeArchivo(10.0);
            return new Alumno(n, Convert.ToInt32(d), Convert.ToInt32(l), p);
        }

        public override Comparable crearPorTeclado()
        {
            string n = manejador.stringPorTeclado();
            int d = manejador.numeroPorTeclado();
            int l = manejador.numeroPorTeclado();
            double p = manejador.numeroPorTeclado() - 0.5;
            return new Alumno(n, d, l, p);
        }
    }
}
