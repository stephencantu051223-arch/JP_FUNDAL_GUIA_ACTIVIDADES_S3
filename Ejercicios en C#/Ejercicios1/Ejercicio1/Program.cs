using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Número de habitaciones: ");
            int habitaciones = int.Parse(Console.ReadLine());

            Console.Write("Número de baños: ");
            int baños = int.Parse(Console.ReadLine());

            Console.Write("Número de patios: ");
            int patios = int.Parse(Console.ReadLine());

            // Cada habitación cuesta S/.30.00
            int costoHabitaciones = habitaciones * 30;

            // Cada baño cuesta S/.10.00
            int costoBaños = baños * 10;

            // Cada patio cuesta S/.15.00
            int costoPatios = patios * 15;

            // Total = habitaciones*30 + baños*10 + patios*15
            int total = costoHabitaciones + costoBaños + costoPatios;

            Console.WriteLine($"Habitaciones: {habitaciones} → S/.{costoHabitaciones}");
            Console.WriteLine($"Baños: {baños} → S/.{costoBaños}");
            Console.WriteLine($"Patios: {patios} → S/.{costoPatios}");
            Console.WriteLine($"Total mensual: S/.{total}"); 
        }
    }
}
