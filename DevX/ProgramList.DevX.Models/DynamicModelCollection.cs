using DevExpress.Xpf.Core;
using System.ComponentModel;

namespace ProgramList.DevX.Models
{
    public class DynamicModelCollection<T> : ObservableCollectionCore<T>, ITypedList
	{
		private PropertyDescriptorCollection _propertyDescriptors;

		public DynamicModelCollection()
		{
		}
		public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return _propertyDescriptors;
		}

		public string GetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		public void UpdateDescriptors(PropertyDescriptorCollection propertyDescriptors)
		{
			_propertyDescriptors = propertyDescriptors;
		}
	}
}
