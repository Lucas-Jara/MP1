using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Alumno : Persona
    {
        private int legajo;
        private double promedio;

        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            legajo = l;
            promedio = p;
        }

        public int Legajo
        {
            get
            {
                return legajo;
            }
        }

        public double Promedio
        {
            get
            {
                return promedio;
            }
        }

        public override bool sosIgual(Comparable c)
        {
            return Legajo == ((Alumno)c).Legajo;
        }

        public override bool sosMenor(Comparable c)
        {
            return Legajo > ((Alumno)c).Legajo;

        }

        public override bool sosMayor(Comparable c)
        {
            return Legajo < ((Alumno)c).Legajo;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " DNI: " + DNI + " Legajo: " + Legajo + " Promedio: " + Promedio;
        }
    }
}
