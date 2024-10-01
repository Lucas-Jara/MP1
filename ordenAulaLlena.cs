using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class OrdenAulaLlena : OrdenEnAula1
    {
        Aula aula;

        public OrdenAulaLlena(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar() {
            aula.claseLista();
        }
    }
}
