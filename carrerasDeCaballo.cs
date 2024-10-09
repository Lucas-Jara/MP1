using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    internal class CarrerasDeCaballo : JuegoDeCartas
    {
        public CarrerasDeCaballo(List<Player> players) : base(players)
        {
        }

        public override bool checkGanador(Player p)
        {
            return (p.getPuntos() > 50);
        }
        public override void jugarUnaMano()
        {
            elegirPalo();

            bool hayGanador = false;

            foreach (Carta carta in mazo)
            {
                Console.WriteLine("Carta: " + carta.ToString() + "\n");
                
                foreach (PlayerPalo player in players)
                {
                    if (hayGanador) break;

                    if (carta.getClave() == player.getPalo())
                    {
                        player.setPuntos(carta.getValor());

                        if (checkGanador(player))
                        {
                            Console.WriteLine("¡El jugador {0} ha ganado!", player.getNombre());
                            hayGanador = true;
                            break;
                        }
                    }

                    mostrarResultado(player);
                }

                System.Threading.Thread.Sleep(800);



                if (!hayGanador) Console.Clear();
                else break;
            }
        }
        public void mostrarResultado(PlayerPalo p)
        {
            Console.WriteLine("Jugador: {0}, Puntos: {1}, Palo: {2}", p.getNombre(), p.getPuntos(), p.getPalo());
            Console.WriteLine(string.Concat(Enumerable.Repeat(" ", p.getPuntos())) +
                "            ,-^,\r\n" + string.Concat(Enumerable.Repeat(" ", p.getPuntos())) +
                "      _ ___/ /\\|\r\n" + string.Concat(Enumerable.Repeat(" ", p.getPuntos())) +
                "  ,:`( )__,  ) ~\r\n" + string.Concat(Enumerable.Repeat(" ", p.getPuntos())) +
                " //  //   '--;\r\n" + string.Concat(Enumerable.Repeat(" ", p.getPuntos())) +
                " '   \\     | ^\r\n" + string.Concat(Enumerable.Repeat("-", p.getPuntos())) +
                "------^----^-----");
        }
        public void elegirPalo()
        {
            foreach(PlayerPalo p in players)
            {
                    Console.WriteLine("Jugador: {0}: ", p.getNombre());
                    Console.WriteLine("[1] - Copa");
                    Console.WriteLine("[2] - Espada");
                    Console.WriteLine("[3] - Oro");
                    Console.WriteLine("[4] - Basto");
                    Console.WriteLine("Elija una opción: ");

                    int opcion = int.Parse(Console.ReadLine());

                    switch(opcion)
                    {
                        case 1: p.setPalo("copa"); break;
                        case 2: p.setPalo("espada"); break;
                        case 3: p.setPalo("oro"); break;
                        case 4: p.setPalo("basto"); break;
                        default:
                            Console.WriteLine("Ingrese una opción valida: ");
                            opcion = int.Parse(Console.ReadLine());
                            break;
                }
            }
        }

    }
}
