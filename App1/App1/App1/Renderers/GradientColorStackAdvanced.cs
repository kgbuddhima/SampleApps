using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.Renderers
{
    public class GradientColorStackAdvanced : StackLayout
    {
        //public string ColorsList { get; set; }
        public Color StartColor { get; set; }
        public Color EndColor { get; set; }

        public Color[] Colors
        {
            get
            {
               /* string[] hex = ColorsList.Split(',');
                Color[] colors = new Color[hex.Length];

                for (int i = 0; i < hex.Length; i++)
                {
                    colors[i] = Color.FromHex(hex[i].Trim());
                }*/

                return new Color[2] { StartColor,EndColor};
            }
        }

        public GradientColorStackModes.GradientColorStackMode Mode { get; set; }
    }
}
