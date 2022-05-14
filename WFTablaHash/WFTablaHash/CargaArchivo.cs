using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTablaHash
{
    public partial class CargaArchivo : Form
    {
        TablaDispersionMod TablaHash = new TablaDispersionMod();
        public CargaArchivo()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(txtArchivo.Text);
            Char delimiter = ',';
            while ((line = file.ReadLine()) != null)
            {
                String[] substrings = line.Split(delimiter);
                ClienteTarjeta ObjCliente = new ClienteTarjeta(Convert.ToDecimal(substrings[0]),
                                                substrings[1], substrings[2], substrings[3], 
                                                substrings[4]);
                TablaHash.Insertar(ObjCliente, Convert.ToString(ObjCliente.NoTarjeta));
                counter++;
            }

            file.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           ClienteTarjeta ObjCliente= (ClienteTarjeta)TablaHash.Buscar(txtNoTarjeta.Text);
           txtRespuesta.Text = ObjCliente.Nombre;
        }
    }
}
