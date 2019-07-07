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

[assembly: ExportRenderer(typeof(EditorWithBorder), typeof(EditorWithBorderRenderer))]
namespace App1.iOS.Renderers
{
    public class EditorWithBorderRenderer : EditorRenderer
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Executes the element changed action. </summary>
        ///
        /// <remarks>   1/29/2019. </remarks>
        ///
        /// <param name="e">    The ElementChangedEventArgs&lt;Editor&gt; to process. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var view = (EditorWithBorder)Element;

                if (Control != null){
                    Control.KeyboardAppearance = UIKeyboardAppearance.Default;
                    Control.ReturnKeyType = UIReturnKeyType.Default;
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
}