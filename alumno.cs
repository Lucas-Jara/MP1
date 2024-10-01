using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Alumno : Persona, Observador, IAlumno
    {
        private int legajo;
        private double promedio;
        private int calificacion;
        private Strategy strategy = new CompararDNIStrategy();

        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public void setStrategy(Strategy newStrategy)
        {
            strategy = newStrategy;
        }

        public void setCalificacion(int c)
        {
            calificacion = c;
        }

        public override bool sosIgual(Comparable c)
        {
            return strategy.sosIgual(this, c);
        }

        public override bool sosMenor(Comparable c)
        {
            return strategy.sosMenor(this, c);

        }

        public override bool sosMayor(Comparable c)
        {
            return strategy.sosMayor(this, c);
        }

        public int getCalificacion()
        {
            return this.calificacion;
        }
        public void prestarAtencion()
        {
            Console.WriteLine("Prestando atención");
        }

        public void distraerse()
        {
            Console.WriteLine("Dibujando en el margen de la carpeta”, “Tirando aviones de papel");
        }
        public void update(string accion)
        {
            if (accion == "hablar")
            {
                prestarAtencion();
            }
            else if (accion == "escribir")
            {
                distraerse();
            }
        }
        public virtual int responderPregunta(int pregunta)
        {
            return new Random().Next(1,3);
        }


        public string getNombre()
        {
            return this.nombre;
        }
        public int getLegajo()
        {
            return this.legajo;
        }
        public int getDNI()
        {
            return this.dni;
        }
        public double getPromedio()
        {
            return this.promedio;
        }

        public void setDNI(int d)
        {
            dni = d;
        }

        public void setLegajo(int l)
        {
            legajo = l;
        }

        public void setNombre(string n)
        {
            nombre = n;
        }

        public void setPromedio(double p)
        {
            promedio = p;
        }
        public string mostrarCalificacion()
        {
            return this.getNombre() + " - " + this.getCalificacion();
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + " DNI: " + this.dni + " Legajo: " + this.legajo + " Promedio: " + this.promedio;
        }
    }
}
