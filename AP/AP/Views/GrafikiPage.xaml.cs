using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;
using SkiaSharp;
using Entry = Microcharts.ChartEntry;

namespace AP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GrafikiPage : ContentPage
	{
		

		


        List<Entry> entries = new List<Entry>
        {
            new Entry(900)
            {
                Color=SKColor.Parse("#FF1943"),
                Label ="January",
                ValueLabel = "900"
            },
            new Entry(400)
            {
                Color = SKColor.Parse("#FF9640"),
                Label = "March",
                ValueLabel = "400"
            },
            new Entry(-100)
            {
                Color =  SKColor.Parse("#FFC300"),
                Label = "Octobar",
                ValueLabel = "-100"
            },
            };
        public GrafikiPage()
        {
            InitializeComponent();
           
            Chart3.Chart = new DonutChart() { Entries = (IEnumerable<ChartEntry>)entries };
       
        }

    }
}