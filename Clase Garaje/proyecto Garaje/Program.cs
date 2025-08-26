using System;

namespace GarajeApp.Clases
{
    public class Garaje
    {
        // Atributos
        public int NumeroGaraje { get; set; }
        public string Descripcion { get; set; }
        public int CapacidadEspacios { get; set; }
        public int EspaciosOcupados { get; set; }

        // Constructor
        public Garaje(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            NumeroGaraje = numeroGaraje;
            Descripcion = descripcion;
            CapacidadEspacios = capacidadEspacios;
            EspaciosOcupados = espaciosOcupados;
        }

        // Método para obtener espacios disponibles
        public int EspaciosDisponibles()
        {
            return CapacidadEspacios - EspaciosOcupados;
        }

        // Método para actualizar espacios ocupados
        public void ActualizarEspacios(int solicitados)
        {
            if (EspaciosOcupados + solicitados <= CapacidadEspacios)
            {
                EspaciosOcupados += solicitados;
                Console.WriteLine($"Se han ocupado {solicitados} espacios. Ahora hay {EspaciosOcupados} ocupados.");
            }
            else
            {
                Console.WriteLine("No hay suficientes espacios disponibles en el garaje.");
            }
        }
    }
}