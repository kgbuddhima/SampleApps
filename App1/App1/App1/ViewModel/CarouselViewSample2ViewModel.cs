using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using FFImageLoading.Forms;
using Xamarin.Forms;


namespace App1.ViewModel
{
    public class CarouselViewSample2ViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<CarouselModel> itemList = new ObservableCollection<CarouselModel>();
        public string generalString { get; set; }

        public Command MyCommand { protected set; get; }

        public CarouselViewSample2ViewModel()
        {
            MyCommand = new Command(() =>
            {
                Debug.WriteLine("Position selected.");
            });

            generalString = "Swipe to Take Tour";
            itemList.Add(new CarouselModel() {ImageName= "image1.png", TextString="My Image 1" });
            itemList.Add(new CarouselModel() { ImageName = "image2.png", TextString = "My Image 2" });
            itemList.Add(new CarouselModel() { ImageName = "c3.jpg", TextString = "My Image 3" });
            itemList.Add(new CarouselModel() { ImageName = "c1.jpg", TextString = "My Image 4" });
            itemList.Add(new CarouselModel() { ImageName = "c2.jpg", TextString = "My Image 5" });
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    public class CarouselModel
    {
        public string ImageName { get; set; }
        public string TextString { get; set; }
    }
}
