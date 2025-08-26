using System;
using GarajeApp.Clases;

namespace GarajeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear garaje
            Garaje g1 = new Garaje(1, "Garaje principal", 20, 2);

            Console.WriteLine($"Garaje #{g1.NumeroGaraje} - {g1.Descripcion}");
            Console.WriteLine($"Capacidad total: {g1.CapacidadEspacios}");
            Console.WriteLine($"Espacios ocupados: {g1.EspaciosOcupados}");
            Console.WriteLine($"Espacios disponibles: {g1.EspaciosDisponibles()}");

            Console.WriteLine("\n--- Actualizando espacios ---");
            Console.Write("Ingrese cantidad de espacios a ocupar: ");
            int solicitados = int.Parse(Console.ReadLine());

            g1.ActualizarEspacios(solicitados);

            Console.WriteLine($"\nEspacios disponibles ahora: {g1.EspaciosDisponibles()}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}