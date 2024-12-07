using System;
namespace Sistemaventacomputadoras
{
    public class Usuario
    {
        private int Id;
        private String NombreUsuario;
        private String Email;
        private String Contrasenia;
        private String Rol;

        public Usuario(int id, String nombreUsuario, String email, String pass, String rol)
        {
            this.Id = id;
            this.NombreUsuario = nombreUsuario;
            this.Email = email;
            this.Contrasenia = pass;
            this.Rol = rol;
        }

        public Usuario()
        {
            this.NombreUsuario = "Invitado";
            this.Email = "desconocido@correo.com";
            this.Contrasenia = "";
            this.Rol = "Usuario";
        }

        public String SetId(int id)
        {
            try
            {
                this.Id = id;
                return "Se asignó correctamente el ID del usuario";
            }
            catch
            {
                return "Ocurrió un error al asignar el ID del usuario";
            }
        }

        public int GetId()
        {
            return this.Id;
        }

        public String SetNombreUsuario(String nombreUsuario)
        {
            try
            {
                this.NombreUsuario = nombreUsuario;
                return "Se asignó correctamente el nombre de usuario";
            }
            catch
            {
                return "Ocurrió un error al asignar el nombre de usuario";
            }
        }

        public String GetNombreUsuario()
        {
            return this.NombreUsuario;
        }

        public String SetEmail(String email)
        {
            try
            {
                this.Email = email;
                return "Se asignó correctamente el email del usuario";
            }
            catch
            {
                return "Ocurrió un error al asignar el email del usuario";
            }
        }

        public String GetEmail()
        {
            return this.Email;
        }

        public String SetContrasenia(String contraseña)
        {
            try
            {
                this.Contrasenia = contraseña;
                return "Se asignó correctamente la contraseña del usuario";
            }
            catch
            {
                return "Ocurrió un error al asignar la contraseña del usuario";
            }
        }

        public String GetContrasenia()
        {
            return this.Contrasenia;
        }

        public String SetRol(String rol)
        {
            try
            {
                this.Rol = rol;
                return "Se asignó correctamente el rol del usuario";
            }
            catch
            {
                return "Ocurrió un error al asignar el rol del usuario";
            }
        }

        public String GetRol()
        {
            return this.Rol;
        }

        public virtual String toString()
        {
            return $"Usuario con ID {this.Id}, NombreUsuario: {this.NombreUsuario}, Email: {this.Email}, Rol: {this.Rol}";
        }
    }
}
