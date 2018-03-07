using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DevExpressSoring
{
    public class ModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            if (!EqualityComparer<T>.Default.Equals(storage, value))
            {
                storage = value;
                OnPropertyChanged(propertyName);
                return true;
            }
            return false;
        }
    }
}
