using App1.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.UserControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationSectionTwo : ContentView
	{
        public Color StartColor
        {
            get { return stackLayoutHeader.StartColor; }
            set { stackLayoutHeader.StartColor = value; }
        }

        public Color EndColor
        {
            get { return stackLayoutHeader.EndColor; }
            set { stackLayoutHeader.EndColor = value; }
        }

        public GradientColorStackModes.GradientColorStackMode Mode
        {
            get { return stackLayoutHeader.Mode; }
            set { stackLayoutHeader.Mode = value; }
        }

        public string HeadingText
        {
            get { return lblHeading.Text; }
            set { lblHeading.Text = value; }
        }

        public NavigationSectionTwo ()
		{
            InitializeComponent ();
            stackLayoutHeader.StartColor = StartColor;
            stackLayoutHeader.EndColor = EndColor;
            stackLayoutHeader.Mode = Mode;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // await Navigation.PopAsync();
            BackButtonClicked?.Invoke(null, null);
        }

        public OnBackButtonPressed BackButtonClicked { get; set; }

    }

    public delegate void OnBackButtonPressed(object sender, EventArgs e);
}