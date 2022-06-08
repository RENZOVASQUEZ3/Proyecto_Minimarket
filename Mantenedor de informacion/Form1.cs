using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mantenedor_de_informacion.Modelo;
using Mantenedor_de_informacion.Controlador;

namespace Mantenedor_de_informacion
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // nos dejara ver los datos del datagriedview 
            Mostrar_Producto();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // codigo para guardar los datos ingresados de los textbox del form3 a datagriedview 
            Form3 nuevo = new Form3();
            nuevo.ShowDialog();
            Mostrar_Producto();
        }


        public void Mostrar_Producto()
        {
            // codigo que nos dejara poder mostrar los datos del datagriedview y poder llamarlo a este form
            DataTable DT = new DataTable();
            BDProducto bdu = new BDProducto();
            bdu.Mostrar_Producto(ref DT);
            dataGridView1.DataSource = DT;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // codigo para borrar los datos del datagriedview 
            int id = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
            ESProducto eliminar = new ESProducto();
            eliminar.Eliminar_Producto(id);
            Mostrar_Producto();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // codigo para modificar los datos ingresados al datagriedview 
            int id = (int)dataGridView1[0,dataGridView1.CurrentRow.Index].Value;
            Form3 Modificar_Producto = new Form3();
            Modificar_Producto.txt_codigo.Text=dataGridView1[1,dataGridView1.CurrentRow.Index].Value.ToString();
            Modificar_Producto.txt_nombre.Text=dataGridView1[2,dataGridView1.CurrentRow.Index].Value.ToString();
            Modificar_Producto.txt_tipo.Text=dataGridView1[3,dataGridView1.CurrentRow.Index].Value.ToString();
            Modificar_Producto.txt_cantidad.Text=dataGridView1[4,dataGridView1.CurrentRow.Index].Value.ToString();
            Modificar_Producto.txt_proveedor.Text=dataGridView1[5,dataGridView1.CurrentRow.Index].Value.ToString();
            Modificar_Producto.txt_estado.Text=dataGridView1[6,dataGridView1.CurrentRow.Index].Value.ToString();
            Modificar_Producto.id = id;
            Modificar_Producto.ShowDialog();
            Mostrar_Producto();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // textbox creado para poder escribir y buscar datos mediantes el nompre del producto
          





            



        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
