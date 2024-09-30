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
        public int Calificacion
        {
            get
            {
                return calificacion;
            }
            set
            {
                this.calificacion = value;
            }
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

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + " DNI: " + this.DNI + " Legajo: " + this.Legajo + " Promedio: " + this.Promedio;
        }

        public string getName()
        {
            return this.Nombre;
        }
        public int getLegajo()
        {
            return this.Legajo;
        }
        public int getDNI()
        {
            return this.DNI;
        }
        public double getPromedio()
        {
            return this.Promedio;
        }
        public string mostrarCalificacion()
        {
            return this.getName() + " - " + this.getCalificacion();
        }
    }
}
