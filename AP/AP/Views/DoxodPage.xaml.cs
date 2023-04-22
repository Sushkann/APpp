using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using static AP.ViewModels.AboutViewModel;

namespace AP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoxodPage : ContentPage
	{
       

        public DoxodPage ()
		{
			InitializeComponent ();

            datePicker.MinimumDate = DateTime.Now.Date;
            datePicker.MaximumDate = DateTime.Now.AddDays(15).Date;
        }

        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "Выбор счета :   " ;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string Msg = await DisplayActionSheet("Выбор валюты", "Отменить", null, new string[] { "Руб", "USD", "EUR" });
            await DisplayAlert("Выбор валюты", $"Валюта выбрана : {Msg}", "Принять");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new  KalkulatorPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KatPage());
        }
    }
}