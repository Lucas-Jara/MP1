using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    abstract class JuegoDeCartas
    {
        public static List<Carta> mazo;
        public static List<Player>? players;
        public static int turno = 0;
        public JuegoDeCartas(List<Player> players)
        {
            mazo = new List<Carta>();
            JuegoDeCartas.players = players.ToList();
        }

        public virtual void mezclarMazo(List<Carta> mazoCartas)
        {
            Random rand = new Random();
            int n = mazoCartas.Count;

            for (int i = 0; i < n; i++)
            {
                int randomIndex = rand.Next(i, n);

                Carta temp = mazoCartas[i];
                mazoCartas[i] = mazoCartas[randomIndex];
                mazoCartas[randomIndex] = temp;
            }
        }

        public void siguienteTurno() { turno = (turno + 1) % 2; }
        public virtual Carta tomarCartaMazo()
        {
            Carta carta = mazo[0];
            mazo.Remove(carta);
            return carta;
        }

        public virtual Carta descartarCarta(Player p, int idx)
        {
            Carta temp = players[turno].cartas[idx];
            players[turno].eliminar(temp);
            return temp;
        }
        public virtual void repartirCartas() {
            for (int i = 0; i < players.Count; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Carta temp = mazo[j];
                    players[i].agregar(temp);
                    mazo.Remove(temp);
                }
            }

        }
        public abstract void jugarUnaMano();
        public abstract bool checkGanador(Player p);
        public virtual void reiniciarJuego()
        {
            mazo = new List<Carta>();
        }

        public virtual List<Carta> generarCartas()
        {
            string[] palos = { "copa", "espada", "oro", "basto" };

            foreach (string palo in palos)
            {
                for (int j = 1; j <= 12; j++)
                {
                    mazo.Add(new Carta(palo, j));
                }
            }
            return mazo;
        }
    }

}




