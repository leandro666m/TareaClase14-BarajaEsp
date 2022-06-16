using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase14_BarajaEsp{
    internal class Baraja    {

        List<Carta> miListaBaraja = new List<Carta>();
        Stack<Carta> miPilaDeCartas = new Stack<Carta>();
        public void CrearBaraja() {
            //agrega las 12 cartas de cada palo
            for( int p = 0; p < 4; p++ ) {
                switch( p ) {
                    case 0:
                        string pa = "Espada";
                        for( int i = 1; i < 13; i++ ) {
                            miListaBaraja.Add(new Carta() { numero = i, palo = pa });
                        }
                        break;
                    case 1:
                        string pa2 = "Basto";
                        for( int i = 1; i < 13; i++ ) {
                            miListaBaraja.Add(new Carta() { numero = i, palo = pa2 });
                        }
                        break;
                    case 2:
                        string pa3 = "Oro";
                        for( int i = 1; i < 13; i++ ) {
                            miListaBaraja.Add(new Carta() { numero = i, palo = pa3 });
                        }
                        break;
                    case 3:
                        string pa4 = "Copa";
                        for( int i = 1; i < 13; i++ ) {
                            miListaBaraja.Add(new Carta() { numero = i, palo = pa4 });
                        }
                        break;
                }
            }
            //quita los 8 y 9
            miListaBaraja.RemoveAll(carta => carta.numero == 8 || carta.numero == 9);
        }


        //------------------del menu de opciones---------------------------------------

        //"1 - Barajar"  ---mezclar todas las cartas    
        public void Barajar() {
            Console.WriteLine("\n Mezclando......");
            //Random rnd = new Random();
            miListaBaraja = miListaBaraja.OrderBy(( item ) => new Random().Next()).ToList();

            foreach( Carta carta in miListaBaraja ) { miPilaDeCartas.Push(carta); }
            Console.WriteLine($"Pila de cartas: \n {String.Join(", ", miPilaDeCartas)}");
        }

        //"2 - Dame la siguiente carta" ---saca la carta de la pila    
        public Carta SiguienteCarta() {
            if( CartasDisponibles() > 0 ) {
                Carta carta = miPilaDeCartas.Pop();
                listaDeCartasEntregadas.Add(carta);
                return carta;
            } else {
                Console.WriteLine("\n\n-------Ya no hay cartas-------");
                return null;
            }
        }

        //"3 - Cantidad de cartas disponibles" ---cuenta las cartas que quedan en la pila
        public int CartasDisponibles() {
            return miPilaDeCartas.Count();
        }

        //"4 - Dame cartas" ---saca las cartas de la pila y las guarda en una lista
        public List<Carta> DarCartas( int cantidad ) {
            List<Carta> listaDeCartasAEntregar = new List<Carta>();
            for( int i = 0; i < cantidad; i++ ) {
                listaDeCartasAEntregar.Add(SiguienteCarta());
            }
            return listaDeCartasAEntregar;
        }

        //"5 - Mostrar cartas del monton"  ---mostrar las cartas que ya han salido
        List<Carta> listaDeCartasEntregadas = new List<Carta>();
        public List<Carta> CartasYaEntregadas() {
            return listaDeCartasEntregadas;
        }

        //6 - Mostrar baraja"   ---muestra la baraja
        public void MostrarBaraja() {
            Console.WriteLine("Mazo de cartas restantes: \n" + String.Join(", ", miPilaDeCartas));
        }


    }//class

}
