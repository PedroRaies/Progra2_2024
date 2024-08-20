using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_progra2
{
    public interface IColeccion
    {
        public bool estaVacia();
        public Object? extraer();
        public Object? primero();
        public bool aniadir(Object obj);
    }
}
