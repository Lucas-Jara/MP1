using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class Carta
    {
        string clave;
        int valor;
        public Carta(string c, int v) {
            clave = c;
            valor = v;
        }

        public string getClave() { return clave; }

        public int getValor() { return valor; }

        public override string ToString()
        {
            return valor + " de " + clave;
        }
    }
}
