using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase14_BarajaEsp
{
    internal class Carta
    {
            public int numero { get; set; }
            public string palo { get; set; }

            public override string ToString()
            {
                return numero + " de " + palo;
            }
        }
    }
}
}
