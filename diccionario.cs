using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Diccionario : Coleccionable, Iterable
    {
        public Conjunto conjunto;
        private LlenarColeccionable? strategy;

        public Diccionario()
        {
            this.conjunto = new Conjunto();
        }

        public int cuantos()
        {
            return conjunto.cuantos();
        }

        public Comparable minimo()
        {
            Comparable m = (Comparable)conjunto.lista[0];
            foreach (Comparable n in conjunto.lista)
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
            Comparable m = (Comparable)conjunto.lista[0];
            foreach (Comparable n in conjunto.lista)
            {
                if (m.sosMayor(n))
                {
                    m = n;
                }
            }
            return m;
        }

        public void agregar(Comparable valor)
        {
            ClaveValor nuevoElemento = new ClaveValor(new Numero(this.cuantos()), valor); // Valor po defecto
            conjunto.agregar(nuevoElemento);
        }

        public Comparable valorDe(Comparable clave)
        {
            foreach (ClaveValor elemento in conjunto.lista)
            {
                if (clave.sosIgual(elemento.clave))
                {
                    return elemento.valor;
                }
            }
            return null;
        }

        public bool contiene(Comparable elem)
        {
            foreach (ClaveValor e in conjunto.lista)
            {
                if (e.clave == elem) return true;
            }

            return false;
        }

        public void SetLlenarColeccionable(LlenarColeccionable newStrategy)
        {
            strategy = newStrategy;
        }

        public void llenarColeccionable()
        {
            strategy.llenar(conjunto.lista);
        }

        public Iterador crearIterador()
        {
            return new IteratorDiccionario(conjunto);
        }
    }
}
