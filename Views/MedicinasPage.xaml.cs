using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace Recordatorio.Views
{
    public partial class MedicinasPage : ContentPage
    {
        public MedicinasPage()
        {
            InitializeComponent();

            // Cargar datos de medicinas
            CargarMedicinas();
        }

        private void CargarMedicinas()
        {
            // Crear una lista de medicinas de ejemplo
            var medicinas = new List<Medicamento>
            {
                new Medicamento { Nombre = "Paracetamol", Descripcion = "500 mg, cada 8 horas" },
                new Medicamento { Nombre = "Ibuprofeno", Descripcion = "400 mg, cada 12 horas" },
                new Medicamento { Nombre = "Amoxicilina", Descripcion = "500 mg, cada 12 horas" }
            };

            // Asignar la lista al ListView
            MedicinasListView.ItemsSource = medicinas;
        }
    }

    // Clase modelo para representar una medicina
    public class Medicamento
    {
        public string Nombre { get; set; } = string.Empty; // Inicializa con un valor predeterminado
        public string Descripcion { get; set; } = string.Empty; // Inicializa con un valor predeterminado
    }
}