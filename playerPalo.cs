using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class PlayerPalo : Player
    {
        private string palo;
        public PlayerPalo(string n, int d) : base(n, d){}

        public string getPalo() {  return palo; }

        public void setPalo(string n) { palo = n; }
    }
}
