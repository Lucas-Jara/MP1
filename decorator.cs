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

        void IAlumno.distraerse()
        {
            alumno.distraerse();
        }
        int IAlumno.getCalificacion()
        {
           return alumno.getCalificacion();
        }
        string IAlumno.getName()
        {
            return alumno.getName();
        }
        int IAlumno.getDNI()
        {
            return alumno.getDNI();
        }
        int IAlumno.getLegajo()
        {
            return alumno.getLegajo();
        }
        public double getPromedio()
        {
            return alumno.getPromedio();
        }
        void IAlumno.prestarAtencion()
        {
            alumno.prestarAtencion();
        }
        int IAlumno.responderPregunta(int pregunta)
        {
            return alumno.responderPregunta(pregunta);
        }
        void IAlumno.setCalificacion(int c)
        {
            alumno.setCalificacion(c);
        }
        void IAlumno.setStrategy(Strategy newStrategy)
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
        void IAlumno.update(string accion)
        {
            alumno.update(accion);
        }
    }
}
