using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AP.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            banners = GetBanners();
            Number = GetBanners().Count;
            picks = GetPick();

        }

        #region list
        public static int Number;
        public List<Banner> banners { get; set; }
        public List<Pick> picks { get; set; }
        #endregion



        #region Method


        public List<Banner> GetBanners()
        {
            return new List<Banner>
            {
                new Banner
                {
                    Title = "tyt text", Description = "29,03,23", Image = "Oregane.png"
                }
                ,
                 new Banner
                {
                    Title = "tyt text", Description = "29,03,23", Image = "Monky.png"
                }
                 ,
                  new Banner
                {
                    Title = "tyt text", Description = "29,03,23", Image = "Oregane.png"
                }


            };
        }


        public List<Pick> GetPick()
        {
            return new List<Pick>
            {
                new Pick
                {
                    Title = "tyt text", Description = "29,03,23", Image = "Oregane.png"
                }
                ,
                 new Pick
                {
                    Title = "tyt text", Description = "29,03,23", Image = "Oregane.png"
                }
                 ,
                  new Pick
                {
                    Title = "tyt text", Description = "29,03,23", Image = "Oregane.png"
                }


            };
        }


        #endregion


        #region class

        public class Banner
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
        }
        public class Pick
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
        }

        

       


        #endregion
    }
}


