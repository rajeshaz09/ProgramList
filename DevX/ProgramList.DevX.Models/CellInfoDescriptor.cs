using System;
using System.ComponentModel;

namespace ProgramList.DevX.Models
{
	public class CellInfoDescriptor : PropertyDescriptor
	{
		private string _columnName;
		public CellInfoDescriptor(string columnName) : base(columnName, new Attribute[] { })
		{
			_columnName = columnName;
		}
		public override Type ComponentType { get { return typeof(ModelDataDictionary); } }
		public override bool IsReadOnly { get { return false; } }
		public override Type PropertyType { get { return typeof(object); } }
		public override bool CanResetValue(object component) { return false; }
		public override object GetValue(object component) =>
				(component as DynamicModel)?.GetValue(_columnName);
		public override void ResetValue(object component) { }
		public override void SetValue(object component, object value) =>
				(component as DynamicModel)?.SetValue(_columnName, value as CellInfo);
		public override bool ShouldSerializeValue(object component) { return false; }
	}

}
