using System;
using System.Collections.Generic;
using System.Text;
using Mantenedor_de_informacion.Modelo;
using System.Data;

namespace Mantenedor_de_informacion.Controlador
{
    class ESProducto
    {
        private int Id;
        private string Código;
        private string Producto;
        private string Tipo;
        private string Cantidad;
        private string Proveedor;
        private string Estado;

        
        public ESProducto(int id, string código, string producto, string tipo, string cantidad, string proveedor, string estado)
        {
            this.Id = id;
            this.Código = código;
            this.Producto = producto;
            this.Tipo = tipo;
            this.Cantidad = cantidad;
            this.Proveedor = proveedor;
            this.Estado = estado;
        }



        public ESProducto(string código, string producto, string tipo, string cantidad, string proveedor, string estado)
        {
            this.Código = código;
            this.Producto = producto;
            this.Tipo = tipo;
            this.Cantidad = cantidad;
            this.Proveedor = proveedor;
            this.Estado = estado;
        }



        public ESProducto() { 
        
        
        }

    

        public void Insertar_Producto()
        {
            BDProducto nuevo = new BDProducto();
            nuevo.Insertar_Producto(this);




        }

        public void Eliminar_Producto(int id)
        {

            BDProducto eliminar = new BDProducto();
            eliminar.Eliminar_Producto(id);



        }

        public void Modificar_Producto()
        {

            BDProducto mod = new BDProducto();
            mod.Modificar_Producto(this);

        }


        public void Buscar_Producto()
        {

            BDProducto bu = new BDProducto();
            bu.Buscar_Producto(this);

        }


        public int Id1 { get => Id; set => Id = value; }
        public string Código1 { get => Código; set => Código = value; }
        public string Producto1 { get => Producto; set => Producto = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public string Proveedor1 { get => Proveedor; set => Proveedor = value; }
        public string Estado1 { get => Estado; set => Estado = value; }



    }
}
