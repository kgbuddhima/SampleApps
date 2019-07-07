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
using Android.Support.V7.Graphics.Drawable;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using App1.Droid.Renderers;
using App1.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationRenderercs))]
namespace App1.Droid.Renderers
{
    public class CustomNavigationRenderercs: NavigationPageRenderer
    {
        private Android.Support.V7.Widget.Toolbar _toolbar;

        public CustomNavigationRenderercs(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var navController = (INavigationPageController)e.NewElement;
                navController.PushRequested += NavController_PushRequested;
                navController.PopRequested += NavController_PopRequested;
            }
        }

        public override void OnViewAdded(Android.Views.View child)
        {
            if (child.GetType() == typeof(Android.Support.V7.Widget.Toolbar))
            {
                _toolbar = (Android.Support.V7.Widget.Toolbar)child;
                _toolbar.ChildViewAdded += Toolbar_ChildViewAdded;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
               // _toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
            }
        }

        private void Toolbar_ChildViewAdded(object sender, ChildViewAddedEventArgs e)
        {
            var view = e.Child.GetType();

            if (e.Child.GetType() == typeof(Android.Support.V7.Widget.AppCompatTextView))
            {
                var textView = (Android.Support.V7.Widget.AppCompatTextView)e.Child;
                var spaceFont = Typeface.CreateFromAsset(Context.ApplicationContext.Assets, "Poppins-Light.ttf");
                textView.Typeface = spaceFont;
                _toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
            }
        }

        private void NavController_PopRequested(object sender, Xamarin.Forms.Internals.NavigationRequestedEventArgs e)
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(220), () =>
            {
                ChangeIconColor();
                return false;
            });
        }

        private void NavController_PushRequested(object sender, Xamarin.Forms.Internals.NavigationRequestedEventArgs e)
        {
            ChangeIconColor();
        }

        private void ChangeIconColor()
        {
            int count = this.ViewGroup.ChildCount;

            var toolbar = GetToolbar();

            if (toolbar.NavigationIcon != null)
            {
                var drawable = (toolbar.NavigationIcon as DrawerArrowDrawable);
                drawable.Color =Android.Graphics.Color.Purple;//set the navigation icon color here
            }
            toolbar.SetBackgroundColor(Android.Graphics.Color.Yellow);
            //toolbar.SetTitleTextColor();
        }

        private Android.Support.V7.Widget.Toolbar GetToolbar()
        {
            for (int i = 0; i < this.ViewGroup.ChildCount; i++)
            {
                var child = this.ViewGroup.GetChildAt(i);
                if (child is Android.Support.V7.Widget.Toolbar)
                {
                    return (Android.Support.V7.Widget.Toolbar)child;
                }
            }

            return null;
        }
    }
}