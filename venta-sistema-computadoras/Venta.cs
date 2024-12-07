using System;

namespace Sistemaventacomputadoras
{
    public class Venta
    {
        private int Id;
        private int IdUsuario;
        private int IdProducto;
        private int Cantidad;
        private double PrecioTotal;
        private DateTime Fecha;

        public Venta(int id, int idUsuario, int idProducto, int cantidad, double precioTotal, DateTime fecha)
        {
            this.Id = id;
            this.IdUsuario = idUsuario;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.PrecioTotal = precioTotal;
            this.Fecha = fecha;
        }

        public Venta()
        {
            this.Id = 0;
            this.IdUsuario = 0;
            this.IdProducto = 0;
            this.Cantidad = 0;
            this.PrecioTotal = 0;
            this.Fecha = DateTime.Now;
        }

        public int GetId() => this.Id;
        public String SetId(int id)
        {
            this.Id = id;
            return "ID de la venta asignado exitosamente.";
        }

        public int GetIdUsuario() => this.IdUsuario;
        public String SetIdUsuario(int idUsuario)
        {
            this.IdUsuario = idUsuario;
            return "ID de usuario asignado exitosamente.";
        }

        public int GetIdProducto() => this.IdProducto;
        public String SetIdProducto(int idProducto)
        {
            this.IdProducto = idProducto;
            return "ID de producto asignado exitosamente.";
        }

        public int GetCantidad() => this.Cantidad;
        public String SetCantidad(int cantidad)
        {
            this.Cantidad = cantidad;
            return "Cantidad asignada exitosamente.";
        }

        public double GetPrecioTotal() => this.PrecioTotal;
        public String SetPrecioTotal(double precioTotal)
        {
            this.PrecioTotal = precioTotal;
            return "Precio total asignado exitosamente.";
        }

        public DateTime GetFecha() => this.Fecha;
        public String SetFecha(DateTime fecha)
        {
            this.Fecha = fecha;
            return "Fecha asignada exitosamente.";
        }

        public override string ToString()
        {
            return $"Venta [ID: {this.Id}, Usuario: {this.IdUsuario}, Producto: {this.IdProducto}, Cantidad: {this.Cantidad}, Total: {this.PrecioTotal}, Fecha: {this.Fecha}]";
        }
    }
}
