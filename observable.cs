using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    interface Observable
    {
        void add(Observador ob);
        void remove(Observador ob);
        void notify(string accion);
    }
}
