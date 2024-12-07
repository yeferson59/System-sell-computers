using System;
namespace Sistemaventacomputadoras
{
    public class Computador : Producto
    {
        private readonly string Procesador;
        private readonly int MemoriaRAM;
        private readonly int Almacenamiento;

        public Computador(int id, string nombre, String descrip, double precio, String fabric, string procesador, int memoriaRAM, int almacenamiento)
        : base(id, nombre, descrip, precio, fabric)
        {
            this.Procesador = procesador;
            this.MemoriaRAM = memoriaRAM;
            this.Almacenamiento = almacenamiento;
        }

        public override string toString()
        {
            return $"{base.toString()}, Procesador: {Procesador}, RAM: {MemoriaRAM}GB, Almacenamiento: {Almacenamiento}GB";
        }
    }
}
