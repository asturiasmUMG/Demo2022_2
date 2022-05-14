using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTablaHash
{
   class Nodo
    {
        public Object Dato;
        public Nodo Enlace;
        public Nodo(Object vDato)
        {
            Dato = vDato;
            Enlace = null;
        }
    }
}


