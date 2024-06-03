namespace JuanJoseArauzExamenP2
{
    public partial class MainPage : ContentPage
    {
        string Numero;

        private void Recarga(object sender, EventArgs e)
        {
            string Numero = PhoneNumberText.Text;
            Numero = JuanJoseArauzExamenP2.Celular.ToNumber(Numero);
        }

        async void EnRecarga(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlert(
       "Confirmacion",
       "¿Desea recargar la cantidad seleccionada?",
       "Si",
       "No"))
            {
                await DisplayAlert("Finalizado", "Recarga exitosa", "OK");
            }

        }
    }

}