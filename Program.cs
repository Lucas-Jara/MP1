using MP1;

static void llenar(Coleccionable coleccionable, string opcion)
{
    Fabrica fabrica;

    if (opcion == "alumnos")
    {
        fabrica = new FabricaDeAlumnos();
        for (int i = 0; i < 20; i++)
        {
            Comparable comparable = fabrica.crearAleatorio();
            coleccionable.agregar(comparable);
        }
    }
    else
    {
        fabrica = new FabricaDeNumeros();
        for (int i = 0; i < 20; i++)
        {
            Comparable comparable = fabrica.crearAleatorio();
            coleccionable.agregar(comparable);
        }
    }
}
static void informar(Coleccionable c, string opcion)
{
    Console.WriteLine("Canidad: " + c.cuantos());
    Console.WriteLine("Minimo: " + c.minimo().ToString());
    Console.WriteLine("Maximo: " + c.maximo().ToString());

    Fabrica fabrica = new FabricaDeNumeros();
    Comparable comparable = fabrica.crearPorTeclado();
    if (c.contiene(comparable))
    {
        Console.WriteLine("El elemento leído está en la colección");
    }
    else
    {
        Console.WriteLine("El elemento leído no está en la colección");
    }

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
static void dictadoDeClases(Profesor p)
{
    for (int i = 0; i <= 5; i++)
    {
        p.hablarALaClase();
        p.escribirEnElPizarron();
    }
}

FabricaDeProfesores fabrica  = new FabricaDeProfesores();
Profesor profesor = (Profesor)fabrica.crearAleatorio();

for (int i = 0; i < 20; i++)
{
    Alumno observador = new Alumno(GetNombre(), i, i, new Random().Next(10));
    profesor.add(observador);
}
Console.WriteLine(profesor.Nombre);
dictadoDeClases(profesor);