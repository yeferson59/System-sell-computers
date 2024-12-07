using System;
using System.Collections.Generic;

namespace Sistemaventacomputadoras
{

    public class ControladorUsuarios
    {
        private List<Usuario> Usuarios;

        public ControladorUsuarios()
        {
            this.Usuarios = new List<Usuario>();
        }

        public String AgregarUsuario(int id, String nombreUsuario, String email, String pass, String rol)
        {
            try
            {
                var usuario = new Usuario(id, nombreUsuario, email, pass, rol);
                this.Usuarios.Add(usuario);
                return $"Usuario {usuario.GetNombreUsuario()} agregado exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al agregar el usuario: {ex.Message}";
            }
        }

        public String EliminarUsuario(int id)
        {
            try
            {
                Usuario usuario = this.BuscarUsuarioPorId(id);
                if (usuario != null)
                {
                    this.Usuarios.Remove(usuario);
                    return $"Usuario con ID {id} eliminado exitosamente.";
                }
                return $"Usuario con ID {id} no encontrado.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el usuario: {ex.Message}";
            }
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            foreach (Usuario usuario in this.Usuarios)
            {
                if (usuario.GetId() == id)
                {
                    return usuario;
                }
            }
            return null;
        }

        public Usuario BuscarUsuarioPorEmail(string email)
        {
            foreach (Usuario usuario in this.Usuarios)
            {
                if (usuario.GetEmail() == email)
                {
                    return usuario;
                }
            }
            return null;
        }

        public void ListarUsuarios()
        {
            if (this.Usuarios.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados.");
            }
            else
            {
                Console.WriteLine("Usuarios registrados:");
                foreach (Usuario usuario in this.Usuarios)
                {
                    Console.WriteLine(usuario.toString());
                }
            }
        }

        public String ActualizarUsuario(int id, String nuevoNombre, String nuevoEmail, String nuevoRol)
        {
            try
            {
                Usuario usuario = this.BuscarUsuarioPorId(id);
                if (usuario != null)
                {
                    usuario.SetNombreUsuario(nuevoNombre);
                    usuario.SetEmail(nuevoEmail);
                    usuario.SetRol(nuevoRol);
                    return $"Usuario con ID {id} actualizado exitosamente.";
                }
                return $"Usuario con ID {id} no encontrado.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar el usuario: {ex.Message}";
            }
        }
    }
}
