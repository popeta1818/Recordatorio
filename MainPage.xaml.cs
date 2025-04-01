namespace Recordatorio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Método para manejar el evento Clicked del botón "Leer más"
        private void OnLeerMasClicked(object sender, EventArgs e)
        {
            // Alternar la visibilidad de los Labels
            if (DescripcionCompleta.IsVisible)
            {
                // Si el texto completo está visible, ocultarlo y mostrar el texto cortado
                DescripcionCompleta.IsVisible = false;
                DescripcionCortada.IsVisible = true;
                LeerMasButton.Text = "Leer más";
            }
            else
            {
                // Si el texto cortado está visible, ocultarlo y mostrar el texto completo
                DescripcionCortada.IsVisible = false;
                DescripcionCompleta.IsVisible = true;
                LeerMasButton.Text = "Leer menos";
            }
        }

        // Método para manejar el evento Clicked del botón "Agregar a lista"
        private void OnAddToListClicked(object sender, EventArgs e)
        {
            // Lógica para agregar el medicamento a la lista
            DisplayAlert("Éxito", "Medicamento agregado a la lista", "OK");
        }
    }
}