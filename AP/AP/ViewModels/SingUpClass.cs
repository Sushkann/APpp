using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AP.ViewModels
{
    class SingUpClass
    {
        public ICommand Back => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
    }
}
