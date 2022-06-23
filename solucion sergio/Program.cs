using CartasEspañolas;

/*
 Ejercicio de cartas españolas orientado a objetos:
*/

int opcion = 0;
var miBaraja = new Baraja(); //creo mi baraja
miBaraja.CrearBaraja(); //inicializa la baraja

Console.WriteLine("Bienvenido a las cartas españolas");
Console.WriteLine("");
do {
    Console.WriteLine("Seleccione una opción: ");
    Console.WriteLine("1 - Barajar");
    Console.WriteLine("2 - Mostrar siguiente carta");
    Console.WriteLine("3 - Mostrar cartas disponibles");
    Console.WriteLine("4 - Dar cartas");
    Console.WriteLine("5 - Mostrar cartas del monton");
    Console.WriteLine("6 - Mostrar baraja");
    Console.WriteLine("7 - Salir");
    Console.Write("\n Ingrese una opcion: ");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            miBaraja.Barajar();
            break;
        case 2:
            Console.WriteLine($"Se te entregó la carta: {miBaraja.SiguienteCarta()}");
            break;
        case 3:
            Console.WriteLine($"Cartas disponibles en el mazo: {miBaraja.CartasDisponibles()} ");
            break;
        case 4:
            Console.WriteLine("\n¿Cuantas cartas desea?\n");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Repartiendo cartas......");
            Console.WriteLine($"Recibiste las cartas:  {String.Join(", ", miBaraja.DarCartas(cantidad))} ");
            break;
        case 5:
            miBaraja.CartasMonton();
            break;
        case 6:
            miBaraja.MostrarBaraja();
            break;
        case 7:
            Console.WriteLine("¡Hasta la próxima!");
            break;
        default:
            Console.WriteLine("Opción no válida!!!");
            break;
    }
    Console.WriteLine("-------------------------------------------------------------");

} while (opcion != 7);