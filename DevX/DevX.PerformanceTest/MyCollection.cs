using DevExpress.Xpf.Core;
using System;
using System.ComponentModel;

namespace DevX.PerformanceTest
{
    public class MyCollection<T> : ObservableCollectionCore<T>, ITypedList
    {
        private PropertyDescriptorCollection _propertyInfo;

        public MyCollection(PropertyDescriptorCollection propertyInfo)
        {
            _propertyInfo = propertyInfo;
        }
        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            return _propertyInfo;
        }

        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return null;
        }
    }
}
