using ProgramList.Common.Models;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ProgramList.Common.DynamicType
{
    public abstract class RunTimeModelBase: ModelBase
    {
        private Dictionary<string, object> _propertyValues;

        protected RunTimeModelBase(Dictionary<string, object> propertyValues)
        {
            _propertyValues = propertyValues;
        }

        public T GetValue<T>([CallerMemberName]string propertyName = "")
        {
            if (_propertyValues.ContainsKey(propertyName))
                return ((CustomProperty<T>)_propertyValues[propertyName]).Value;

            var property = new CustomProperty<T>(default(T));
            _propertyValues.Add(propertyName, property);

            return property.Value;

        }

        public void SetValue<T>(T value, [CallerMemberName]string propertyName = "")
        {
            _propertyValues[propertyName] = new CustomProperty<T>(value);
            OnPropertyChanged(propertyName);
        }
    }
}
