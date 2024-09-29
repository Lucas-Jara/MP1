using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class IteratorDiccionario : Iterador
    {
        private Conjunto conjunto;
        private int posicionActual = 0;


        public IteratorDiccionario(Conjunto conjunto)
        {
            this.conjunto = conjunto;
        }

        public object actual()
        {
            return conjunto.lista[posicionActual];
        }

        public bool fin()
        {
            return conjunto.cuantos() <= posicionActual;
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual += 1;
        }
    }
}