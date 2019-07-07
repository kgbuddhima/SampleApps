using App1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderWithMessaging : ContentPage
    {
        public SliderWithMessaging()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<SliderWithMessagingViewModel, string>(this, "Change", (sender, args) =>
               {
                   ChangeMaximumAndMin(args);
               });
        }

        private void ChangeMaximumAndMin(string args)
        {
            SliderWithMessagingViewModel model = (BindingContext) as SliderWithMessagingViewModel;
            if (args == "Y")
            {
                SliderA.Maximum = model.SliderMax;
                SliderA.Minimum = model.SliderMin;
                SliderA.Value = -1;
                SliderA.Value = model.SliderVal;
            }
        }
    }
}