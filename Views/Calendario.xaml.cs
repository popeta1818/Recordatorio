using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace Recordatorio.Views
{
    public partial class Calendario : ContentPage
    {
        public Calendario()
        {
            InitializeComponent();

            // Cargar datos de ejemplo
            var eventos = new List<Evento>
            {
                new Evento { Fecha = "2023-10-01", Descripcion = "Tomar Paracetamol" },
                new Evento { Fecha = "2023-10-02", Descripcion = "Tomar Ibuprofeno" },
                new Evento { Fecha = "2023-10-03", Descripcion = "Tomar Omeprazol" }
            };

            // Asignar la lista al ListView
            EventosListView.ItemsSource = eventos;
        }
    }

    // Clase modelo para los eventos
    public class Evento
    {
        public string Fecha { get; set; } = string.Empty; // Inicializa con un valor por defecto
        public string Descripcion { get; set; } = string.Empty; // Inicializa con un valor por defecto
    }
}