using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class GeneradorDeDatos
    {
        string abc = "abcdefghijklmnopqrstuvqxyz";

        public GeneradorDeDatos() { }

        public int numeroAleatorio(int max)
        {
            return new Random().Next(1, max);
        }

        public string stringAleatorio(int cant)
        {
            string salida = "";
            int rm = new Random().Next(1, 26);

            for (int i = 0; i < rm; i++)
            {
                salida += abc[i];
            }

            return salida;
        }
    }
}
