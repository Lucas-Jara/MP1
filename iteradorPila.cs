using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class IteradorPila : Iterador
    {
        private List<Comparable> lista;
        private int posicionActual = 0;

        public IteradorPila()
        {
            this.lista = new List<Comparable>();
        }

        public IteradorPila(List<Comparable> lista)
        {
            this.lista = lista;
        }

        public object actual()
        {
            return lista[posicionActual];
        }

        public bool fin()
        {
            return lista.Count <= posicionActual;
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
