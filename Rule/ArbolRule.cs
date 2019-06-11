using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Rule
{
    public class ArbolRule
    {
        public int ValidarParametros(ParametrosEntradaCrear parametros)
        {
            if (parametros.MaximoNiveles < 1)
            {
                return 1000;
            }
            else if (parametros.ValorMinimo > parametros.ValorMaximo)
            {
                return 1001;
            }
            return 0;
        }


        private Nodo Arbol = null;
        private Random random = new Random();
        private List<int> utilizados = new List<int>();

        public NodoRetorno CrearArbol(ParametrosEntradaCrear parametros)
        {
            int totalNiveles = random.Next(1, parametros.MaximoNiveles);
            //int totalNiveles = 3;
            Arbol = new Nodo();

            //for (int i = 0; i < totalNiveles; i++)
            //{

            CrearNodo(Arbol, parametros, totalNiveles, 1);

            //Arbol.Valor = random.Next (parametros.ValorMinimo, parametros.ValorMaximo);


            //}
            return new NodoRetorno() { NumeroNiveles = totalNiveles, Arbol = Arbol };
        }

        private void CrearNodo(Nodo nodo, ParametrosEntradaCrear parametros, int totalNiveles, int nivel)
        {

            int aux = random.Next(parametros.ValorMinimo, parametros.ValorMaximo);

            while (utilizados.Contains(aux))
            {
                if (parametros.ValorMaximo - parametros.ValorMinimo == utilizados.Count)
                {
                    //nodo = null;
                    return;
                }
                aux = random.Next(parametros.ValorMinimo, parametros.ValorMaximo);

            }
            nodo.Valor = aux;
            utilizados.Add(aux);

            if (nivel < totalNiveles)
            {
                nodo.Izquierdo = new Nodo();
                CrearNodo(nodo.Izquierdo, parametros, totalNiveles, nivel + 1);
                nodo.Derecho = new Nodo();
                CrearNodo(nodo.Derecho, parametros, totalNiveles, nivel + 1);
            }

        }


        private bool HallaA = false;
        private bool HallaB = false;

        private bool MismoNodo = false;


        public int BuscarAntecesorComun(ParametrosEntradaBuscar parametros)
        {

            if (parametros.Valor1 == parametros.Valor2)
            {
                MismoNodo = true;   
            }

            Nodo retorno = ObtenerAntecesor(parametros.Arbol, parametros.Valor1, parametros.Valor2);

            if (HallaA && HallaB)
            {
                return retorno.Valor;
            }
            return -1;
        }

       
        private Nodo ObtenerAntecesor(Nodo nodo, int valor1, int valor2)
        {
            if (nodo == null)
            {
                return null;
            }

            var AntecesorIzq = ObtenerAntecesor(nodo.Izquierdo, valor1, valor2);
            var AntecesorDer = ObtenerAntecesor(nodo.Derecho, valor1, valor2);

            if (AntecesorIzq != null && AntecesorDer != null)
            {
                return nodo;
            }

            if (nodo.Valor == valor1)
            {
                
                HallaA = true;
                if (MismoNodo)
                {
                    HallaB = true;
                }
                return nodo;
            }
            if (nodo.Valor == valor2)
            {
                HallaB = true;
                if (MismoNodo)
                {
                    HallaA = true;
                }
                return nodo;
            }


            if (AntecesorIzq != null )
            {
                return AntecesorIzq;
            }
            return AntecesorDer;
           

        }

    }
}
