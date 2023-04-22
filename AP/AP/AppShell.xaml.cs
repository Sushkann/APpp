using AP.ViewModels;
using AP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace AP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(VxodLoginPage), typeof(VxodLoginPage));
            Routing.RegisterRoute(nameof(StstikPage), typeof(StstikPage));
            Routing.RegisterRoute(nameof(NastroikyPage), typeof(NastroikyPage));
            Routing.RegisterRoute(nameof(HelpPage), typeof(HelpPage));
            Routing.RegisterRoute(nameof(DobavitPage), typeof(DobavitPage));
            Routing.RegisterRoute(nameof(NapominaniePage), typeof(NapominaniePage));
            Routing.RegisterRoute(nameof(KatPage), typeof(KatPage));
            Routing.RegisterRoute(nameof(KalkulatorPage), typeof(KalkulatorPage));
            Routing.RegisterRoute(nameof(GrafikiPage), typeof(GrafikiPage));
            Routing.RegisterRoute(nameof(CreateLoginPage), typeof(CreateLoginPage));
            Routing.RegisterRoute(nameof(SchetPage), typeof(SchetPage));
            



        }
        
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

    }
}
