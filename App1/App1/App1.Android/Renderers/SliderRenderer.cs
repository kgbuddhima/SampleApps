using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1.Renderers;
using Xamarin.Forms.Platform.Android;
using App1.Droid.Renderers;
using Xamarin.Forms;
using Android.Graphics;
using Android.Graphics.Drawables;
using Color = Android.Graphics.Color;

[assembly: ExportRenderer(typeof(CustomSlider), typeof(CustomSliderRenderer))]
namespace App1.Droid.Renderers
{
    public class CustomSliderRenderer : SliderRenderer
    {
        public CustomSliderRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.ProgressDrawable.SetColorFilter(
                new PorterDuffColorFilter(
                                            Xamarin.Forms.Color.FromHex("#F50F76").ToAndroid(),
                                            PorterDuff.Mode.SrcIn));

                // Set Progress bar Thumb color
                Control.Thumb.SetColorFilter(
                    Xamarin.Forms.Color.FromHex("#F50F76").ToAndroid(),
                    PorterDuff.Mode.SrcIn);

                //Change height
                //Control.ScaleY = 10;
                GradientDrawable p = new GradientDrawable();
                p.SetCornerRadius(10);
                p.SetColor(Color.Rgb(0x70, 0xb2, 0x3f));
                ClipDrawable progress = new ClipDrawable(p, GravityFlags.Left, ClipDrawableOrientation.Horizontal);
                GradientDrawable background = new GradientDrawable();
                background.SetColor(Color.Rgb(0xe0, 0xe0, 0xe0));
                background.SetCornerRadius(10);
                LayerDrawable pd = new LayerDrawable(new Drawable[] { background, progress });
                Control.SetProgressDrawableTiled(pd);

            }
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
        }
    }
}
