using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        //Factura de consumo eléctrico con IGV
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el consumo eléctrico en kWh: ");
            double consumo = double.Parse(Console.ReadLine());
            //Cargo fijo mensual
            double cargoFijo = 5.00;
            //Costo por kWh
            double costoPorKWh = 0.55;
            
            double subtotal = cargoFijo + (consumo * costoPorKWh);
            double igv = subtotal * 0.18;
            double total = subtotal + igv;

            Console.WriteLine($"Consumo: {consumo} kWh → S/.{costoPorKWh:F2}");
            Console.WriteLine($"Cargo fijo: S/.{cargoFijo:F2}");
            Console.WriteLine($"Subtotal: S/.{subtotal:F2}");
            Console.WriteLine($"IGV (18%): S/.{igv:F2}");
            Console.WriteLine($"Total a pagar: S/.{total:F2}");
        }
    }
}
