using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ProgramList.POC.Models
{
    public class CustomTypeDescriptorBaseModel : CustomTypeDescriptor, INotifyPropertyChanged
    {
        #region Private Fields

        List<PropertyDescriptor> _properties = new List<PropertyDescriptor>();
        private IList<CellInfo> _cellInfoList= new List<CellInfo>();

        #endregion

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

        #region Public Methods
        
        
        public void SetPropertyValue<T>(string propertyName, T propertyValue)
        {
            var properties = this.GetProperties()
                                    .Cast<PropertyDescriptor>()
                                    .Where(prop => prop.Name.Equals(propertyName));

            if (properties == null || properties.Count() != 1)
            {
                throw new Exception("The property doesn't exist.");
            }

            var property = properties.First();
            property.SetValue(this, propertyValue);

            OnPropertyChanged(propertyName);
        }

        public T GetPropertyValue<T>(string propertyName)
        {
            var properties = this.GetProperties()
                                .Cast<PropertyDescriptor>()
                                .Where(prop => prop.Name.Equals(propertyName));

            if (properties == null || properties.Count() != 1)
            {
                throw new Exception("The property doesn't exist.");
            }

            var property = properties.First();
            return (T)property.GetValue(this);
        }

        internal void AddProperty(string propertyName, Type dataType)
        {
            if (dataType == typeof(string))
                AddStringProperty<CustomTypeDescriptorBaseModel>(propertyName);
            if (dataType == typeof(int))
                AddIntProperty<CustomTypeDescriptorBaseModel>(propertyName);
            if (dataType == typeof(bool))
                AddBoolProperty<CustomTypeDescriptorBaseModel>(propertyName);
        }

        private void AddProperty<T, U>(string propertyName) where U : CustomTypeDescriptorBaseModel
        {
            var customProperty =
                    new CustomPropertyDescriptor<T>(
                                            propertyName,
                                            typeof(U));

            _properties.Add(customProperty);
            customProperty.AddValueChanged(
                                        this,
                                        (o, e) => { OnPropertyChanged(propertyName); });
        }

        private void AddStringProperty<U>(string propertyName) where U : CustomTypeDescriptorBaseModel
        {
            AddProperty<string, U>(propertyName);
        }
        private void AddIntProperty<U>(string propertyName) where U : CustomTypeDescriptorBaseModel
        {
            AddProperty<int, U>(propertyName);
        }
        private void AddBoolProperty<U>(string propertyName) where U : CustomTypeDescriptorBaseModel
        {
            AddProperty<bool, U>(propertyName);
        }

        #endregion        

        #region Overriden Methods

        public override PropertyDescriptorCollection GetProperties()
        {
            var properties = base.GetProperties();
            return new PropertyDescriptorCollection(
                                properties.Cast<PropertyDescriptor>()
                                          .Concat(_properties).ToArray());

        }

        #endregion
    }
}
