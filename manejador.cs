using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    abstract class Manejador
    {
        Manejador manejador;

        public Manejador(Manejador m)
        {
            manejador = m;
        }
        public virtual int numeroAleatorio(int max)
        {
            return manejador.numeroAleatorio(max);
        }
        public virtual int numeroPorTeclado()
        {
            return manejador.numeroPorTeclado();
        }
        public virtual string stringPorTeclado()
        {
            return manejador.stringPorTeclado();
        }
        public virtual string stringAleatorio(int cant)
        {
            return manejador.stringAleatorio(cant);
        }
        public virtual double numeroDesdeArchivo(double max)
        {
            return manejador.numeroDesdeArchivo(max);
        }
        public virtual string stringDesdeArchivo(int cant)
        {
            return manejador.stringDesdeArchivo(cant);
        }
    }
}
