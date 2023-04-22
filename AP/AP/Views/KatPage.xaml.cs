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
	public partial class KatPage : ContentPage
	{
		public KatPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new CreateCategoryPage());
        }

        private  async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateCategoryPage());
        }
    }
}