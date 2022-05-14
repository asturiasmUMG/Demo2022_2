using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTablaHash
{
    class Estudiante
    {
        public double Carne { get; set; }
        public String Nombre { get; set; }
        public Estudiante()
        {
        }

        public Estudiante(double carne, String nombre)
        {
            Carne = carne;
            Nombre = nombre;
        }

        

    }
}

