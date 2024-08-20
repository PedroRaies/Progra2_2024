using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_progra2
{
    internal class  Cola : IColeccion
    {

        private List<Object> lista {  get; set; }

        public Cola()
        {
            lista = new List<Object>();
        }


        public bool aniadir(object obj)
        {
            bool aux = false;
            if (obj != null) 
            {
                lista.Add(obj);
                aux = true;
            }
            return aux;
        }

        public bool estaVacia()
        {
            return lista.Count == 0;
        }

        public object? extraer()
        {
            Object obj = null;
            if (lista.Count > 0) 
            {
                obj = lista[0];
                lista.RemoveAt(0);
            }
            return obj;
        }

        public object? primero()
        {
            Object obj = null;
            if(lista.Count > 0 ) obj = lista[0];
            return obj;
        }
    }
}
