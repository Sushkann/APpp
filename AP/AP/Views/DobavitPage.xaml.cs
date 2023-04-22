using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DobavitPage : ContentPage
	{
		public DobavitPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
			string Msg = await DisplayActionSheet("Выбор счета", "Отменить", null, new string[] { "Основной", "Сберегательный", "Резерв" });
			await DisplayAlert("Выбор счета", $"Счет выбран : {Msg}", "Принять");
        }

        

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RasxodPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoxodPage());
        }
    }
}