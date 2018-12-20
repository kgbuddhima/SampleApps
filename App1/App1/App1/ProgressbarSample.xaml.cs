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
	public partial class ProgressbarSample : ContentPage
	{
		public ProgressbarSample ()
		{
			InitializeComponent ();
		}

        private void BtnTest_Clicked(object sender, EventArgs e)
        {
            decimal max = Convert.ToDecimal(lblMax.Text);
            decimal val = Convert.ToDecimal(txtValue.Text);
            decimal progress = val / max;
            pb1.ProgressTo((double)progress, 1000, Easing.SinIn);
            Slider slider = new Slider();
            // DisplayAlert("Test","My message","OK");
        }

        private void BtnValPlus_Clicked(object sender, EventArgs e)
        {
            decimal val = Convert.ToDecimal(txtValue.Text);
            val++;
            txtValue.Text = val.ToString();
        }
    }
}