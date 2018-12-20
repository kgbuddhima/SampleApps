using App1.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselViewSample : ContentPage
	{
        MainViewModel _vm;
        public CarouselViewSample ()
		{
            InitializeComponent();

            Title = "CarouselView";

            BindingContext = _vm = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //carousel.ItemsSource = _vm.MyItemsSource;
        }

        void Handle_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            Debug.WriteLine("Position " + e.NewValue + " selected.");
        }

        void Handle_Scrolled(object sender, CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs e)
        {
            Debug.WriteLine("Scrolled to " + e.NewValue + " percent.");
            Debug.WriteLine("Direction = " + e.Direction);
        }
    }
}