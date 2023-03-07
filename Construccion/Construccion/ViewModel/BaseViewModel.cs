using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Construccion.ViewModel
{
    public class BaseViewModel : INotifyCollectionChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") 
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
