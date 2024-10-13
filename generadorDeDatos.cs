using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class GeneradorDeDatos : Manejador
    {
        private static GeneradorDeDatos generadorDeDatos;
        private GeneradorDeDatos(Manejador m): base(m) {}

        public static GeneradorDeDatos getInstance(Manejador m)
        {
            if(generadorDeDatos == null)
            {
                generadorDeDatos = new GeneradorDeDatos(m);
            }
            return generadorDeDatos;
        }

        public override int numeroAleatorio(int max)
        {
            return new Random().Next(1, max);
        }

        public override string stringAleatorio(int cant)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(cant);

            for (int i = 0; i < cant; i++)
            {
                result.Append(chars[new Random().Next(chars.Length)]);
            }

            return result.ToString();
        }
    }
}
