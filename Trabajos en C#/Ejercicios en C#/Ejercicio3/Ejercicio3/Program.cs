using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        //Conversor de temperatura (°C → °F y °K)
        static void Main(string[] args)
        {
            Console.Write("Ingrese temperatura en °C: ");
            double celsius = double.Parse(Console.ReadLine());

            // Fórmula Fahrenheit: F = C × (9.0/5) + 32
            double fahrenheit = celsius * (9.0 / 5) + 32;

            // Fórmula Kelvin: K = C + 273.15
            double kelvin = celsius + 273.15;

            Console.WriteLine($"Temperatura en Celsius: {celsius} °C");
            Console.WriteLine($"Convertida a Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Convertida a Kelvin: {kelvin:F2} °K");
        }
    }
}
