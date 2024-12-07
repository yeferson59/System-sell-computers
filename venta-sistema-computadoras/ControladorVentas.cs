using System;
using System.Collections.Generic;

namespace Sistemaventacomputadoras
{
    public class ControladorVentas
    {
        private readonly List<Venta> Ventas;

        public ControladorVentas()
        {
            this.Ventas = new List<Venta>();
        }

        public String RegistrarVenta(int id, int idUsuario, int idProducto, int cantidad, double precioTotal, DateTime fecha)
        {
            try
            {
                var venta = new Venta(id, idUsuario, idProducto, cantidad, precioTotal, fecha);
                this.Ventas.Add(venta);
                return "Venta registrada exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al registrar la venta: {ex.Message}";
            }
        }

        public void ListarVentas()
        {
            if (this.Ventas.Count == 0)
            {
                Console.WriteLine("No hay ventas registradas.");
            }
            else
            {
                Console.WriteLine("Ventas registradas:");
                foreach (Venta venta in this.Ventas)
                {
                    Console.WriteLine(venta.ToString());
                }
            }
        }

        public Venta BuscarVentaPorId(int id)
        {
            foreach (Venta venta in this.Ventas)
            {
                if (venta.GetId() == id)
                {
                    return venta;
                }
            }
            return null;
        }

        public String EliminarVenta(int id)
        {
            Venta venta = this.BuscarVentaPorId(id);
            if (venta != null)
            {
                this.Ventas.Remove(venta);
                return "Venta eliminada exitosamente.";
            }
            return "Venta no encontrada.";
        }
    }
}
