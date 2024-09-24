using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Numero : Comparable
    {
        int valor;

        public Numero(int v)
        {
            valor = v;
        }
        public int getValor()
        {
            return valor;
        }

        public bool sosIgual(Comparable c)
        {
            Numero n = (Numero)c;
            if (n.getValor() == valor) return true;
            return false;
        }

        public bool sosMenor(Comparable c)
        {
            Numero n = (Numero)c;
            if (n.getValor() > valor) return true;
            return false;
        }

        public bool sosMayor(Comparable c)
        {
            Numero n = (Numero)c;
            if (n.getValor() < valor) return true;
            return false;
        }

        public override string ToString()
        {
            return string.Format("Valor: {0}", valor);
        }
    }
}
