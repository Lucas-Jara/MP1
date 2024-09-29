using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class ColeccionMultiple : Coleccionable
    {
        private Pila pila;
        private Cola cola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            pila = p;
            cola = c;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public Comparable minimo()
        {
            Comparable minpila = pila.minimo();
            Comparable mincola = cola.minimo();
            if (minpila.sosMenor(mincola)) return minpila;
            return mincola;
        }

        public Comparable maximo()
        {
            Comparable maxpila = pila.maximo();
            Comparable maxcola = cola.maximo();
            if (maxpila.sosMayor(maxcola)) return maxpila;
            return maxcola;
        }

        public void agregar(Comparable c)
        {
            return;
        }

        public bool contiene(Comparable c)
        {
            if (pila.contiene(c) || cola.contiene(c)) return true;
            return false;
        }

        public Iterador crearIterador()
        {
            return new iteratorColeccionMultiple(new List<Comparable>());
        }
    }
}
