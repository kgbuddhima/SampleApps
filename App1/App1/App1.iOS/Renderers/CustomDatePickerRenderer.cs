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

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace App1.iOS.Renderers
{
    public class CustomDatePickerRenderer:DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            if (this.Control == null)
                return;
            var element = e.NewElement as CustomDatePicker;
            if (!string.IsNullOrWhiteSpace(element.Placeholder))
            {
                Control.Text = element.Placeholder;
            }
            Control.BorderStyle = UITextBorderStyle.RoundedRect;
            Control.Layer.BorderColor = element.BorderColor.ToCGColor();   
            Control.Layer.CornerRadius = (nfloat)element.CornerRadius;
            Control.Layer.BorderWidth = (nfloat)element.BorderWidth;
            Control.AdjustsFontSizeToFitWidth = true;
            Control.TextColor =(element.TextColor).ToUIColor();

            Control.ShouldEndEditing += (textField) => {
               var seletedDate = (UITextField)textField;
               var text = seletedDate.Text;
               if (text == element.Placeholder)
               {
                   Control.Text = DateTime.Now.ToString("dd/MM/yyyy");
               }
               return true;
           };
        }

        private void OnCanceled(object sender, EventArgs e)
        {
            Control.ResignFirstResponder();
        }
        private void OnDone(object sender, EventArgs e)
        {
            Control.ResignFirstResponder();
        }
    }
}