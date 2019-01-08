using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.UserControls;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageWithNavigationUCView : ContentPage
	{
		public PageWithNavigationUCView ()
		{
			InitializeComponent ();
            NavStackTwo.BackButtonClicked += new OnBackButtonPressed(Navigateback);

        }

        void Navigateback(object sender, EventArgs e)
        {
            Navigation.PopAsync(true);
        }

        void Navigateback1(object sender, EventArgs e)
        {
            Navigation.PopAsync(true);
        }
    }
}