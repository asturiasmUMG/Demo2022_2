using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTablaHash
{

    public class DispersionHash
    {
        public static readonly int M = 1024;
        public static readonly double R = 0.618034;
        int Posicion;
        Object[] tabla = new Object[M];

        public long transformaClave(String clave)
        {
            long d;
            d = 0;
            for (int j = 0; j < Math.Min(clave.Length, 10); j++)
            {
                d = d * 27 + (int)clave[j];
            }
            //Para un valor mayor que el máximo entero genera un numero negativo.

            if (d < 0) d = -d;
            return d;
        }
        //Metodo de Multiplicacion
        public int dispersion(long x)
        {
            //R es una constante 0--1
            double t;
            int v;
            t = R * x - Math.Floor(R * x); // parte decimal
            v = (int)(M * t);///M es el tamaño de la tabla
            return v;
        }
        //Función con aritmética modular
        public int PosMod(int x)
        {
            return x % M;
        }


        public int returnPosicion( String Clave)
        {
            
            return dispersion(transformaClave(Clave));
        } 

        public void Insertar(Object Dato, String Clave)
        {
            Posicion = returnPosicion(Clave);
            tabla[Posicion] = Dato;
        }

        public void Eliminar(String Clave)
        {
            Posicion = returnPosicion(Clave);
            tabla[Posicion] = null;
        }

        public object Buscar(String Clave)
        {
           Posicion = returnPosicion(Clave);
           return tabla[Posicion];
        }

    }
}
