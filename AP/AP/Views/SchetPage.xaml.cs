using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AP.Views
{
	
	public partial class SchetPage : ContentPage
	{
		public SchetPage ()
		{
			InitializeComponent ();
		}

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            string Msg = await DisplayActionSheet("Выбор счета", "Отменить", null, new string[] { "Основной", "Сберегательный", "Копилка" });
            await DisplayAlert("Выбор счета", $"Счет выбран : {Msg}", "Принять");
        }
    }
}