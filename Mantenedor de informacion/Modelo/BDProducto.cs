using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Mantenedor_de_informacion.Controlador;

namespace Mantenedor_de_informacion.Modelo
{
    class BDProducto
    {
        public void Mostrar_Producto(ref DataTable DT)
        {

            Conexion conn = new Conexion();

            try
            {
                conn.abrir();

                SqlDataAdapter DA = new SqlDataAdapter("Mostrar_Producto", conn.conectar);
                DA.Fill(DT);


            }
            catch (Exception ex)
            {


            }
            finally
            {


                conn.cerrar();

            }

        }

        public bool Insertar_Producto(ESProducto nuevo)
        {

            Conexion conn = new Conexion();

            try
            {

                conn.abrir();

                SqlCommand insert = new SqlCommand("Insertar_Producto", conn.conectar);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("@Código", nuevo.Código1);
                insert.Parameters.AddWithValue("@Producto", nuevo.Producto1);
                insert.Parameters.AddWithValue("@Tipo", nuevo.Tipo1);
                insert.Parameters.AddWithValue("@Cantidad", nuevo.Cantidad1);
                insert.Parameters.AddWithValue("@Proveedor", nuevo.Proveedor1);
                insert.Parameters.AddWithValue("@Estado", nuevo.Estado1);
                insert.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                return false;


            }
            finally
            {


                conn.cerrar();

            }


        }


        public bool Eliminar_Producto(int id)
        {

            Conexion conn = new Conexion();

            try
            {

                conn.abrir();

                SqlCommand cmd = new SqlCommand("Eliminar_Producto", conn.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                return true;



            }
            catch (Exception ex)
            {
                return false;


            }
            finally
            {

                conn.cerrar();

            }


        }


        public bool Modificar_Producto(ESProducto productomod)
        {

            Conexion conn = new Conexion();

            try
            {

                conn.abrir();
                SqlCommand Modificar_Producto = new SqlCommand("Modificar_Producto", conn.conectar);
                Modificar_Producto.CommandType = CommandType.StoredProcedure;
                Modificar_Producto.Parameters.AddWithValue("@Id", productomod.Id1);
                Modificar_Producto.Parameters.AddWithValue("@Código", productomod.Código1);
                Modificar_Producto.Parameters.AddWithValue("@Producto", productomod.Producto1);
                Modificar_Producto.Parameters.AddWithValue("@Tipo", productomod.Tipo1);
                Modificar_Producto.Parameters.AddWithValue("@Cantidad", productomod.Cantidad1);
                Modificar_Producto.Parameters.AddWithValue("@Proveedor", productomod.Proveedor1);
                Modificar_Producto.Parameters.AddWithValue("@Estado", productomod.Estado1);
                Modificar_Producto.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                return false;


            }
            finally
            {


                conn.cerrar();

            }

        }




        public bool Buscar_Producto(ESProducto bu)
        {

            Conexion conn = new Conexion();

            try
            {
                conn.abrir();
                SqlCommand Buscar_Producto = new SqlCommand("Buscar_Producto", conn.conectar);
                Buscar_Producto.CommandType = CommandType.StoredProcedure;
                Buscar_Producto.Parameters.AddWithValue("@Producto", bu.Producto1);
                Buscar_Producto.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                return false;

            }
            finally
            {


                conn.cerrar();

            }

        }





    }



}
