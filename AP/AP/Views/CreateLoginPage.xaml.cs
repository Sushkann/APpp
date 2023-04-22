﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateLoginPage : ContentPage
	{
		public CreateLoginPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new VxodLoginPage());
        }
    }
}