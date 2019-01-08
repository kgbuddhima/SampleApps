using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.iOS.Renderers;
using App1.Renderers;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryWithBorder), typeof(EntryWithBorderRenderer))]
namespace App1.iOS.Renderers
{
    public class EntryWithBorderRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var view = (EntryWithBorder)Element;

                Control.LeftView = new UIView(new CGRect(0f, 0f, 9f, 20f));
                Control.LeftViewMode = UITextFieldViewMode.Always;

                Control.KeyboardAppearance = UIKeyboardAppearance.Dark;
                Control.ReturnKeyType = UIReturnKeyType.Done;
                // Radius for the curves  
                Control.Layer.CornerRadius = Convert.ToSingle(view.CornerRadius);
                // Thickness of the Border Color  
                Control.Layer.BorderColor = view.BorderColor.ToCGColor();
                // Thickness of the Border Width  
                Control.Layer.BorderWidth = view.BorderWidth;
                Control.ClipsToBounds = true;
            }
        }
    }
}