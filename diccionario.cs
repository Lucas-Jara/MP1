﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Diccionario : Coleccionable, Iterable, Ordenable
    {
        public Conjunto conjunto;
        private LlenarColeccionable? strategy;

        private OrdenInicio? ordenInicio;
        private OrdenLlegaAlumno? ordenLlegaAlumno;
        private OrdenAulaLlena? ordenAulaLlena;
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
            Comparable m = conjunto.lista[0];
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
            Comparable m = conjunto.lista[0];
            foreach (Comparable n in conjunto.lista)
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
            if (cuantos() == 0) ordenInicio.ejecutar();
            else ordenLlegaAlumno.ejecutar(c);
            conjunto.agregar(c);
            if (cuantos() == 40) ordenAulaLlena.ejecutar();
        }

        public Comparable valorDe(Comparable clave)
        {
            foreach (Comparable elemento in conjunto.lista)
            {
                if (clave.sosIgual(elemento))
                {
                    return elemento;
                }
            }
            return null;
        }

        public bool contiene(Comparable elem)
        {
            foreach (Comparable e in conjunto.lista)
            {
                if (e == elem) return true;
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

        public void setOrdenInicio(OrdenInicio aula)
        {
            ordenInicio = aula;
        }

        public void setOrdenLlegaAlumno(OrdenLlegaAlumno aula)
        {
            ordenLlegaAlumno = aula;
        }

        public void setOrdenAulaLlena(OrdenAulaLlena aula)
        {
            ordenAulaLlena = aula;
        }
    }
}
