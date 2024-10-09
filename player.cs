using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class Player : Persona
    {
        public List<Carta> cartas;
        private int puntos = 0;
        public Player(string n, int d) : base(n, d)
        {
            cartas = new List<Carta>();
        }

        public List<Carta> getCartas() { return cartas; }
        public int getPuntos() { return puntos; }
        public void setPuntos(int s) { puntos += s; }

        public void agregar(Carta c)
        {
            cartas.Add(c);
        }

        public bool contiene(Carta c)
        {
            return cartas.Contains(c);
        }

        public void eliminar(Carta c) {
            if (cartas.Count > 0 && contiene(c)) {
                cartas.Remove(c);
            }
        }
    }
}
