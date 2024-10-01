using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class OrdenLlegaAlumno : OrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar(Comparable c)
        {
            Fabrica fabricaDeAlumnos = new FabricaDeAlumnos();
            Alumno alumno = (Alumno)fabricaDeAlumnos.crearAleatorio();
            aula.nuevoAlumno(alumno);
        }
    }
}
