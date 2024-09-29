using MP1;

static void llenar(Coleccionable c)
{
    int i = 0;
    Random random = new Random();
    while (i < 20)
    {
        int n = random.Next(1, 50);
        c.agregar(new Numero(n));
        i++;
    }
}
static void informar(Coleccionable c)
{
    Console.WriteLine("Canidad: " + c.cuantos());
    Console.WriteLine("Minimo: " + c.minimo().ToString());
    Console.WriteLine("Maximo: " + c.maximo().ToString());
}
static string GetNombre()
{
    List<string> nombres = new List<string>();
    nombres.Add("Jose");
    nombres.Add("Roberto");
    nombres.Add("Rodolfo");
    nombres.Add("Miguel");
    nombres.Add("Susana");
    nombres.Add("Marta");
    nombres.Add("Cristina");
    nombres.Add("Amalia");
    return nombres[new Random().Next(nombres.Count - 1)];
}
static void llenarPersonas(Coleccionable c)
{
    for (int i = 0; i < 20; i++)
    {
        Comparable personas = new Persona(GetNombre(), i);
        c.agregar(personas);
    }
}
static void llenarAlumnos(Coleccionable c)
{
    for (int i = 0; i < 20; i++)
    {
        Alumno alumno = new Alumno(GetNombre(), i, i, new Random().Next(10));
        alumno.SetStrategy(new CompararDNIStrategy());
        c.agregar(alumno);
    }
}
static void imprimirElementos(Coleccionable c)
{
    Iterador iter = c.crearIterador();

    while (!iter.fin())
    {
        Console.WriteLine(iter.actual());
        iter.siguiente();
    }
}
static void cambiarEstrategia(Pila pila, Strategy st)
{
    foreach (Alumno elem in pila.lista)
    {
        elem.SetStrategy(st);
    }
}

Pila pila = new Pila();
llenarAlumnos(pila);
cambiarEstrategia(pila, new CompararNombreStrategy());

informar(pila);
cambiarEstrategia(pila, new CompararLegajoStrategy());

informar(pila);
cambiarEstrategia(pila, new CompararPromedioStrategy());

informar(pila);
cambiarEstrategia(pila, new CompararDNIStrategy());
informar(pila);