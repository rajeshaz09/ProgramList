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
    public abstract class DynamicModelBase : DynamicObject, INotifyPropertyChanged
    {
        private bool _hasOwnProperties { get; }
        protected readonly IDictionary<string, object> PropertyValues;

        public DynamicModelBase(bool hasOwnProperties, Dictionary<string, object> propertyValues)
        {
            PropertyValues = propertyValues;
            _hasOwnProperties = hasOwnProperties;
        }

        #region DynamicObject
        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return PropertyValues.Keys;
        }
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_hasOwnProperties)
            {
                var property = GetType()
                           .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                           .Where((prop) => prop.Name == binder.Name).FirstOrDefault();

                if (property != null)
                    result = property.GetValue(this);
            }
            result = this[binder.Name];

            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (_hasOwnProperties)
            {
                var property = GetType()
                .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                .Where((prop) => prop.Name == binder.Name).FirstOrDefault();

                if (property != null)
                    property.SetValue(this, value);
            }
            this[binder.Name] = value;

            return true;
        }

        #endregion DynamicObject
        public virtual object this[string columnName]
        {
            get
            {
                if (PropertyValues.ContainsKey(columnName))
                {
                    return PropertyValues[columnName];
                }

                return null;
            }
            set
            {
                if (!PropertyValues.ContainsKey(columnName))
                {
                    PropertyValues.Add(columnName, value);

                    OnPropertyChanged(columnName);
                }
                else
                {
                    if (PropertyValues[columnName] != value)
                    {
                        PropertyValues[columnName] = value;

                        OnPropertyChanged(columnName);
                    }
                }
            }
        }
        #region INotifyPropertyChanged 
        private readonly ModelBase _baseModel = new ModelBase();

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                _baseModel.PropertyChanged += value;
            }
            remove
            {
                _baseModel.PropertyChanged -= value;
            }
        }

        protected void OnPropertyChanged([CallerMemberName]string name = "")
        {
            _baseModel.OnPropertyChanged(name);
        }

        public void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            _baseModel.SetProperty(ref storage, value, propertyName);
        }

        #endregion INotifyPropertyChanged


        public T GetValue<T>([CallerMemberName]string propertyName = "")
        {
            if (PropertyValues.ContainsKey(propertyName))
                return ((CustomProperty<T>)PropertyValues[propertyName]).Value;

            var property = new CustomProperty<T>(default(T));
            PropertyValues.Add(propertyName, property);

            return property.Value;

        }

        public void SetValue<T>(T value, [CallerMemberName]string propertyName = "")
        {
            PropertyValues[propertyName] = value;// new CustomProperty<T>(value);
            OnPropertyChanged(propertyName);
        }
    }
}
