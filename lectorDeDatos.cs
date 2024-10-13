using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class LectorDeDatos : Manejador
    {
        public LectorDeDatos(Manejador m) :base(m) { }

        public override int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        public override string stringPorTeclado()
        {
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            return palabra;
        }
    }
}
