using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace DevX.PerformanceTest
{
    public class DynamicModel : DynamicObject, ICustomTypeDescriptor, INotifyPropertyChanged
    {
        private ModelBase _modelBase = new ModelBase();
        PropertyDescriptorCollection _props;

        private ModelData _cellDetails;

        public DynamicModel(PropertyDescriptorCollection props)
        {
            _props = props;
            _cellDetails = new ModelData(_props.Count);
            foreach (var property in _props.Cast<PropertyDescriptor>())
                _cellDetails.Add(property.Name, new CellInfo());
        }

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { _modelBase.PropertyChanged += value; }
            remove { _modelBase.PropertyChanged -= value; }
        }

        internal CellInfo GetValue(string columnName)
        {
            return _cellDetails[columnName];
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = GetValue(binder.Name);
            return true;
        }

        internal void SetValue(string columnName, CellInfo cellInfo)
        {
            _cellDetails[columnName] = cellInfo;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            SetValue(binder.Name, value as CellInfo);
            return true;
        }


        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _cellDetails.Keys;
        }

        #region ICustomTypeDescriptor
        public AttributeCollection GetAttributes()
        {
            return AttributeCollection.Empty;
        }

        public string GetClassName()
        {
            return null;
        }

        public string GetComponentName()
        {
            return null;
        }

        public TypeConverter GetConverter()
        {
            return new TypeConverter();
        }

        public EventDescriptor GetDefaultEvent()
        {
            return null;
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return null;
        }

        public object GetEditor(Type editorBaseType)
        {
            return null;
        }

        public EventDescriptorCollection GetEvents()
        {
            return EventDescriptorCollection.Empty;
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return GetEvents();
        }

        public PropertyDescriptorCollection GetProperties()
        {
            return _props;
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return GetProperties();
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return null;
        }
        #endregion ICustomTypeDescriptor
    }
}
