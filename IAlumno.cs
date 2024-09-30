using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    interface IAlumno : Comparable
    {
        void setStrategy(Strategy newStrategy);
        int getCalificacion();
        void prestarAtencion();
        void distraerse();
        void update(string accion);
        int responderPregunta(int pregunta);
        void setCalificacion(int c);
        string getName();
        int getLegajo();
        int getDNI();
        double getPromedio();
        bool sosIgual(Comparable n);
        bool sosMenor(Comparable n);
        bool sosMayor(Comparable n);
        string mostrarCalificacion();
    }
}
