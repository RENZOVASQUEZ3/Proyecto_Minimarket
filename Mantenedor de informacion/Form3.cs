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
    public partial class Form3 : Form
    {
        
        public int id;

        public Form3()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (id == 0)
            {


                if ((txt_codigo.Text != "") && (txt_nombre.Text != "") && (txt_tipo.Text != "") && (txt_cantidad.Text != "") && (txt_proveedor.Text != "") && (txt_estado.Text != ""))
                {
                    try
                    {

                        ESProducto ES = new ESProducto(

                            txt_codigo.Text,
                            txt_nombre.Text,
                            txt_tipo.Text,
                            txt_cantidad.Text,
                            txt_proveedor.Text,
                            txt_estado.Text

                            );

                        ES.Insertar_Producto();

                        MessageBox.Show("Guardado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    catch (Exception ex)
                    {

                    }

                }

                else
                {

                    MessageBox.Show("Debe Ingresar Los datos requeridos en los campos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }


            }


            else {



                if ((txt_codigo.Text != "") && (txt_nombre.Text != "") && (txt_tipo.Text != "") && (txt_cantidad.Text != "") && (txt_proveedor.Text != "") && (txt_estado.Text != ""))
                {
                    try
                    {

                        ESProducto ESP = new ESProducto(

                            id,
                            txt_codigo.Text,
                            txt_nombre.Text,
                            txt_tipo.Text,
                            txt_cantidad.Text,
                            txt_proveedor.Text,
                            txt_estado.Text

                            );

                        ESP.Modificar_Producto();

                        MessageBox.Show("Modificado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    catch (Exception ex)
                    {

                    }

                }

                else
                {

                    MessageBox.Show("Debe Ingresar Los datos requeridos en los campos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }


            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        void limpiar()
        {
            // codigo que nos permite limpiar las casillas de los textbox

            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_tipo.Text = "";
            txt_cantidad.Text = "";
            txt_proveedor.Text = "";
            txt_estado.Text = "";


        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        { 
        }

        private void nuevoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            // Para limpiar las casillas y agregar productos 
            limpiar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // codigo para cerrar y actualizar los datos guardados 
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // codigo que al boton1 nos deja guardar y modificar por sus respectivos botones haciendo que el form3 nos deje guardar o modificar los datos
            if (id == 0)
            {
                button1.Text = "Guardar";
            }
            else 
            {
                button1.Text = "Modificar";
            }
        }



    }
}
