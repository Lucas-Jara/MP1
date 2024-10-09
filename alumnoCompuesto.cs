using System;
using System.Collections;
using System.Collections.Generic;

namespace MP1
{
    internal class AlumnoCompuesto : Comparable
    {
        private List<IAlumno> alumnos;
        public AlumnoCompuesto() {
            alumnos = new List<IAlumno>();
        }

        public void agregar(IAlumno a)
        {
            alumnos.Add(a);
        }

        public bool contiene(IAlumno a)
        {
            foreach (IAlumno elem in alumnos)
            {
                if (a == elem)
                {
                    return true;
                }
            }
            return false;
        }

        public void eliminar(IAlumno a)
        {
            if(contiene(a))
            {
                alumnos.Remove(a);
            }
        }
        public void getNombre()
        {

            foreach(IAlumno alumnno in alumnos)
            {
                Console.WriteLine(alumnno.getNombre());
            }

        }

        public void responderPregunta()
        {
            Console.WriteLine(new Random().Next(1, 10));
        }

        public void setCalificacion(int c)
        {
            foreach (IAlumno alumnno in alumnos)
            {
                alumnno.setCalificacion(c);
            }
        }
        public void mostrarCalificacion()
        {
            foreach (IAlumno alumnno in alumnos)
            {
                Console.WriteLine(alumnno.mostrarCalificacion());
            }
        }
        public bool sosIgual(Comparable n)
        {
            foreach (IAlumno alumnno in alumnos)
            {
                if (n.sosIgual(alumnno)) return true;
            }
            return false;
        }
        public bool sosMenor(Comparable n)
        {
            foreach (IAlumno alumnno in alumnos)
            {
                if (n.sosMenor(alumnno)) return true;
            }
            return false;
        }
        public bool sosMayor(Comparable n)
        {
            foreach (IAlumno alumnno in alumnos)
            {
                if (n.sosMayor(alumnno)) return true;
            }
            return false;
        }
    }
}
