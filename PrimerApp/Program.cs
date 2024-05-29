using System;
using Clases.MiApp;
using Clases.Modelos;
using Clases.PrimerApp;

namespace PrimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancias de Usuario
            Usuario usuario1 = new Usuario(1, "Pipo", "Caracol", "Pipin", "password321", "Pipo@gmail.com");

            // instancias de Producto
            Producto producto1 = new Producto(7, "Notebook", 900, 200, 60, 9);

            // instancia de Venta
            Venta venta1 = new Venta(1, "Venta de Notebook", 9);

            // instancias de ProductoVendido
            ProductoVendido productoVendido1 = new ProductoVendido(5, 7, 2, 3);

            // datos en consola
            Console.WriteLine("Datos del usuario:");
            Console.WriteLine($"ID: {usuario1.Id}");
            Console.WriteLine($"Nombre: {usuario1.Nombre} {usuario1.Apellido}");
            Console.WriteLine($"Nombre de Usuario: {usuario1.NombreUsuario}");
            Console.WriteLine($"Mail: {usuario1.Mail}");
            Console.WriteLine();

            Console.WriteLine("Datos del producto:");
            Console.WriteLine($"ID: {producto1.Id}");
            Console.WriteLine($"Descripción: {producto1.Descripcion}");
            Console.WriteLine($"Costo: {producto1.Costo}");
            Console.WriteLine($"Precio de Venta: {producto1.PrecioVenta}");
            Console.WriteLine($"Stock: {producto1.Stock}");
            Console.WriteLine();

            Console.WriteLine("Datos de la venta:");
            Console.WriteLine($"ID: {venta1.Id}");
            Console.WriteLine($"Comentarios: {venta1.Comentarios}");
            Console.WriteLine($"ID de Usuario: {venta1.idUsuario}");
            Console.WriteLine();

            Console.WriteLine("Datos del producto vendido:");
            Console.WriteLine($"ID: {productoVendido1.Id}");
            Console.WriteLine($"ID del Producto: {productoVendido1.IdProducto}");
            Console.WriteLine($"Stock Vendido: {productoVendido1.Stock}");
            Console.WriteLine($"ID de Venta: {productoVendido1.IdVenta}");
        }
    }
}
