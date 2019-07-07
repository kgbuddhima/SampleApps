using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModel
{
    public class SliderWithMessagingViewModel : INotifyPropertyChanged
    {
        public ICommand CalculateValuesCommand { get; private set; }

        int _maxValue;
        int _minValue;
        int _valueEntry;

        int _sliderVal;
        int _max;
        int _min;

        public int MaxEntry
        { get => _maxValue;
            set
            {
                _maxValue = value;
                OnPropertyChanged(nameof(MaxEntry));
            }
        }
        public int MinEntry
        { get => _minValue;
            set
            {
                _minValue = value;
                OnPropertyChanged(nameof(MinEntry));
            }
        }

        public int ValueEntry
        {
            get => _valueEntry;
            set
            {
                _valueEntry = value;
                OnPropertyChanged(nameof(ValueEntry));
            }
        }

        public int SliderVal
        {
            get => _sliderVal;
            set
            {
                _sliderVal = value;
                OnPropertyChanged(nameof(SliderVal));
            }
        }
        public int SliderMax
        {
            get => _max;
            set
            {
                _max = value;
                OnPropertyChanged(nameof(SliderMax));
            }
        }
        public int SliderMin
        {
            get => _min;
            set
            {
                _min = value;
                OnPropertyChanged(nameof(SliderMin));
            }
        }

        public SliderWithMessagingViewModel()
        {
            SliderMax = 1;
            SliderMin = 0;
            SliderVal = 0;
            MaxEntry = 1500;
            MinEntry = 0;
            ValueEntry = 0;
            CalculateValuesCommand = new Command(Calculate);
        }

        private void Calculate()
        {
            SliderMax = MaxEntry;
            SliderMin = MinEntry;
            // SliderVal = -1;
            SliderVal = ValueEntry;
            MessagingCenter.Send(this,"Change","Y");
        }

        public void ChangeValue()
        {
            MessagingCenter.Send(this, "Change", "X");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
        }
    }
}
