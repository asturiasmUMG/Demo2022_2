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
    public partial class Form2 : Form
    {
        DispersionHash TablaHash = new DispersionHash();
        Estudiante DatoEstudiante;
        public Form2()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                DatoEstudiante = new Estudiante(Convert.ToDouble(txtCarne.Text) , txtNombre.Text.ToString());
                TablaHash.Insertar(DatoEstudiante, txtNombre.Text);
                textBox3.Text = "Estudiante ingresado en la Posición " + TablaHash.returnPosicion(txtNombre.Text.ToString()).ToString();
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
                //Estudiante EstudianteEncontrado = new TablaHash.Buscar(txtNombre.Text.ToString());
                Estudiante EstudianteEncontrado = (Estudiante)TablaHash.Buscar(txtNombre.Text.ToString());
                if (EstudianteEncontrado == null)
                {
                    MessageBox.Show("El estudiante ingresado no existe");
                }
                else
                {
                    textBox3.Text = "Estudiante Encontrado en la Posición " + TablaHash.returnPosicion(txtNombre.Text.ToString()).ToString() + " con el nombre " + EstudianteEncontrado.Nombre.ToString() + " y Carne " + EstudianteEncontrado.Carne.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                TablaHash.Eliminar(txtNombre.Text.ToString());
                textBox3.Text = "Estudiante Eliminado de la Posición " + TablaHash.returnPosicion(txtNombre.Text.ToString()).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\temp\test.txt");
            Char delimiter = ',';
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                String[] substrings = line.Split(delimiter);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.
            System.Console.ReadLine();
        }
  
    }
}
