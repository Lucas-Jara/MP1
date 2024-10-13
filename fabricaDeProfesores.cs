using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class FabricaDeProfesores : Fabrica
    {
        private LectorDeDatos ld = new LectorDeDatos(null);
        private GeneradorDeDatos gd = GeneradorDeDatos.getInstance(null);

        public FabricaDeProfesores() { }

        public override Comparable crearAleatorio()
        {
            string n = gd.stringAleatorio(5);
            int d = gd.numeroAleatorio(40000000);
            int a = gd.numeroAleatorio(10);
            return new Profesor(n, d, a);
        }

        public override Comparable crearPorTeclado()
        {
            string n = ld.stringPorTeclado();
            int d = ld.numeroPorTeclado();
            int a = ld.numeroPorTeclado();
            return new Profesor(n, d, a);
        }
    }
}
