using ProgramList.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.Common.DynamicType
{
    public class CustomTypeProviderBaseModel<T> : ICustomTypeProvider, INotifyPropertyChanged
    {
        private CustomTypeProviderType _customType;
        private readonly List<CustomTypeProviderPropertyInfo> _customProperties;
        private readonly Dictionary<string, object> _customPropertyValues;

        public CustomTypeProviderBaseModel(List<CustomTypeProviderPropertyInfo> customProperties)
        {
            _customProperties = customProperties;
            _customPropertyValues = new Dictionary<string, object>(customProperties.Count);
            foreach (var property in _customProperties)
                _customPropertyValues.Add(property.Name, null);
        }

        public static CustomTypeProviderPropertyInfo ConstructProperty(string name, Type propertyType)
        {
            return new CustomTypeProviderPropertyInfo(name, propertyType, typeof(T));
        }
        public void SetPropertyValue(string propertyName, object value)
        {
            CustomTypeProviderPropertyInfo propertyInfo = _customProperties.FirstOrDefault(prop => prop.Name == propertyName);
            if (propertyInfo == null || !_customPropertyValues.ContainsKey(propertyName))
            {
                throw new Exception("There is no property with the name " + propertyName);
            }

            if (ValidateValueType(value, propertyInfo._type))
            {
                if (_customPropertyValues[propertyName] != value)
                {
                    _customPropertyValues[propertyName] = value;
                    OnPropertyChanged(propertyName);
                }
            }
            else
            {
                throw new Exception("Value is of the wrong type or null for a non-nullable type.");
            }
        }

        public object GetPropertyValue(string propertyName)
        {
            if (_customPropertyValues.ContainsKey(propertyName))
            {
                return _customPropertyValues[propertyName];
            }
            throw new Exception("There is no property " + propertyName);
        }

        public TV GetPropertyValue<TV>(string propertyName)
        {
            return (TV)GetPropertyValue(propertyName);
        }

        public PropertyInfo[] GetProperties()
        {
            return GetCustomType().GetProperties();
        }

        public Type GetCustomType()
        {
            if (_customType == null)
            {
                _customType = new CustomTypeProviderType(typeof(T), _customProperties);
            }

            return _customType;
        }

        private bool ValidateValueType(object value, Type type)
        {
            return value == null
                ? !type.IsValueType || type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>)
                : type.IsAssignableFrom(value.GetType());
        }

        private bool CheckIfNameExists(string name)
        {
            if (_customProperties.Any(p => 0 == string.Compare(p.Name, name, StringComparison.OrdinalIgnoreCase))
                || typeof(T).GetProperties().Any(p => 0 == string.Compare(p.Name, name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Property with this name already exists: " + name);
            }

            return false;
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

        #region NotRequired
        private void AddProperty(string name)
        {
            AddProperty(name, typeof(string));
        }

        private void ClearProperties()
        {
            _customProperties.Clear();
            _customPropertyValues.Clear();
        }

        private void RemoveProperty(string name)
        {
            var item = _customProperties.FirstOrDefault(cp => cp.Name == name);
            if (item != null)
            {
                _customProperties.Remove(item);
            }
            if (_customPropertyValues.ContainsKey(name))
            {
                _customPropertyValues.Remove(name);
            }
        }

        private void AddProperty(string name, Type propertyType)
        {
            if (!CheckIfNameExists(name))
            {
                _customProperties.Add(new CustomTypeProviderPropertyInfo(name, propertyType, typeof(T)));
                AddDefaultValue(name);
            }
        }

        private void AddDefaultValue(string name)
        {
            if (!_customPropertyValues.ContainsKey(name))
            {
                _customPropertyValues[name] = null;
            }
        }

        private void AddProperty(string name, Type propertyType, List<Attribute> attributes)
        {
            if (!CheckIfNameExists(name))
            {
                _customProperties.Add(new CustomTypeProviderPropertyInfo(name, propertyType, attributes, typeof(T)));
                AddDefaultValue(name);
            }
        }

        #endregion NotRequired
    }
}

