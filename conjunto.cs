using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Conjunto : Coleccionable, Iterable
    {
        public List<Comparable> lista;
        private LlenarColeccionable? strategy;

        public Conjunto()
        {
            this.lista = new List<Comparable>();
        }

        public int cuantos()
        {
            return lista.Count;
        }

        public Comparable minimo()
        {
            Comparable m = (Comparable)lista[0];
            foreach (Comparable n in lista)
            {
                if (m.sosMenor(n))
                {
                    m = n;
                }
            }
            return m;
        }

        public Comparable maximo()
        {
            Comparable m = (Comparable)lista[0];
            foreach (Comparable n in lista)
            {
                if (m.sosMayor(n))
                {
                    m = n;
                }
            }
            return m;
        }

        public void agregar(Comparable elem)
        {
            if (!this.contiene(elem))
            {
                lista.Add(elem);
            }
        }

        public bool contiene(Comparable elem)
        {
            foreach (Comparable e in lista)
            {
                if (e.sosIgual(elem)) return true;
            }

            return false;
        }

        public void SetLlenarColeccionable(LlenarColeccionable newStrategy)
        {
            strategy = newStrategy;
        }

        public void llenarColeccionable()
        {
            strategy.llenar(lista);
        }
        public Iterador crearIterador()
        {
            return new IteratorConjunto(lista);
        }
    }
}
