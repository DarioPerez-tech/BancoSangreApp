using System;
using System.Windows.Forms;

namespace BancoSangreApp
{
    public partial class Form1 : Form
    {
        // --- PASO 1: CONECTAR EL CEREBRO ---
        // Creamos la variable del Gestor aquí arriba para que viva mientras la app esté abierta
        GestorBanco miGestor = new GestorBanco();

        public Form1()
        {
            InitializeComponent();
        }

        // --- PASO 2: LÓGICA DEL BOTÓN REGISTRAR ---
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // A. Obtener datos de las cajitas
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string tipo = cmbTipoSangre.Text;

                // B. Validación simple
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Por favor, ingresa al menos Nombre y Tipo de Sangre.");
                    return;
                }

                // C. Guardar en la memoria
                miGestor.RegistrarDonador(nombre, tipo, telefono);

                // D. Avisar éxito
                MessageBox.Show($"¡Donador {nombre} registrado correctamente!");

                // E. Limpiar las cajas
                txtNombre.Clear();
                txtTelefono.Clear();
                cmbTipoSangre.SelectedIndex = -1;

                // F. ACTUALIZAR LA TABLA VISUAL (Importante)
                ActualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // --- PASO 3: FUNCIÓN PARA PINTAR LA TABLA ---
        // Esta función debe estar FUERA del botón, pero DENTRO de la clase Form1
        private void ActualizarTabla()
        {
            // Truco para refrescar: Desconectar y volver a conectar la lista
            dgvDonadores.DataSource = null;
            dgvDonadores.DataSource = miGestor.ListaDonadores;
        }

        // --- EVENTOS VACÍOS (Déjalos aquí para que el diseño no se rompa) ---
        private void Form1_Load(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void cmbTipoSangre_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}