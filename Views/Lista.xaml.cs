using Microsoft.Maui.Controls;
using Recordatorio.Models;
using System.Collections.Generic;

namespace Recordatorio.Views
{
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();

            var medicamentos = new List<Medicamento>
            {
                new Medicamento {
                    Nombre = "Paracetamol",
                    Descripcion = "500mg, cada 8 horas",
                    Presentacion = "Tabletas",
                    Dosis = "500 mg",
                    Frecuencia = "Cada 8 horas",
                    DiasSemana = new bool[] { true, true, true, true, true, false, false } // Ejemplo: L-V
                },
                new Medicamento {
                    Nombre = "Ibuprofeno",
                    Descripcion = "400mg, cada 12 horas",
                    Presentacion = "Cápsulas",
                    Dosis = "400 mg",
                    Frecuencia = "Cada 12 horas",
                    DiasSemana = new bool[] { false, true, false, true, false, true, false } // Ejemplo: Martes, Jueves, Sábado
                }
            };

            MedicamentosListView.ItemsSource = medicamentos;
        }
    }
}