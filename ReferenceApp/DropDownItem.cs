using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ScrollIntoViewAsyncMvvm
{
    public class DropDownItem : INotifyPropertyChanged
    {
        public const string IdProperty = nameof(Id);
        public const string NameProperty = nameof(Name);
        public DropDownItem(string id, string value)
        {
            _id = id;
            _name = value;
        }

        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                SetProperty(ref _id, value);
            }
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetProperty(ref _name, value);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {

            if (!EqualityComparer<T>.Default.Equals(storage, value))
            {
                storage = value;
                OnPropertyChanged(propertyName);
            }
        }
    }
}
