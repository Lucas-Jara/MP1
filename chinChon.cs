using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class ChinChon : JuegoDeCartas
    {
        private static List<Carta> cartasDescartadas;
        
        public ChinChon(List<Player> players) : base(players)
        {
            cartasDescartadas = new List<Carta>();
        }

        public override void repartirCartas()
        {
            players[0].agregar(new Carta("oro", 2));
            players[0].agregar(new Carta("oro", 4));
            players[0].agregar(new Carta("oro", 3));
            players[0].agregar(new Carta("espada", 10));
            players[0].agregar(new Carta("espada", 9));
            players[0].agregar(new Carta("espada", 12));
            players[0].agregar(new Carta("espada", 11));


            players[1].agregar(new Carta("basto", 2));
            players[1].agregar(new Carta("copa", 4));
            players[1].agregar(new Carta("oro", 3));
            players[1].agregar(new Carta("espada", 10));
            players[1].agregar(new Carta("copa", 9));
            players[1].agregar(new Carta("espada", 12));
            players[1].agregar(new Carta("espada", 11));
        }
        public override void jugarUnaMano()
        {
            bool hayGanador = false;

            while (!hayGanador)
            {
                mostrarCartaJugador(players[turno]);

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("[1] - Alzar del mazo");
                Console.WriteLine("[2] - Alzar del las cartas descartadas");
                Console.WriteLine("[3] - Chin-Chon");
                Console.Write("\nElige una opción: ");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("\nOpción inválida, intenta de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        if (mazo.Count > 0)
                        {
                            players[turno].agregar(tomarCartaMazo());
                        }
                        else
                        {
                            Console.WriteLine("El mazo está vacío, mezclando cartas descartadas...");
                            mezclarMazo(cartasDescartadas);
                        }
                        break;

                    case 2:
                        if (cartasDescartadas.Count > 0)
                        {
                            players[turno].agregar(cartasDescartadas.Last());
                            cartasDescartadas.RemoveAt(cartasDescartadas.Count - 1);
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay cartas descartadas. Elige otra opción.");
                            continue;
                        }
                        break;

                    case 3:
                        if (checkGanador(players[turno]))
                        {
                            Console.WriteLine("\n¡Felicidades, ganó el jugador: " + players[turno].getNombre() + "!\n");
                            hayGanador = true;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("\nCartas inválidas, sigue jugando.\n");
                            continue;
                        }
                }

                // Si no hay ganador, continúa el juego
                mostrarCartaJugador(players[turno]);

                // Descartar una carta
                int cartaADescartar;
                do
                {
                    Console.Write("\nElige una carta para descartar (1 al 8): ");
                }
                while (!int.TryParse(Console.ReadLine(), out cartaADescartar) || cartaADescartar <= 0 || cartaADescartar > 8);

                Carta cartaDescartada = descartarCarta(players[turno], cartaADescartar - 1);
                cartasDescartadas.Add(cartaDescartada);

                siguienteTurno(); // Cambia al siguiente jugador
            }
        }




        public void mostrarCartaJugador(Player p)
        {
            Console.WriteLine("Cartas del jugador: " + p.getNombre());
            foreach (Carta c in p.cartas)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public override bool checkGanador(Player p)
        {
            return EsEscalera(p.cartas) || EsTrio(p.cartas) || EsCombinacionValida(p.cartas);
        }

        public bool EsCombinacionValida(List<Carta> cartas)
        {
            if (cartas.Count < 5) return false;

            cartas = cartas.OrderBy(c => c.getValor()).ToList();

            var grupoPalo1 = cartas.Where(c => c.getClave() == cartas[0].getClave()).ToList();
            if (grupoPalo1.Count >= 3 && EsEscalera(grupoPalo1.Take(3).ToList()))
            {
                var grupoRestante = cartas.Except(grupoPalo1.Take(3)).ToList();
                if (EsEscalera(grupoRestante) || EsTrio(grupoRestante))
                {
                    return true;
                }
            }

            var grupoValor = cartas.GroupBy(c => c.getValor())
                                   .Where(g => g.Count() >= 3)
                                   .SelectMany(g => g)
                                   .ToList();
            if (grupoValor.Count == 3)
            {
                var grupoRestante = cartas.Except(grupoValor).ToList();
                if (EsEscalera(grupoRestante))
                {
                    return true;
                }
            }

            return false;
        }

        public bool EsEscalera(List<Carta> cartas)
        {
            if (cartas.Count < 2) return false;

            cartas = cartas.OrderBy(c => c.getValor()).ToList();

            if (!cartas.All(c => c.getClave() == cartas[0].getClave()))
            {
                return false;
            }

            for (int i = 1; i < cartas.Count; i++)
            {
                if (cartas[i].getValor() != cartas[i - 1].getValor() + 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool EsTrio(List<Carta> cartas)
        {
            if (cartas.Count != 3) return false;

            return cartas.All(c => c.getValor() == cartas[0].getValor());
        }



    }
}
