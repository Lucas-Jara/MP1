using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class FabricaDeNumeros : Fabrica
    {
        private LectorDeDatos ld = new LectorDeDatos();
        private GeneradorDeDatos gd = new GeneradorDeDatos();

        public FabricaDeNumeros() { }

        public override Comparable crearAleatorio()
        {
            int n = gd.numeroAleatorio(15);
            return new Numero(n);
        }

        public override Comparable crearPorTeclado()
        {
            int n = ld.numeroPorTeclado();
            return new Numero(n);
        }
    }
}
