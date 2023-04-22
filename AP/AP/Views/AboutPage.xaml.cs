using AP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace AP.Views
{
    public partial class AboutPage : ContentPage
    {
        Button button;

        public AboutPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            StackLayout stack = new StackLayout();

            button= new Button();
            button.Text= "OK";
            button.Clicked += Button_Clicked;
            button.Clicked += Button_Clicked_1;
            button.Clicked += Button_Clicked_2;
            button.Clicked += Button_Clicked_3;
            button.Clicked += Button_Clicked_4;
            button.Clicked += Button_Clicked_5;
            button.Clicked += Button_Clicked_6;
            button.Clicked += Button_Clicked_7;
            button.Clicked += Button_Clicked_8;
            button.Clicked += Button_Clicked_9;
            button.Clicked += Button_Clicked_10;
        }






        private async void Button_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.banki.ru/credit-master/");
            await Browser.OpenAsync(uri);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.banki.ru/card-master/?utm_source=prt_admon_web-26&utm_medium=prt&utm_campaign=prt_admon_12_web-26_of-mpcardntv_st-s26hl_tr-5c73c384-b79a-4d2c-8f79-1e95f58d3802_sb-&sub=&offer_id=mpcardntv&source=prt_admon_12_web-26_of-mpcardntv_st-s26hl_tr-5c73c384-b79a-4d2c-8f79-1e95f58d3802_sb-&sub=&utm_content=s26hl&oid=mpcardntv&wid=s26hl&statid=11_&clickid=5c73c384-b79a-4d2c-8f79-1e95f58d3802");
            await Browser.OpenAsync(uri);
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://winvestor.coinkeeper.me/funds");
            await Browser.OpenAsync(uri);
        }
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.banki.ru/service/landing-page/78/?utm_source=prt_admon_web-26&utm_medium=prt&utm_campaign=prt_admon_12_web-26_of-dpstrevsh_st-s26hl_tr-4b7b1480-bb0d-4f04-a930-6f708068c4d5_sb-&sub=&offer_id=dpstrevsh&source=prt_admon_12_web-26_of-dpstrevsh_st-s26hl_tr-4b7b1480-bb0d-4f04-a930-6f708068c4d5_sb-&sub=&utm_content=s26hl&oid=dpstrevsh&wid=s26hl&statid=11_&clickid=4b7b1480-bb0d-4f04-a930-6f708068c4d5");
            await Browser.OpenAsync(uri);
        }
        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://snowball-income.com/?promo=coinkeeper");
            await Browser.OpenAsync(uri);
        }
        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://snowball-income.com/?promo=coinkeeper");
            await Browser.OpenAsync(uri);
        }
        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://account.cifra-broker.ru/?utm_source=yandex&utm_medium=cpc&utm_campaign=BS_web_srch_kosv_Msk&utm_content=%7Ccid%7C71308985%7Cgid%7C4821726420%7Caid%7C11733302188%7Cpid%7C36444706053%7Csrct%7Csearch%7Csrc%7Cnone%7Cregion_id%7C10716%7Cregion_name%7CБалашиха%7Cdvc%7Cdesktop%7Cpos%7Cpremium1%7Cmatchtype%7C%7Crid%7C36444706053%7Ccoef%7C0&utm_term=онлайн%20инвестиции&cm_id=71308985_4821726420_11733302188_36444706053_36444706053_none_search_type1_no_desktop_premium_10716&_openstat=ZGlyZWN0LnlhbmRleC5ydTs3MTMwODk4NTsxMTczMzMwMjE4ODt5YW5kZXgucnU6cHJlbWl1bQ&yclid=17869303685526847487");
            await Browser.OpenAsync(uri);
        }
        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://snowball-income.com/?promo=coinkeeper");
            await Browser.OpenAsync(uri);
        }
        private async void Button_Clicked_8(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://snowball-income.com/?promo=coinkeeper");
            await Browser.OpenAsync(uri);
        }
        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://snowball-income.com/?promo=coinkeeper");
            await Browser.OpenAsync(uri);
        }
        private async void Button_Clicked_10(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://snowball-income.com/?promo=coinkeeper");
            await Browser.OpenAsync(uri);
        }
    }


}
       