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
    public partial class Form1 : Form
    {
        Estudiante[] tabla = new Estudiante[1000];
        int Posicion;
        DispersionHash FuncionesHash = new DispersionHash();
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                Posicion = FuncionesHash.dispersion(FuncionesHash.transformaClave(txtNombre.Text));
                tabla[Posicion] = new Estudiante(Convert.ToInt16(txtCarne.Text), txtNombre.Text.ToString());
                textBox3.Text = "Estudiante ingresado en la Posición " + Posicion.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                Posicion = FuncionesHash.dispersion(FuncionesHash.transformaClave(txtNombre.Text));
                Estudiante EstudianteEncontrado = new Estudiante();
                EstudianteEncontrado = tabla[Posicion];
                textBox3.Text = "Estudiante ingresado en la Posición " + Posicion.ToString() + " con el nombre " + EstudianteEncontrado.Nombre.ToString() + " y Carne " + EstudianteEncontrado.Carne.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            Posicion = FuncionesHash.dispersion(FuncionesHash.transformaClave(txtNombre.Text));
            tabla[Posicion]=null;
            textBox3.Text = "Estudiante Eliminado de la Posición " + Posicion.ToString() ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
