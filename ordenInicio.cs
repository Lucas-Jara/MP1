using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class OrdenInicio : OrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar()
        {
            aula.comenzar();
        }
    }
}
