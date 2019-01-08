using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void BtnDatePicker_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DatePickerSample());
        }

        private void BtnPicerForDates_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PickerForDatesSample());
        }

        private void BtnProgressbarSample_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgressbarSample());
        }

        private void BtnSliderSample_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SliderDemo());
        }

        private void BtnCarouselViewSample_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarouselViewSample());
        }

        private void BtnCarouselViewSample2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarouselViewSample2());
        }

        private void BtnCarouselViewMonkeys_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MonkeysPage());
        }

        private void BtnNavigationSectionDemo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageWithNavigationUCView());
        }

        private void BtnEntryBorderDemo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryWithBorderDemo());
        }
    }
}
