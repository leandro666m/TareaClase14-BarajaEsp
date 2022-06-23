using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartasEspañolas;

 
namespace CartasEspañolas
{
    public class Baraja
    {
        List<Carta> listaMisCartas = new List<Carta>();
        Stack<Carta> pilaBaraja = new Stack<Carta>();
        List<Carta> listaDeCartasEntregadas = new List<Carta>();


        //Genera la lista de cartas...
        public void CrearBaraja() {
            Console.Write("Generando baraja, aguarde por favor  ...");
            for (int i = 1; i < 5; i++) {
                Console.Write("...");
                //recorro para generar la carta
                for (int j = 1; j < 13; j++) {
                    
                    //generamos las espadas
                    if (j != 8 && j != 9 && i == 1) {
                        listaMisCartas.Add(new Carta(j, "espada"));
                    }
                    //generamos los bastos
                    if (j != 8 && j != 9 && i == 2) {
                        listaMisCartas.Add(new Carta(j, "basto"));
                    }
                    //generamos los oros
                    if (j != 8 && j != 9 && i== 3) {
                        listaMisCartas.Add(new Carta(j, "oro"));
                    }
                    //generamos las copas
                    if (j != 8 && j != 9 && i == 4) {
                        listaMisCartas.Add(new Carta(j, "copa"));
                    }
                }
               
            }
            Console.WriteLine(" Baraja generada con exito!");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        //-------------------------------------
        // MENU DE OPCIONES
        //-------------------------------------

        // 1 - Barajar
        public void Barajar() {
            Console.WriteLine(" Mezclando......");
            
            listaMisCartas = listaMisCartas.OrderBy((item) => new Random().Next()).ToList();

            foreach (Carta carta in listaMisCartas) { 
                pilaBaraja.Push(carta);
            }

        }

        //2 - Mostrar siguiente carta
        public Carta SiguienteCarta()
        {

            if (CartasDisponibles() > 0) {
                Carta miCarta = pilaBaraja.Pop();
                listaDeCartasEntregadas.Add(miCarta);
                return miCarta;
            }
            else{
                Console.WriteLine("-------Ya no hay cartas-------");
                return null;
            }


        }
        //3 - Mostrar cartas disponibles
        public int CartasDisponibles() {
            return pilaBaraja.Count();
        }

        //4 - Dar cartas
        public List<Carta> DarCartas(int cantidad) {

            if (CartasDisponibles() > cantidad)
            {
                List<Carta> listaCartasAEntregar = new List<Carta>();
                for (int i = 0; i < cantidad; i++)
                {
                    listaCartasAEntregar.Add(SiguienteCarta());
                }
                return listaCartasAEntregar;
            }
            else {
                Console.WriteLine($"Se solicitaron {cantidad} y no hay disponibles en la baraja...");
                return null;
            }
            
        }

        //5 - Mostrar cartas del monton 
        public void CartasMonton()
        {
            if (listaDeCartasEntregadas.Count != 0)
            {
                Console.WriteLine("Cartas que ya me entregaron:");
                Console.WriteLine(String.Join(", ", listaDeCartasEntregadas));
            }
            else {
                Console.WriteLine("No se han entregado cartas!");
            }
        }

        //6 - Mostrar baraja
        public void MostrarBaraja() {
            Console.WriteLine("Mazo de cartas restantes: \n" + String.Join(", ", pilaBaraja));

        }

    }
}
