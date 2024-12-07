using System;
namespace Sistemaventacomputadoras
{
    public class Autenticacion
    {
        private ControladorUsuarios controladorUsuarios;
        private bool Autenticado;
        private int UsuarioActual;

        public Autenticacion()
        {
            this.controladorUsuarios = new ControladorUsuarios();
            this.Autenticado = false;
            this.UsuarioActual = 0;
        }

        public bool GetAutenticado()
        {
            return this.Autenticado;
        }

        public int GetUsuario()
        {
            return this.UsuarioActual;
        }

        public ControladorUsuarios getUsuarios()
        {
            return this.controladorUsuarios;
        }

        public String RegistrarUsuario(int id, String nombreUsuario, String email, String password, String rol)
        {
            try
            {
                String message = this.controladorUsuarios.AgregarUsuario(id, nombreUsuario, email, password, rol);
                return message;
            }
            catch (Exception ex)
            {
                return $"Error al registrar el usuario: {ex.Message}";
            }
        }

        public String AutenticarUsuario(String email, String password)
        {
            Usuario usuario = this.controladorUsuarios.BuscarUsuarioPorEmail(email);
            if (usuario != null)
            {
                if (usuario.GetEmail() == email && usuario.GetContrasenia() == password)
                {
                    this.Autenticado = true;
                    this.UsuarioActual = usuario.GetId();
                    return $"Autenticación exitosa. Bienvenido, {usuario.GetNombreUsuario()}!";
                }
            }
            return "Error: Nombre de usuario o contraseña incorrectos.";
        }

        public String CambiarPassword(int id, String nuevoPassword)
        {
            Usuario usuario = this.controladorUsuarios.BuscarUsuarioPorId(id);
            if (usuario != null)
            {
                usuario.SetContrasenia(nuevoPassword);
                return "Contraseña actualizada exitosamente.";
            }
            return "Error: Usuario no encontrado.";
        }
    }
}
