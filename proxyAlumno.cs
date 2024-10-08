using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class ProxyAlumno : IAlumno
    {
        Alumno alumno;

        public ProxyAlumno(Alumno alumno)
        {
            this.alumno = alumno;
        }

        public int getDNI()
        {
            return alumno.getDNI();
        }

        public int getLegajo()
        {
            return alumno.getLegajo();
        }

        public string getNombre()
        {
            return alumno.getNombre();
        }

        public double getPromedio()
        {
            return alumno.getPromedio();
        }
        public int getCalificacion()
        {
            return alumno.getCalificacion();
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
        public void setCalificacion(int calificacion)
        {
            if(alumno == null)
            {
                alumno.setCalificacion(getCalificacion());
            }
            alumno.setCalificacion(calificacion);
        }

        public int responderPregunta(int pregunta)
        {
            if(alumno == null)
            {
                alumno = new Alumno(alumno.getNombre(), alumno.getDNI(), alumno.getLegajo(), alumno.getPromedio());
                alumno.setCalificacion(alumno.getCalificacion());
            }

            return alumno.responderPregunta(pregunta);
        }

        public void setStrategy(Strategy newStrategy)
        {
            alumno.setStrategy(newStrategy);
        }

        public void prestarAtencion()
        {
            alumno.prestarAtencion();
        }

        public void distraerse()
        {
            alumno.distraerse();
        }

        public void update(string accion)
        {
            alumno.update(accion);
        }

        public bool sosIgual(Comparable n)
        {
            return alumno.sosIgual(n);
        }

        public bool sosMenor(Comparable n)
        {
            return alumno.sosMenor(n);
        }

        public bool sosMayor(Comparable n)
        {
            return alumno.sosMayor(n);
        }

        public string mostrarCalificacion()
        {
            return alumno.mostrarCalificacion();
        }
    }
}
