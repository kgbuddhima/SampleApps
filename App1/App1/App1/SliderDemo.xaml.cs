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
	public partial class SliderDemo : ContentPage
	{
		public SliderDemo ()
		{
			InitializeComponent ();
		}

        private void Slidertest_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = e.NewValue; //Math.Round(e.NewValue / 100);
            lblTextProgress.Text = $"$ " + newStep.ToString();
            lblTextProgress.TranslateTo(slidertest.Value * ((slidertest.Width - 40) / slidertest.Maximum), 0, 250);
        }
    }
}