﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class iteratorColeccionMultiple : Iterador
    { 
        private List<Comparable> lista;
        private int posicionActual = 0;

        public iteratorColeccionMultiple()
        {
            this.lista = new List<Comparable>();
        }

        public iteratorColeccionMultiple(List<Comparable> lista)
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
