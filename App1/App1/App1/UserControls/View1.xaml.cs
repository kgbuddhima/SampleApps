using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FFImageLoading.Forms;

namespace App1.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View1 : ContentView
    {
        public ImageSource ImageSource
        {
            get { return imgMyImage.Source; }
            set { imgMyImage.Source = value; }
        }
        public string ImageDescription
        {
            get { return txtImageDesc.Text; }
            set { txtImageDesc.Text = value; }
        }
        public Color FrameColor
        {
            get { return frameMyFrame.BackgroundColor; }
            set { frameMyFrame.BackgroundColor = value; }
        }
        public Color CaroseBackColor
        {
            get { return BackgroundColor; }
            set { BackgroundColor = value; }
        }

        public View1()
        {
            InitializeComponent();
        }
    }
}