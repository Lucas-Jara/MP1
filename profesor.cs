using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP1
{
    class Profesor : Persona, Observable
    {
        private int antiguedad;
        public List<Observador> lista = new List<Observador>();

        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.antiguedad = a;
        }

        public int Antiguedad
        {
            get { return antiguedad; }
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algún tema");
            notify("hablar");
        }

        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarrón");
            notify("escribir");
        }

        public void add(Observador ob)
        {
            lista.Add(ob);
        }
        public void remove(Observador ob)
        {
            lista.Remove(ob);
        }

        public void notify(string accion)
        {
            foreach (Observador ob in lista)
            {
                ob.update(accion);
            }
        }
    }
}
