using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.iOS.Renderers;
using App1.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationRenderercs))]
namespace App1.iOS.Renderers
{
    public class CustomNavigationRenderercs : NavigationRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var att = new UITextAttributes();
                att.Font = UIFont.FromName("Poppins-Light", 24);
                UINavigationBar.Appearance.SetTitleTextAttributes(att);
            }
        }
    }
}