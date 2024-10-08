using System;
using System.Collections;
using System.Collections.Generic;

namespace MP1
{
    class Cola : Coleccionable, Iterable, Ordenable
    {
        public List<Comparable> lista;
        private LlenarColeccionable strategy;

        private OrdenInicio? ordenInicio;
        private OrdenLlegaAlumno? ordenLlegaAlumno;
        private OrdenAulaLlena? ordenAulaLlena;
        public Cola()
        {
            this.lista = new List<Comparable>();
        }

        public int cuantos()
        {
            return lista.Count;
        }

        public Comparable minimo()
        {
            Comparable m = lista[0];
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
            Comparable m = lista[0];
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
            if (cuantos() == 0) ordenInicio.ejecutar();
            else ordenLlegaAlumno.ejecutar(c);
            lista.Add(c);
            if (cuantos() == 40) ordenAulaLlena.ejecutar();
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
            return new IteradorCola(lista);
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
