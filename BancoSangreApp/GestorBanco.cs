using System;
using System.Collections.Generic;
using System.Linq; // Necesario para buscar fácil

namespace BancoSangreApp
{
    public class GestorBanco
    {
        // Estas son tus "Estructuras de Datos"
        public List<Donador> ListaDonadores = new List<Donador>();
        public List<BolsaSangre> Inventario = new List<BolsaSangre>();
        private int contadorId = 1;

        public void RegistrarDonador(string nombre, string tipo, string tel)
        {
            Donador nuevo = new Donador(nombre, tipo, tel);
            ListaDonadores.Add(nuevo);
        }

        public bool RegistrarDonacion(string nombreDonador)
        {
            // Buscamos si el donador existe (Simulando búsqueda en estructura)
            Donador encontrado = ListaDonadores.FirstOrDefault(d => d.Nombre == nombreDonador);

            if (encontrado != null)
            {
                // Crear bolsa y guardarla
                BolsaSangre bolsa = new BolsaSangre(contadorId, encontrado.TipoSangre, encontrado.Nombre);
                Inventario.Add(bolsa);
                contadorId++;
                return true; // Éxito
            }
            return false; // Fallo
        }
    }
}