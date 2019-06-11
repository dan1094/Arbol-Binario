using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParametrosEntradaCrear
    {        
        public int MaximoNiveles { get; set; }     

        public int ValorMaximo { get; set; }       

        public int ValorMinimo { get; set; }
       
    }

    public class ParametrosEntradaBuscar
    {
        public Nodo Arbol { get; set; }

        public int Valor1 { get; set; }

        public int Valor2 { get; set; }

    }
}
