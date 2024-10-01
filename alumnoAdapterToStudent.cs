using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class AlumnoAdapterToStudent : Student
    {
        IAlumno a;
        public AlumnoAdapterToStudent(IAlumno a) {
        this.a = a;
        }
        public IAlumno Alumno
        {
            get { return a; }
            set { a = value; }
        }
        public bool equals(Student student)
        {
            return a.sosIgual(((AlumnoAdapterToStudent)student).Alumno);
        }

        public string getName()
        {
            return a.getNombre();
        }

        public bool greaterThan(Student student)
        {
            return a.sosMayor(((AlumnoAdapterToStudent)student).Alumno);
        }

        public bool lessThan(Student student)
        {
            return a.sosMenor(((AlumnoAdapterToStudent)student).Alumno);
        }

        public void setScore(int score)
        {
            a.setCalificacion(score);
        }

        public string showResult()
        {
            return a.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return a.responderPregunta(question);
        }
    }
}
