using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Persona : Comparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string n, int d)
        {
            nombre = n;
            dni = d;
        }


        protected string getNombre()
        {
            return nombre;
        }
        protected void setNombre(string n)
        {
            nombre = n;
        }

        protected int getDNI()
        {
            return dni;
        }
        protected void setDNI(int n)
        {
            dni = n;
        }

        public virtual bool sosIgual(Comparable c)
        {
            return dni == ((Persona)c).dni;
        }

        public virtual bool sosMenor(Comparable c)
        {
            return dni > ((Persona)c).dni;

        }

        public virtual bool sosMayor(Comparable c)
        {
            return dni < ((Persona)c).dni;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + " DNI: " + dni;
        }
    }
}
