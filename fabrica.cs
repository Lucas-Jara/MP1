using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    abstract class Fabrica : FabricaDeComparables
    {

        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();

    }
}
