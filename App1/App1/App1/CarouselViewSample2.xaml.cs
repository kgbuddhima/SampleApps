using App1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselViewSample2 : ContentPage
	{
        ViewModel.CarouselViewSample2ViewModel vm;
		public CarouselViewSample2 ()
		{
			InitializeComponent ();
            BindingContext = vm = new ViewModel.CarouselViewSample2ViewModel();
            CarouselZoos.ItemsSource = vm.itemList.ToList();

        }

        private void CarouselZoos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var zoo = e.SelectedItem as CarouselModel;
            if (zoo == null)
                return;

        }
    }
}