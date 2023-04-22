using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;


namespace AP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NastroikyPage : ContentPage
	{
        Xamarin.Forms.Button button;
        public int maxLength { get; private set; }

        public NastroikyPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            StackLayout stack = new StackLayout();

            button = new Xamarin.Forms.Button();
            button.Text = "OK";
            button.Clicked += Button_Clicked;
        }

            private async void Button_Clic(object sender, EventArgs e)
            {
                string Msg = await DisplayActionSheet("Выбор языка", "Отменить", null, new string[] { "Русский", "English", "Espanol" });
                await DisplayAlert("Выбор языка", $"Язык выбран : {Msg}", "Принять");
            }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            string Msg = await DisplayActionSheet("Выбор счета", "Отменить", null, new string[] { "Основной", "Сберегательный", "Резерв" });
            await DisplayAlert("Выбор счета", $"Счет выбран : {Msg}", "Принять");
        }
        private async void Button_Cl(object sender, EventArgs e)
        {
            string Msg = await DisplayActionSheet("Выбор периода", "Отменить", null, new string[] { "Год", "Квартал", "Месяц","День" });
            await DisplayAlert("Выбор периода", $"Период выбран : {Msg}", "Принять");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            string Msg = await DisplayActionSheet("Выбор темы", "Отменить", null, new string[] { "По умолчанию", "Светлая тема", "Темная тема" });
            await DisplayAlert("Выбор темы", $"Тема выбрана : {Msg}", "Принять");
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Введите код-пароль", "Максимальная длина пароля 4 символа", "Установить", "Отмена", "Установите код-пароль",maxLength = 4 , initialValue: "1", keyboard: Keyboard.Numeric);

            await DisplayAlert("Ваш код-пароль обновлен!", $"Код-пароль: {result}", "ok");
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://financewalletapp.com/docs/privacy_policy.html");
            await Browser.OpenAsync(uri);
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            string Msg = await DisplayActionSheet("Вы действительно хотите удалить аккаунт?", "Отменить", null, new string[] { "Продолжить", "В профиле" });
            await DisplayAlert("Удаление аккаунта", $"Удалить? : {Msg}", "Принять");
        }
    }
}