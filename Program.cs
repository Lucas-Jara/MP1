using MetodologíasDeProgramaciónI;
using MP1;

static void llenar(Coleccionable coleccionable, string opcion)
{
    Fabrica fabrica;

    switch (opcion)
    {
        case "alumnos":
            fabrica = new FabricaDeAlumnos();
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = fabrica.crearAleatorio();
                coleccionable.agregar(comparable);
            }
            break;

        case "alumnosMuyEstudiosos":
            fabrica = new FabricaDeAlumnoMuyEstudioso();
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = fabrica.crearAleatorio();
                coleccionable.agregar(comparable);
            }
            break;

        case "numeros":
            fabrica = new FabricaDeNumeros();
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = fabrica.crearAleatorio();
                coleccionable.agregar(comparable);
            }
            break;
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
    foreach (IAlumno elem in pila.lista)
    {
        elem.setStrategy(st);
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

static void simularClase()
{
    Teacher t = new Teacher();

    for (int i = 0; i < 10; i++)
    {
        Fabrica fabricaDeAlumnos = new FabricaDeAlumnos();
        IAlumno alumno = (IAlumno)new ProxyAlumno((IAlumno)fabricaDeAlumnos.crearAleatorio());
        alumno = new DecoradorRecuadro(alumno);
        Console.WriteLine(alumno.responderPregunta(7));

        Console.WriteLine(alumno.mostrarCalificacion());
        Student student = new AlumnoAdapterToStudent(alumno);
        t.goToClass(student);
    }

    for (int i = 0; i < 10; i++)
    {
        Fabrica fabricaDeAlumnos = new FabricaDeAlumnos();
        IAlumno alumno = (IAlumno)fabricaDeAlumnos.crearAleatorio();
        IAlumno alumnoEstudioso = new AlumnoMuyEstudioso(alumno.getNombre(), alumno.getDNI(), alumno.getLegajo(), alumno.getPromedio());
        alumno = new DecoradorNotaEnLetra(alumnoEstudioso);

        Console.WriteLine(alumno.mostrarCalificacion());
        Student student = new AlumnoAdapterToStudent(alumno);
        t.goToClass(student);
    }
    t.teachingAClass();
}


Aula aula = new Aula();
Pila pila = new Pila();

pila.setOrdenInicio(new OrdenInicio(aula));
pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));

llenar(pila, "alumnos");
llenar(pila, "alumnosMuyEstudiosos");