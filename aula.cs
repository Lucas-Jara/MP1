using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class Aula
    {
        private Teacher teachet;

        public Aula() { }

        public void comenzar()
        {
            Console.WriteLine("Comenzamos la clase!!!");
            teachet = new Teacher();
        }

        public void nuevoAlumno(Alumno alumno) 
        {
            Student student = new AlumnoAdapterToStudent(alumno);
            teachet.goToClass(student);
        }

        public void claseLista()
        {
            teachet.teachingAClass();
        }
    }
}
