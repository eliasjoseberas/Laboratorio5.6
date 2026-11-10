using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SISTEMA DE INVENTARIO =====");

            // Crear primer producto
            Producto producto1 = new Producto();

            producto1.Codigo = "P001";
            producto1.Nombre = "Laptop";
            producto1.Precio = 25000;
            producto1.Cantidad = 5;

            // Crear segundo producto
            Producto producto2 = new Producto();

            producto2.Codigo = "P002";
            producto2.Nombre = "Mouse";
            producto2.Precio = 500;
            producto2.Cantidad = 10;

            // Crear tercer producto
            Producto producto3 = new Producto();

            producto3.Codigo = "P003";
            producto3.Nombre = "Teclado";
            producto3.Precio = 1200;
            producto3.Cantidad = 0;

            // Mostrar primer producto
            Console.WriteLine("\n--- PRODUCTO 1 ---");
            producto1.MostrarInformacion();
            Console.WriteLine("Valor total: RD$" +
                producto1.CalcularValorTotal());

            // Mostrar segundo producto
            Console.WriteLine("\n--- PRODUCTO 2 ---");
            producto2.MostrarInformacion();
            Console.WriteLine("Valor total: RD$" +
                producto2.CalcularValorTotal());

            // Mostrar tercer producto
            Console.WriteLine("\n--- PRODUCTO 3 ---");
            producto3.MostrarInformacion();
            Console.WriteLine("Valor total: RD$" +
                producto3.CalcularValorTotal());

            // Prueba de independencia de los objetos
            Console.WriteLine("\n===== PRUEBA DE INDEPENDENCIA =====");

            producto1.Precio = 27000;

            Console.WriteLine("Nuevo precio de la Laptop: RD$" +
                producto1.Precio);

            Console.WriteLine("Precio del Mouse: RD$" +
                producto2.Precio);

            Console.WriteLine("Precio del Teclado: RD$" +
                producto3.Precio);

            Console.WriteLine("Nuevo valor total de la Laptop: RD$" +
                producto1.CalcularValorTotal());

            Console.WriteLine("\n===== FIN DEL PROGRAMA =====");
        }
    }
}
