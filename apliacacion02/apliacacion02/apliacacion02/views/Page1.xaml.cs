using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace apliacacion02.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        const double tasa = 19.11;
        void Limpiar()
        {
            PesosEntry.Text = string.Empty;
            DolaresLabel.Text = string.Empty;
        }

        private async void ConversorButton_Clicked(object sender, EventArgs e)
        {
            double pesos = 0, dolares = 0;


            if (double.TryParse(PesosEntry.Text, out pesos))
            {
                dolares = pesos / tasa;
                DolaresLabel.Text = $"{dolares:N2}";
            }
            else
            {
                await DisplayAlert("Error", "Cantidad no válida", "OK");
                Limpiar();
            }
        }

        private void LimpiarButton_Clicked(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}