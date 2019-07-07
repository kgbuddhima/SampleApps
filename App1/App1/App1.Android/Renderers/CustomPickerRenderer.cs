using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using App1.Droid.Renderers;
using App1.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace App1.Droid.Renderers
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A custom picker renderer. </summary>
    ///
    /// <content> https://xamgirl.com/picker-with-right-side-icon-in-xamarin-forms/ </content>
    ///
    /// <remarks>   07/07/2019. </remarks>
    ///
    /// <example>   . </example>
    ///
    /// <inheritdoc/>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class CustomPickerRenderer : PickerRenderer
    {
        CustomPicker element;

        public CustomPickerRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            element = (CustomPicker)this.Element;

            /*if (Control != null && this.Element != null && !string.IsNullOrEmpty(element.Image))
                Control.Background = AddPickerStyles(element.Image);*/

            // creating gradient drawable for the curved background
            var _gradientBackground = new GradientDrawable();
            _gradientBackground.SetShape(ShapeType.Rectangle);
            _gradientBackground.SetColor(Android.Graphics.Color.Transparent.ToArgb());

            // Thickness of the stroke line  
            _gradientBackground.SetStroke(2, Android.Graphics.Color.Green);

            // Radius for the curves  
            /* _gradientBackground.SetCornerRadius(
                 DpToPixels(this.Context, Convert.ToSingle(0)));*/

            // set the background of the   
            Control.SetBackground(_gradientBackground);

        }

        public LayerDrawable AddPickerStyles(string imagePath)
        {
            ShapeDrawable border = new ShapeDrawable();
            border.Paint.Color = Android.Graphics.Color.Gray;
            border.SetPadding(10, 10, 10, 10);
            border.Paint.SetStyle(Paint.Style.Stroke);

            Drawable[] layers = { border};//, GetDrawable(imagePath) 
            LayerDrawable layerDrawable = new LayerDrawable(layers);
            layerDrawable.SetLayerInset(0, 0, 0, 0, 0);

            return layerDrawable;
        }

        private BitmapDrawable GetDrawable(string imagePath)
        {
            int resID = Resources.GetIdentifier(imagePath, "drawable", this.Context.PackageName);
            var drawable = ContextCompat.GetDrawable(this.Context, resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            var result = new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, 70, 70, true));
            result.Gravity = Android.Views.GravityFlags.Right;

            return result;
        }

    }
}