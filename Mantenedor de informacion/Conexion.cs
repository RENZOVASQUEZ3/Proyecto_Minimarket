using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace Mantenedor_de_informacion
{
    class Conexion
    {
        string cadenaConexion = "Data Source=DESKTOP-AAAHAL7;initial Catalog=Inventario1 ; Integrated Security = true";
        public SqlConnection conectar = new SqlConnection();


        public Conexion()
        {

            conectar.ConnectionString = cadenaConexion;

        }



        public void abrir()
        {

            if (conectar.State == 0)
            {


                conectar.Open();

            }

        }


        public void cerrar()
        {
            if (conectar.State != 0)
            {


                conectar.Close();


            }
        }
    }





}

