using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.Renderers
{
    public class CustomNavigationPage: NavigationPage
    {
        public CustomNavigationPage(Page root) : base(root)
        {
            BarBackgroundColor = Color.Blue;
            BarTextColor = Color.AliceBlue;
        }
    }
}
