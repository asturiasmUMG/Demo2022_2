using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTablaHash
{
    class ClienteTarjeta
    {
        public Decimal NoTarjeta;
        public string Vencimiento;
        public string Nombre;
        public string TipoTarjeta;
        public string Pais;
        
        public ClienteTarjeta(Decimal pNoTarjeta, string pVencimiento, string pNombre, string pTipoTarjeta, string pPais)
        {
            NoTarjeta = pNoTarjeta;
            Vencimiento = pVencimiento;
            Nombre = pNombre;
            TipoTarjeta = pTipoTarjeta;
            Pais = pPais;
        }


        public bool Equals(String pNotarjeta)
        {
            return this.NoTarjeta == Convert.ToDecimal(pNotarjeta);
        }

        public override bool Equals(object obj)
        {
            // STEP 1: Check for null
            if (obj == null)
            {
                return false;
            }
            return Equals((String)obj); 
        }
    }
}
