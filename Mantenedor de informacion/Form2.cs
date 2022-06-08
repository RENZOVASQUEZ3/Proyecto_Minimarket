using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mantenedor_de_informacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mensaje de inicio
            MessageBox.Show("Bienvenido");

            // para poder ingresar de este formulario al otro mediante el boton de ingresar 
            Form formulario = new Form1();
            formulario.Show();

            // nos cierra la ventana para poder llevarnos a el formulario del inventario 
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
