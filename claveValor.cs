using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class ClaveValor : Comparable
    {
        private Comparable _clave;
        private Comparable _valor;

        public ClaveValor(Comparable c, Comparable v)
        {
            this._clave = c;
            this._valor = v;
        }

        public Comparable clave
        {
            get
            {
                return _clave;
            }
        }

        public Comparable valor
        {
            get
            {
                return _valor;
            }
        }

        public virtual bool sosIgual(Comparable c)
        {
            return this.clave == c;
        }

        public virtual bool sosMenor(Comparable c)
        {
            return this.clave.sosMenor(((ClaveValor)c).clave);

        }

        public virtual bool sosMayor(Comparable c)
        {
            return this.clave.sosMayor(((ClaveValor)c).clave);
        }

        public override string ToString()
        {
            return this.valor.ToString();
        }
    }
}
