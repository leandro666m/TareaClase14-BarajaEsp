using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEspañolas
{
    public class Carta
    {
        private int _numero;
        private String _palo;

        public int Numero { get => _numero; }
        public String Palo { get=> _palo.ToString(); }

        public Carta(int numero, string palo)
        {

            _numero = numero;
            _palo = palo;
        }

        public override string ToString()
        {
            return Numero + " de " + Palo;
        }

    }
}
