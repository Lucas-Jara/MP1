using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Persona : Comparable
    {
        private string nombre;
        private int dni;

        public Persona(string n, int d)
        {
            nombre = n;
            dni = d;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public int DNI
        {
            get
            {
                return dni;
            }
        }

        public virtual bool sosIgual(Comparable c)
        {
            return DNI == ((Persona)c).DNI;
        }

        public virtual bool sosMenor(Comparable c)
        {
            return DNI > ((Persona)c).DNI;

        }

        public virtual bool sosMayor(Comparable c)
        {
            return DNI < ((Persona)c).DNI;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " DNI: " + DNI;
        }
    }
}
