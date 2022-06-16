namespace TareaClase14_BarajaEsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            var miBaraja = new Baraja(); //creo mi baraja
            miBaraja.CrearBaraja(); //inicializa la baraja

            Console.WriteLine("Hola, bienvenido a las cartas españolas");
            do
            {
                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1 - Barajar");
                Console.WriteLine("2 - Dame la siguiente carta");
                Console.WriteLine("3 - Cantidad de cartas disponibles en el mazo");
                Console.WriteLine("4 - Dame cartas");
                Console.WriteLine("5 - Mostrar cartas que ya me entregaron");
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
                        Console.WriteLine("\n¿Cuantas cartas querés?\n");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Repartiendo cartas......");
                        Console.WriteLine($"Recibiste las cartas:  {String.Join(", ", miBaraja.DarCartas(cantidad))} ");
                        break;
                    case 5:
                        Console.WriteLine("\n Cartas que ya me entregaron:");
                        Console.WriteLine($" {String.Join(", ", miBaraja.CartasYaEntregadas())} ");
                        break;
                    case 6:
                        Console.WriteLine("Baraja:");
                        miBaraja.MostrarBaraja();
                        break;
                    case 7:
                        Console.WriteLine("¡Hasta la próxima!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Rescatate gil leé bien");
                        break;
                }
                Console.WriteLine("-------------------------------------------------------------");

            } while (opcion != 7);

        }
    }
}