using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageCustomNavBarMaster : ContentPage
    {
        public ListView ListView;

        public MasterPageCustomNavBarMaster()
        {
            InitializeComponent();
            BindingContext = new MasterPageCustomNavBarMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterPageCustomNavBarMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterPageCustomNavBarMenuItem> MenuItems { get; set; }

            public MasterPageCustomNavBarMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterPageCustomNavBarMenuItem>(new[]
                {
                    new MasterPageCustomNavBarMenuItem { Id = 0, Title = "My Page 1" },
                    new MasterPageCustomNavBarMenuItem { Id = 1, Title = "My Page 2" },
                    new MasterPageCustomNavBarMenuItem { Id = 2, Title = "My Page 3" },
                    new MasterPageCustomNavBarMenuItem { Id = 3, Title = "My Page 4" },
                    new MasterPageCustomNavBarMenuItem { Id = 4, Title = "My Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}