
namespace JuanJoseArauzExamenP2
{
    public partial class MainPage : ContentPage
    {
        string Numero;


        public MainPage()
        {
            InitializeComponent();
        }

        private async void Recarga(object sender, EventArgs e)
        {
            string Numero = PhoneNumberText.Text;
            Numero = JuanJoseArauzExamenP2.Celular.ToNumber(Numero);
            
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
