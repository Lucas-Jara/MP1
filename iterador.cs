using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        object actual();
    }
}
