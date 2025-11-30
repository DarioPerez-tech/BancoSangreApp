using System;

namespace BancoSangreApp
{
    public class BolsaSangre
    {
        public int Id { get; set; }
        public string TipoSangre { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string NombreDonador { get; set; }

        public BolsaSangre(int id, string tipo, string donador)
        {
            Id = id;
            TipoSangre = tipo;
            NombreDonador = donador;
            // Regla: Vence en 42 días
            FechaVencimiento = DateTime.Now.AddDays(42);
        }
    }
}