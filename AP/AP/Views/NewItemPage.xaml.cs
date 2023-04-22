using AP.Models;
using AP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AP.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatePickerDate_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}