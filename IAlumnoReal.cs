using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    interface IAlumnoReal
    {
        string getNombre();
        void setNombre(string name);
        int getDNI();
        void setDNI(int dNI);
        int getLegajo();
        void setLegajo(int legajo);
        double getPromedio();
        void setPromedio(double promedio);
        int responderPregunta(int pregunta);
    }
}
