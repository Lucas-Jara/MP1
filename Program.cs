using MetodologíasDeProgramaciónI;
using MP1;

static void llenar(Coleccionable coleccionable, string opcion)
{
    Fabrica fabrica;
    Manejador m = crearCadenaDeResponsabilidades();

    switch (opcion)
    {
        case "alumnos":
            fabrica = new FabricaDeAlumnos(m);
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
    Manejador m = crearCadenaDeResponsabilidades();

    for (int i = 0; i < 5; i++)
    {
        Fabrica fabricaDeAlumnos = new FabricaDeAlumnos(m);
        IAlumno alumno = new ProxyAlumno((Alumno)fabricaDeAlumnos.crearAleatorio());
        alumno = new DecoradorRecuadro(alumno);

        Console.WriteLine(alumno.mostrarCalificacion());
        Student student = new AlumnoAdapterToStudent(alumno);
        t.goToClass(student);
    }

    for (int i = 0; i < 2; i++)
    {
        Fabrica fabricaDeAlumnos = new FabricaDeAlumnos(m);
        IAlumno alumno = (IAlumno)fabricaDeAlumnos.crearPorTeclado();
        IAlumno alumnoEstudioso = new AlumnoMuyEstudioso(alumno.getNombre(), alumno.getDNI(), alumno.getLegajo(), alumno.getPromedio());
        alumno = new DecoradorNotaEnLetra(alumnoEstudioso);

        Console.WriteLine(alumno.mostrarCalificacion());
        Student student = new AlumnoAdapterToStudent(alumno);
        t.goToClass(student);
    }

    for (int i = 0; i < 5; i++)
    {
        Fabrica fabricaDeAlumnos = new FabricaDeAlumnos(m);
        Fabrica fabricaDeAlumnosCompuestos = new FabricaDeAlumnosCompuestos();
        ProxyAlumno alumno = new ProxyAlumno((Alumno)fabricaDeAlumnos.crearAleatorio());

        AlumnoCompuesto composite = (AlumnoCompuesto)fabricaDeAlumnosCompuestos.crearAleatorio();
        composite.agregar(alumno);

        Console.WriteLine(alumno.mostrarCalificacion());
        Student student = new AlumnoAdapterToStudent(alumno);
        t.goToClass(student);
    }

    t.teachingAClass();
}

static void elegirJuego()
{
    Console.WriteLine("---Juegos---");
    Console.WriteLine("[1] - ChinChón");
    Console.WriteLine("[2] - Carrera de caballos");
    Console.WriteLine("[0] - salir");
    Console.Write("Ingrese una opción: ");
    int opcion = int.Parse(Console.ReadLine());

    while (opcion != 0)
    {
        if(opcion == 1)
        {
            Player p1 = new Player("Lucas", 4);
            Player p2 = new Player("Juan", 5);
            JuegoDeCartas juego = new ChinChon(new List<Player>([p1, p2]));
            List<Carta> mazo = juego.generarCartas();
            juego.mezclarMazo(mazo);
            juego.repartirCartas();
            juego.jugarUnaMano();

        }
        else
        {
            PlayerPalo p1 = new PlayerPalo("Lucas", 4);
            PlayerPalo p2 = new PlayerPalo("Juan", 5);
            JuegoDeCartas juego = new CarrerasDeCaballo(new List<Player>([p1, p2]));
            List<Carta> mazo =juego.generarCartas();
            juego.mezclarMazo(mazo);
            juego.jugarUnaMano();
        }

    }
}

static Manejador crearCadenaDeResponsabilidades()
{
    Manejador m = LectorDeArchivos.getInstance(null);
    m = GeneradorDeDatos.getInstance(m);
    m = new LectorDeDatos(m);
    return m;
}



simularClase();