using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class ProxyAlumno : IAlumnoReal
    {
        IAlumno alumno;

        public ProxyAlumno() { }
        public ProxyAlumno(IAlumno alumno)
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

        public int responderPregunta(int pregunta)
        {
            if(alumno == null)
            {
                Fabrica fabricaDeAlumnos = new FabricaDeAlumnos();
                alumno = (IAlumno)fabricaDeAlumnos.crearAleatorio();
            }

            return alumno.responderPregunta(pregunta);
        }
    }
}
