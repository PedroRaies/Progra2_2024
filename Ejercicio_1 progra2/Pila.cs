
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_progra2
{
    public class Pila : IColeccion
    {
        private Stack<Object> elementos {  get; set; }

        private int contador { get; set; }

        public Pila()
        {
            elementos = new Stack<Object>();
        }

        public bool aniadir(object obj)
        {
            bool aux = true;

            if (obj == null)
            {
                aux = false;
            }
            else
            {
                elementos.Push(obj);
            }
            return aux;
        }

        public bool estaVacia()
        {
            bool aux = true;

            if (elementos.Count > 0) aux = false;

            return aux;
        }

        public Object? extraer()
        {
            Object obj = elementos.Peek();
            elementos.Pop();
            return obj;
        }

        public Object? primero()
        {
            return elementos.Peek();
        }
    }
}
