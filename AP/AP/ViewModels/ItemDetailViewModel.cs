using AP.Models;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AP.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private string date;
        private string impotance;
        public string Id { get; set; }


        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public string Date {
            get => date;
            set => SetProperty(ref date, value);
        }
        public int Impotance { get; private set; }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                Date = item.Date;
                Impotance = item.Importance;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

       

        private string importance;

        public string Importance { get => importance; set => SetProperty(ref importance, value); }
    }
}
