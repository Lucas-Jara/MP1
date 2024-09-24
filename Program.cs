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
        Comparable comparable = new Alumno(GetNombre(), i, i, new Random().Next(10));
        c.agregar(comparable);
    }
}

Pila pila = new Pila();
Cola cola = new Cola();
ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
llenarAlumnos(pila);
llenarAlumnos(cola);
informar(multiple);