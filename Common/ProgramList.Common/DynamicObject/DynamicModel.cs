using ProgramList.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.Common.DynamicType
{
    public class DynamicModel : DynamicObject, IListItemBase, INotifyPropertyChanged
    {
        private IList<IColumnInfo> _columns;
        private Dictionary<string, CellInfo> _PropertyValues;

        public DynamicModel(IList<IColumnInfo> columns, int rowNumber)
        {
            _columns = columns;
            _rowNumber = rowNumber;
            _PropertyValues = new Dictionary<string, CellInfo>(_columns.Count);

            foreach (var column in _columns)
            {
                _PropertyValues.Add(column.UniqueName, new CellInfo(column, this, false));
            }

        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = _PropertyValues[binder.Name];

            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _PropertyValues[binder.Name].Data = value;

            return true;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _PropertyValues.Keys;
        }

        public void SetData<T>(T value, [CallerMemberName]string propertyName = "")
        {
            _PropertyValues[propertyName].Data = value;
        }

        private bool IsCellStylingProperty(string styleProperty)
        {
            return CellInfo.CustomisationProperties.Contains(styleProperty);
        }


        private int _rowNumber = -1;
        public int RowNumber
        {
            get
            {
                return _rowNumber;
            }
            private set
            {
                SetProperty(ref _rowNumber, value);
            }
        }

        private string _background;
        public string Background
        {
            get
            {
                return _background;
            }
            set
            {
                SetProperty(ref _background, value);
            }
        }

        private string _foreground;
        public string Foreground
        {
            get
            {
                return _foreground;
            }
            set
            {
                SetProperty(ref _foreground, value);
            }
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                SetProperty(ref _isEnabled, value);
            }
        }

        private bool _isReadOnly = false;
        public bool IsReadOnly
        {
            get
            {
                return _isReadOnly;
            }
            set
            {
                SetProperty(ref _isReadOnly, value);
            }
        }

        private bool _isInEditMode;
        public bool IsInEditMode
        {
            get
            {
                return _isInEditMode;
            }
            set
            {
                SetProperty(ref _isInEditMode, value);
            }
        }


        private bool _isCurrent;
        public bool IsCurrent
        {
            get
            {
                return _isCurrent;
            }
            set
            {
                SetProperty(ref _isCurrent, value);
            }
        }

        public string GetForeground(string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
                return _PropertyValues[propertyName].Foreground;

            return null;
        }

        public void SetForeground(string foreground, string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
            {
                var cellProperties = _PropertyValues[propertyName];
                if (cellProperties.Foreground == foreground)
                    return;
                _PropertyValues[propertyName].Foreground = foreground;
                return;
            }
            return;

        }

        public string GetBackground(string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
                return _PropertyValues[propertyName].Background;

            return null;
        }

        public void SetBackground(string background, string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
            {
                var cellProperties = _PropertyValues[propertyName];
                if (cellProperties.Background == background)
                    return;
                _PropertyValues[propertyName].Background = background;
                return;
            }
            return;

        }

        public bool GetIsEnabled(string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
                return _PropertyValues[propertyName].IsEnabled;

            return true;
        }

        public void SetIsEnabled(bool isEnabled, string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
            {
                var cellProperties = _PropertyValues[propertyName];
                if (cellProperties.IsEnabled == isEnabled)
                    return;
                _PropertyValues[propertyName].IsEnabled = isEnabled;
                return;
            }
            return;
        }

        public bool GetIsReadOnly(string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
                return _PropertyValues[propertyName].IsReadOnly;

            return true;
        }

        public void SetIsReadOnly(bool isReadOnly, string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
            {
                var cellProperties = _PropertyValues[propertyName];
                if (cellProperties.IsReadOnly == isReadOnly)
                    return;
                _PropertyValues[propertyName].IsReadOnly = isReadOnly;
                return;
            }
            return;

        }

        public bool GetIsInEditMode(string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
                return _PropertyValues[propertyName].IsInEditMode;

            return true;
        }

        public void SetIsInEditMode(bool isInEditMode, string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
            {
                var cellProperties = _PropertyValues[propertyName];
                if (cellProperties.IsInEditMode == isInEditMode)
                    return;
                _PropertyValues[propertyName].IsInEditMode = isInEditMode;
                return;
            }
            return;
        }

        public bool GetIsCurrent(string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
                return _PropertyValues[propertyName].IsCurrent;

            return true;
        }

        public void SetIsCurrent(bool isCurrent, string propertyName)
        {
            if (_PropertyValues.ContainsKey(propertyName))
            {
                var cellProperties = _PropertyValues[propertyName];
                if (cellProperties.IsCurrent == isCurrent)
                    return;
                _PropertyValues[propertyName].IsCurrent = isCurrent;
                return;
            }
            return;

        }


        #region INotifyPropertyChanged 


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

        #endregion INotifyPropertyChanged



    }
}
