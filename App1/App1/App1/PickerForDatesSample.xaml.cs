using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerForDatesSample : ContentPage
	{
        public PickerForDatesSample ()
		{
			InitializeComponent ();
		}

        void GetDates()
        {
            IList<string> datesList = new List<string>();
            DateTime start = new DateTime(2018, 11, 27);
            DateTime end = new DateTime(2018, 12, 05);
            for (var dt = start; dt <= end; dt = dt.AddDays(1))
            {
                datesList.Add(dt.ToString("yyyy-MM-dd"));
            }
            dtPicker.ItemsSource = datesList.ToList();
            dtPicker2.ItemsSource = datesList.ToList();
        }

        private void BtnTest_Clicked_1(object sender, EventArgs e)
        {
            GetDates();
        }

        private void BtnFocusPicker_Clicked(object sender, EventArgs e)
        {
            dtPicker.Focus();
            //txtPicker.Focus();
            dtPicker.Unfocus();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            dtPicker2.Focus();
            dtPicker2.Unfocus();
        }
    }
}