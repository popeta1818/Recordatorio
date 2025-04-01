using Microsoft.Maui.Controls;

namespace Recordatorio.Views
{
    public partial class MenuInicio : ContentPage
    {
        public MenuInicio()
        {
            InitializeComponent();

            // Configuraci�n de accesibilidad
            SemanticScreenReader.Announce("Pantalla principal de Mi Cuidador de Medicamentos");
        }

        private async void OnSeleccionarMedicamentoClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MedicinasPage");
            SemanticScreenReader.Announce("Redirigiendo a gesti�n de medicamentos");
        }

        private async void OnListasClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ListasPage");
            SemanticScreenReader.Announce("Redirigiendo a listas personales");
        }

        private async void OnCalendarioClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CalendarioPage");
            SemanticScreenReader.Announce("Redirigiendo a calendario de medicamentos");
        }

        private async void OnEmergencyClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//EmergenciaPage");
            SemanticScreenReader.Announce("Accediendo a contactos de emergencia");
        }

        private async void OnAlexaButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var result = await DisplayActionSheet("�Qu� deseas hacer con Alexa?", "Cancelar", null,
                    "Agregar medicamento", "Consultar pr�xima dosis", "Reportar toma");

                if (result != "Cancelar")
                {
                    await TextToSpeech.SpeakAsync($"Preparando {result.ToLower()}");
                    // Aqu� ir�a la integraci�n real con Alexa
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo conectar con Alexa: {ex.Message}", "OK");
            }
        }
    }
}