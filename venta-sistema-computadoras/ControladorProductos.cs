using System;
using System.Collections.Generic;

namespace Sistemaventacomputadoras
{
    public class ControladorProductos
    {
        private List<Computador> Computadores;

        public ControladorProductos()
        {
            this.Computadores = new List<Computador>();
        }

        public String AgregarComputador(int id, string nombre, String descrip, double precio, String fabric, string procesador, int memoriaRAM, int almacenamiento)
        {
            try
            {
                var computador = new Computador(id, nombre, descrip, precio, fabric, procesador, memoriaRAM, almacenamiento);
                this.Computadores.Add(computador);
                return $"Producto {computador.GetNombre()} agregado exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el computador: {ex.Message}";
            }
        }

        public String EliminarComputador(int id)
        {
            try
            {
                var computador = BuscarComputadorPorId(id);
                if (computador != null)
                {
                    this.Computadores.Remove(computador);
                    return $"Computador con ID {id} eliminado exitosamente.";
                }
                return $"Computador con ID {id} no encontrado.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el computador: {ex.Message}";
            }
        }

        public Computador? BuscarComputadorPorId(int id)
        {
            foreach (Computador computador in this.Computadores)
            {
                if (computador.GetId() == id)
                {
                    return computador;
                }
            }
            return null;
        }

        public void ListarComputador()
        {
            if (this.Computadores.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                Console.WriteLine("Productos registrados:");
                foreach (Producto producto in this.Computadores)
                {
                    Console.WriteLine(producto.toString());
                }
            }
        }

        public String ActualizarComputador(int id, string nuevoNombre, string nuevaDescripcion, double nuevoPrecio, string nuevoFabricante)
        {
            try
            {
                var computador = BuscarComputadorPorId(id);
                if (computador != null)
                {
                    computador.SetNombre(nuevoNombre);
                    computador.SetDescription(nuevaDescripcion);
                    computador.SetPrecio(nuevoPrecio);
                    computador.SetFabricante(nuevoFabricante);
                    return $"Computador con ID {id} actualizado exitosamente.";
                }
                return $"Computador con ID {id} no encontrado.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar el computador: {ex.Message}";
            }
        }
    }
}
