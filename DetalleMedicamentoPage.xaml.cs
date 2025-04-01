using Microsoft.Maui.Controls;

namespace Recordatorio.Views
{
    public partial class DetalleMedicamentoPage : ContentPage
    {
        public DetalleMedicamentoPage(Medicamento medicamento)
        {
            InitializeComponent();

            // Asignar los datos del medicamento a los controles
            NombreMedicamento.Text = medicamento.Nombre;
            DescripcionCorta.Text = medicamento.Descripcion;
            DescripcionCortada.Text = medicamento.Descripcion;
            DescripcionCompleta.Text = medicamento.Descripcion;
        }

        private void OnLeerMasClicked(object sender, EventArgs e)
        {
            // Alternar la visibilidad de la descripción completa
            DescripcionCortada.IsVisible = !DescripcionCortada.IsVisible;
            DescripcionCompleta.IsVisible = !DescripcionCompleta.IsVisible;
            LeerMasButton.Text = DescripcionCompleta.IsVisible ? "Leer menos" : "Leer más";
        }

        private void OnAddToListClicked(object sender, EventArgs e)
        {
            // Lógica para agregar a la lista
            DisplayAlert("Éxito", "Medicamento agregado a la lista", "OK");
        }
    }
}