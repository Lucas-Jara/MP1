using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    abstract class Decorator : IAlumno
    {
        protected IAlumno alumno;
        public Decorator(IAlumno a)
        {
            this.alumno = a;
        }

        public abstract string mostrarCalificacion();

        public void distraerse()
        {
            alumno.distraerse();
        }
        public int getCalificacion()
        {
           return alumno.getCalificacion();
        }
        public string getNombre()
        {
            return alumno.getNombre();
        }

        public void setDNI(int dNI)
        {
            alumno.setDNI(dNI);
        }

        public void setLegajo(int legajo)
        {
            alumno.setLegajo(legajo);
        }

        public void setNombre(string name)
        {
            alumno.setNombre(name);
        }

        public void setPromedio(double promedio)
        {
            alumno.setPromedio(promedio);
        }
        public int getDNI()
        {
            return alumno.getDNI();
        }
        public int getLegajo()
        {
            return alumno.getLegajo();
        }
        public double getPromedio()
        {
            return alumno.getPromedio();
        }
        public void prestarAtencion()
        {
            alumno.prestarAtencion();
        }
        public int responderPregunta(int pregunta)
        {
            return alumno.responderPregunta(pregunta);
        }
        public void setCalificacion(int c)
        {
            alumno.setCalificacion(c);
        }
        public void setStrategy(Strategy newStrategy)
        {
            alumno.setStrategy(newStrategy);
        }
        public bool sosIgual(Comparable n)
        {
            return alumno.sosIgual(n);
        }
        public bool sosMayor(Comparable n)
        {
            return alumno.sosMayor(n);
        }
        public bool sosMenor(Comparable n)
        {
            return alumno.sosMenor(n);
        }
        public void update(string accion)
        {
            alumno.update(accion);
        }
    }
}
