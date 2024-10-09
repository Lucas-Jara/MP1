using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class ClaveValor<TClave, TValor> : IComparable<ClaveValor<TClave, TValor>>
    where TClave : IComparable<TClave>
    where TValor : IComparable<TValor>
    {
        private TClave _clave;
        private TValor _valor;

        public ClaveValor(TClave c, TValor v)
        {
            this._clave = c;
            this._valor = v;
        }

        public TClave clave
        {
            get
            {
                return _clave;
            }
        }

        public TValor valor
        {
            get
            {
                return _valor;
            }
        }

        public bool sosIgual(ClaveValor<TClave, TValor> otro)
        {
            return this.clave.CompareTo(otro.clave) == 0;
        }

        public bool sosMenor(ClaveValor<TClave, TValor> otro)
        {
            return this.clave.CompareTo(otro.clave) < 0;
        }

        public bool sosMayor(ClaveValor<TClave, TValor> otro)
        {
            return this.clave.CompareTo(otro.clave) > 0;
        }

        public override string ToString()
        {
            return this.valor.ToString();
        }

        public int CompareTo(ClaveValor<TClave, TValor> otro)
        {
            return this.clave.CompareTo(otro.clave);
        }
    }

}
