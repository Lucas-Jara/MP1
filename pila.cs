﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Pila : Coleccionable, Iterable
    {
        public List<Comparable> lista;
        private LlenarColeccionable? strategy;

        public Pila()
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

        public void agregar(Comparable c)
        {
            lista.Add(c);
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable elem in lista)
            {
                if (c == elem)
                {
                    return true;
                }
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
            return new IteradorPila(lista);
        }
    }
}
