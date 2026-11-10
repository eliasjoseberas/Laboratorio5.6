using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5._6
{
    public class Producto
    {
        // Propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: RD$" + Precio);
            Console.WriteLine("Cantidad: " + Cantidad);
        }

        public decimal CalcularValorTotal()
        {
            return Precio * Cantidad;
        }
    }
}
