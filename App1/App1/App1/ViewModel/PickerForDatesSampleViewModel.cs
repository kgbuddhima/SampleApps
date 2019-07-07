using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1.ViewModel
{
    public class PickerForDatesSampleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _selectedDate;
        public string SelectedDate
        {
            get
            {
                return _selectedDate;
            }
            set
            {
                _selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));

                SelectedDateOfEntry = _selectedDate;
                OnPropertyChanged(nameof(SelectedDateOfEntry));
            }
        }

        string _selectedDateOfEntry;
        public string SelectedDateOfEntry
        {
            get
            {
                return _selectedDateOfEntry;
            }
            set
            {
                _selectedDateOfEntry = value;
                OnPropertyChanged(nameof(SelectedDateOfEntry));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
