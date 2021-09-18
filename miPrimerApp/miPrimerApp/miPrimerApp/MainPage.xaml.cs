using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace miPrimerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //private async void Button_Clicked(object sender )
        private async void BTNatras(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "bon atras", "ok");
        }
        private async void BTEnviar(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Quieres enviar", "ok","Cancelar");
        }
        private async void OnActionSheetSimpleClicked(object sender, EventArgs e)
        {
            await DisplayActionSheet("ActionShellt: Send to?", "Cancel", null, "Email", "twiter", "Facebook");
        }
    }
}
