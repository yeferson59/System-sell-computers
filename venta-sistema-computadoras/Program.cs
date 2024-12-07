using Sistemaventacomputadoras;

// Autor: George Alejandro Sanchez; Ejecutado en visual studio 2022 for mac 

SistemaVenta sistemaVenta = new();

// Autenticación de usuario
sistemaVenta.RegistrarUsuario("usuario", "usuario@gmail.com", "1234", "admin");

Console.WriteLine("\nIntento de autenticación:");
Console.WriteLine("Ingrese tu correo para ingresar al sistema de ventas");
String email = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Ingrese tu contaseña para ingresar al sistema de ventas");
String password = Console.ReadLine();
String autenticado = sistemaVenta.AutenticarUsuario(email, password);
Console.WriteLine(autenticado);

Console.WriteLine("\n");

if (sistemaVenta.GetUsuario() == 0)
{
    Console.WriteLine("Reintente de nuevo");
}
else
{
    // Registrar productos
    sistemaVenta.RegistrarProducto("Laptop", "Laptop Gamer", 1500.0, "Dell", "i9-10600H", 16, 512);
    sistemaVenta.RegistrarProducto("Mouse", "Mouse óptico", 20.0, "Logitech", "17-13500Hs", 12, 1024);

    // Registrar ventas
    sistemaVenta.RegistrarVenta(sistemaVenta.GetUsuario(), 1, 1);
    Console.WriteLine("\n");
    sistemaVenta.RegistrarVenta(sistemaVenta.GetUsuario(), 2, 5);

    // Listar productos
    Console.WriteLine("\nProductos registrados:");
    sistemaVenta.ListarProductos();

    // Listar ventas
    Console.WriteLine("\nVentas registradas:");
    sistemaVenta.ListarVentas();

    // Listar usuarios
    sistemaVenta.ListarUsuarios();
}
