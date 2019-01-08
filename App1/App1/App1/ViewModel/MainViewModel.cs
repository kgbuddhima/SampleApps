using FFImageLoading.Forms;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;
using App1.UserControls;

namespace App1.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            MyItemsSource = new ObservableCollection<SampleClass>()
            {
                new SampleClass(){ImageName="c1.jpg",ImageText="Text 1"},
                new SampleClass(){ImageName="c2.jpg",ImageText="Text 2"},
                new SampleClass(){ImageName="c3.jpg",ImageText="Text 3"}
                /*new View1(){ImageSource="image1.png",ImageDescription="Text 1"},
                new View1(){ImageSource="image2.png",ImageDescription="Text 2"},
                new View1(){ImageSource="c1.jpg",ImageDescription="Text 1"},
                new View1(){ImageSource="c2.jpg",ImageDescription="Text 2"},
                new View1(){ImageSource="c3.jpg",ImageDescription="Text 3"}*/
                //new DataTemplate(()=>{ return new Image(); }),
                /*new CachedImage() { Source = "image1.png", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
                new CachedImage() { Source = "image2.png", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
                new CachedImage() { Source = "c1.jpg", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
                new CachedImage() { Source = "c2.jpg", DownsampleToViewSize = true, Aspect = Aspect.AspectFill },
                new CachedImage() { Source = "c3.jpg", DownsampleToViewSize = true, Aspect = Aspect.AspectFill }*/
            };

            MyCommand = new Command(() =>
            {
                Debug.WriteLine("Position selected.");
            });
        }

        ObservableCollection<SampleClass> _myItemsSource;
        public ObservableCollection<SampleClass> MyItemsSource
        {
            set
            {
                _myItemsSource = value;
                OnPropertyChanged("MyItemsSource");
            }
            get
            {
                return _myItemsSource;
            }
        }

        public Command MyCommand { protected set; get; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class SampleClass
    {
        public string ImageName { get; set; }
        public string ImageText { get; set; }
    }
}