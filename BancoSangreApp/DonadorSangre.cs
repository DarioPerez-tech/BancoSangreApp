using System;
using System.Collections.Generic;

namespace BancoSangreApp
{
    public class Donador
    {
        public string Nombre { get; set; }
        public string TipoSangre { get; set; } // A+, O-, etc.
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Constructor
        public Donador(string nombre, string tipo, string tel)
        {
            // Validaciones para evitar asignaciones nulas a tipos no anulables (CS8600)
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            TipoSangre = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Telefono = tel ?? throw new ArgumentNullException(nameof(tel));

            FechaRegistro = DateTime.Now;
        }
    }
}