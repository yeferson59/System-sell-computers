using System;
namespace Sistemaventacomputadoras

// Autor George Alejandro Sanchez
{
    using System;

    public class SistemaVenta
    {
        private readonly ControladorProductos ControladorProductos;
        private readonly ControladorVentas ControladorVentas;
        private readonly Autenticacion Autenticacion;
        private bool Autenticado;
        private int UsuarioActual;
        private int IdVenta;
        private int IdProducto;
        private int IdUsuario;

        public SistemaVenta()
        {
            this.ControladorProductos = new ControladorProductos();
            this.ControladorVentas = new ControladorVentas();
            this.Autenticacion = new Autenticacion();
            this.Autenticado = Autenticacion.GetAutenticado();
            this.UsuarioActual = Autenticacion.GetUsuario();
            this.IdProducto = 1;
            this.IdVenta = 1;
            this.IdUsuario = 1;
        }

        public int GetUsuario()
        {
            this.UsuarioActual = this.Autenticacion.GetUsuario();
            return this.UsuarioActual;
        }

        public void RegistrarUsuario(String nombreUsuario, String email, String password, String rol)
        {
            Console.WriteLine(this.Autenticacion.RegistrarUsuario(this.IdUsuario, nombreUsuario, email, password, rol));
            this.IdUsuario += 1;
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            if (this.Autenticado)
            {
                return this.Autenticacion.getUsuarios().BuscarUsuarioPorId(id);
            }
            else
            {
                return null;
            }
        }

        public void ListarUsuarios()
        {
            if (this.Autenticado)
            {
                this.Autenticacion.getUsuarios().ListarUsuarios();
            }
            else
            {
                Console.WriteLine("Lo siento debes estar autenticado");
            }
        }

        public void RegistrarProducto(string nombre, String descrip, double precio, String fabric, string procesador, int memoriaRAM, int almacenamiento)
        {
            if (this.Autenticado)
            {
                Console.WriteLine(this.ControladorProductos.AgregarComputador(this.IdProducto, nombre, descrip, precio, fabric, procesador, memoriaRAM, almacenamiento));
                this.IdProducto += 1;
            }
            else
            {
                Console.WriteLine("Lo siento debes estar autenticado");
            }
        }

        public Producto? BuscarProductoPorId(int id)
        {
            if (this.Autenticado)
            {
                return this.ControladorProductos.BuscarComputadorPorId(id);
            }
            else
            {
                return null;
            }
        }

        public void ListarProductos()
        {
            if (this.Autenticado)
            {
                this.ControladorProductos.ListarComputador();
            }
            else
            {
                Console.WriteLine("Lo siento debes estar autenticado");
            }
        }

        public void RegistrarVenta(int idUsuario, int idProducto, int cantidad)
        {
            if (this.Autenticado)
            {
                Computador computador = this.ControladorProductos.BuscarComputadorPorId(idProducto);
                if (computador == null)
                {
                    Console.WriteLine("Error, producto no encontrado");
                }
                else
                {
                    double precioTotal = computador.GetPrecio() * cantidad;
                    Console.WriteLine(this.ControladorVentas.RegistrarVenta(this.IdVenta, idUsuario, idProducto, cantidad, precioTotal, DateTime.Now));
                    this.IdVenta += 1;
                }
            }
            else
            {
                Console.WriteLine("Lo siento debes estar autenticado");
            }
        }

        public Venta? BuscarVentaPorId(int id)
        {
            if (this.Autenticado)
            {
                return this.ControladorVentas.BuscarVentaPorId(id);
            }
            else
            {
                return null;
            }
        }

        public void ListarVentas()
        {
            if (this.Autenticado)
            {
                this.ControladorVentas.ListarVentas();
            }
            else
            {
                Console.WriteLine("Lo siento debes estar autenticado");
            }
        }

        public String AutenticarUsuario(string nombreUsuario, string contrasena)
        {
            String message = this.Autenticacion.AutenticarUsuario(nombreUsuario, contrasena);
            this.Autenticado = this.Autenticacion.GetAutenticado();
            return message;
        }
    }
}
