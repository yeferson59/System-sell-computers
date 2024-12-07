using System;
namespace Sistemaventacomputadoras
{
    public class Producto
    {
        private int Id;
        private String Nombre;
        private String Descripcion;
        private double Precio;
        private String Fabricante;

        public Producto(int id, String nom, String des, double pre, String fab)
        {
            this.Id = id;
            this.Nombre = nom;
            this.Descripcion = des;
            this.Precio = pre;
            this.Fabricante = fab;
        }

        public Producto()
        {
            this.Nombre = "Desconocido";
            this.Descripcion = "";
            this.Precio = 0;
            this.Fabricante = "Desconocido";
        }

        public String SetId(int id)
        {
            try
            {
                this.Id = id;
                return "Se inserto exitosame el nombre del producto";
            }
            catch
            {
                return "Ocurrió un error inesperado";
            }
        }

        public int GetId()
        {
            return this.Id;
        }

        public String SetNombre(String nombre)
        {
            try
            {
                this.Nombre = nombre;
                return "Se inserto exitosame el nombre del producto";
            }
            catch
            {
                return "Ocurrió un error inesperado";
            }
        }

        public String GetNombre()
        {
            return this.Nombre;
        }

        public String SetDescription(String descrip)
        {
            try
            {
                this.Descripcion = descrip;
                return "Se inserto exitosame la descripción del producto";
            }
            catch
            {
                return "Ocurrió un error inesperado";
            }
        }

        public String GetDescripcion()
        {
            return this.Descripcion;
        }

        public String SetPrecio(double precio)
        {
            try
            {
                this.Precio = precio;
                return "Se inserto exitosame el precio del producto";
            }
            catch
            {
                return "Ocurrió un error inesperado";
            }
        }

        public double GetPrecio()
        {
            return this.Precio;
        }

        public String SetFabricante(String fabricante)
        {
            try
            {
                this.Fabricante = fabricante;
                return "Se inserto exitosame el nombre del fabricante del producto";
            }
            catch
            {
                return "Ocurrió un error inesperado";
            }
        }

        public String GetFabricante()
        {
            return this.Fabricante;
        }

        public virtual String toString()
        {
            return "Producto con id "+this.Id+" nombre "+this.Nombre+ " descripción "+this.Descripcion+" con precio "+this.Precio+" fabricado por "+this.Fabricante;
        }
    }
}
