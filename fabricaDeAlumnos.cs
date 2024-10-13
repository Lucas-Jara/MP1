﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class FabricaDeAlumnos : Fabrica
    {
        Manejador manejador;

        public FabricaDeAlumnos(Manejador m)
        {
            manejador = m;
        }

        public override Comparable crearAleatorio()
        {
            string n = manejador.stringAleatorio(5);
            int d = manejador.numeroAleatorio(10);
            int l = manejador.numeroAleatorio(10);
            double p = manejador.numeroAleatorio(10) - 0.5;
            return new Alumno(n, d, l, p);
        }

        public override Comparable crearPorTeclado()
        {
            string n = manejador.stringPorTeclado();
            int d = manejador.numeroPorTeclado();
            int l = manejador.numeroPorTeclado();
            double p = manejador.numeroPorTeclado() - 0.5;
            return new Alumno(n, d, l, p);
        }
    }
}
