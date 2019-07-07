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
	public partial class PickerWithIconUC : ContentView
	{
        public Color IconBackgroundColor
        {
            get { return iconBackground.BackgroundColor; }
            set { iconBackground.BackgroundColor = value; }
        }

        public IList<string> PickerItemSource
        {
            get
            {
                return (IList<string>)dtPicker2.ItemsSource;
            }
            set
            {
                dtPicker2.ItemsSource = new List<string>(value);
            }
        }

        public static readonly BindableProperty SelectedItemProperty =
        BindableProperty.Create(nameof(SelectedItem),
            typeof(string), typeof(string), string.Empty);
        // Gets or sets IsCurvedCornersEnabled value  
        public string SelectedItem
        {
            get => (string)GetValue(SelectedItemProperty);
            set
            {
                SetValue(SelectedItemProperty, value);
            }
        }

        public PickerWithIconUC()
		{
			InitializeComponent();            
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            dtPicker2.Focus();
            dtPicker2.Unfocus();
        }

        private void DtPicker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = Convert.ToString(dtPicker2.SelectedItem);
        }
    }
}