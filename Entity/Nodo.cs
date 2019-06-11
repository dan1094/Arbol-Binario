using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Nodo
    {

        public int Valor { get; set; }

        public Nodo Izquierdo { get; set; }

        public Nodo Derecho { get; set; }

    }

    public class NodoRetorno
    {
        public Nodo Arbol { get; set; }
        public int NumeroNiveles { get; set; }
    }

}
